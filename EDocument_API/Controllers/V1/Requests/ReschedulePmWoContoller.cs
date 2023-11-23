using AutoMapper;
using EDocument_Data.Consts.Enums;
using EDocument_Data.Consts;
using EDocument_Data.DTOs.Attachments;
using EDocument_Data.DTOs.Filter;
using EDocument_Data.DTOs.Requests.ReschedulePmWoRequest;
using EDocument_Data.DTOs.Requests.RequestReviewer;
using EDocument_Data.Models;
using EDocument_Data.Models.Shared;
using EDocument_Repositories.Application_Repositories.Request_Reviewer_Repository;
using EDocument_Services.File_Service;
using EDocument_Services.Mail_Service;
using EDocument_UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Net;
using System.Net.Mime;
using System.Security.Claims;
using System.Text.Json;

namespace EDocument_API.Controllers.V1.Requests
{
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    [ApiController]
    [Route("api/v{version:apiVersion}/Request/[controller]")]
    [ApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiResponse<string>))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ApiResponse<string>))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ApiResponse<string>))]
    public class ReschedulePmWoContoller : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private readonly ILogger<ReschedulePmWoContoller> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRequestReviewerRepository _requestReviewerRepository;
        private readonly IMailService _mailService;
        private readonly IFileService _fileService;

        public ReschedulePmWoContoller(
            ILogger<ReschedulePmWoContoller> logger,
            UserManager<User> userManager,
            IMapper mapper,
            IUnitOfWork unitOfWork,
            IRequestReviewerRepository RequestReviewerRepository,
            IMailService mailService,
            IFileService fileService)
        {
            _userManager = userManager;
            _mapper = mapper;
            _logger = logger;
            _unitOfWork = unitOfWork;
            _requestReviewerRepository = RequestReviewerRepository;
            _mailService = mailService;
            _fileService = fileService;
        }

        /// <summary>
        /// Get Reschedule Pm/Wo Request By Id
        /// </summary>
        /// <param name="id">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>Reschedule Pm/Wo Request</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<ReschedulePmWoRequestReadDto>))]
        [HttpGet("{id}")]
        [Authorize(Roles = "Engineering")]
        public async Task<ActionResult> GetReschedulePmWoRequestById(long id)
        {
            _logger.LogInformation($"Start GetReschedulePmWoRequestById from {nameof(RequestController)} for request id = {id}");

            var includes = new string[] { "Request", "Request.RequestReviewers", "Request.Attachments" };
            var reschedulePmWoRequest = await _unitOfWork.Repository<ReschedulePmWoRequest>().FindRequestAsync(
            requestId: id,
            expression: "Request.Id==@0",
            includes: includes
            );

            if (reschedulePmWoRequest is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Request not found" });

            var result = _mapper.Map<ReschedulePmWoRequestReadDto>(reschedulePmWoRequest);

            return Ok(new ApiResponse<ReschedulePmWoRequestReadDto> { StatusCode = (int)HttpStatusCode.OK, Details = result });
        }

        /// <summary>
        /// Delete Reschedule Pm/Wo Request By Id
        /// </summary>
        /// <param name="id">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        [Authorize(Roles = "Engineering")]
        public async Task<ActionResult> DeleteReschedulePmWoRequest(long id)
        {
            _logger.LogInformation($"Start DeleteReschedulePmWoRequest from {nameof(RequestController)} for request id = {id}");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var includes = new string[] { "ReschedulePmWoRequest", "Attachments", "RequestReviewers" };

            var request = await _unitOfWork.Repository<Request>().FindRequestAsync(
            requestId: id,
            expression: "Id==@0",
            includes: includes
                );

            if (request is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Request not found" });

            if (request.Status == RequestStatus.Approved.ToString() || request.Status == RequestStatus.Declined.ToString())
            {
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = $"You cannot delete this request as it has been already {request.Status}" });
            }
            else if (request.RequestReviewers.Any(rr => rr.Status == RequestStatus.Approved.ToString()))
            {
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "You cannot delete the request after one of the reviewers took his action" });
            }

            request.ReschedulePmWoRequest.ModifiedBy = user?.FullName;
            request.ModifiedBy = user?.FullName;
            _unitOfWork.Complete();

            _unitOfWork.Repository<Request>().Delete(request);
            _unitOfWork.Complete();

            _fileService.DeleteFolder($@"ReschedulePmWoRequest\{id}");

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = "Request deleted successfully" });
        }

        /// <summary>
        /// Get All Reschedule Pm/Wo Requests By Creator With Filter
        /// </summary>
        /// <param name="filterDto">filter information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of All Created Reschedule Pm/Wo Requests</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FilterReadDto<ReschedulePmWoRequestReadDto>>))]
        [HttpPost("Inbox")]
        [Authorize(Roles = "Engineering")]
        public async Task<ActionResult> GetCreatorReschedulePmWoRequestsFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetCreatorReschedulePmWoRequestsFiltered from {nameof(RequestController)} with filter: {JsonSerializer.Serialize(filterDto)}");
            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            string? userCondition = null;

            (int TotalCount, IEnumerable<ReschedulePmWoRequest> PaginatedData) result;

            userCondition = "Request.CreatorId ==@0";

            if (!string.IsNullOrEmpty(filterDto?.FilterValue))
            {
                result = await _unitOfWork.Repository<ReschedulePmWoRequest>().FindAllRequestsAsync(
                userId: User.FindFirstValue(ClaimTypes.NameIdentifier)!,
                userCondition: userCondition,
                filterValue: filterDto?.FilterValue,
                includes: includes,
                skip: ((filterDto?.PageNo ?? 1) - 1) * (filterDto?.PageSize ?? 10),
                take: filterDto?.PageSize ?? 10,
                orderBy: filterDto?.orderBy,
                orderByDirection: filterDto?.orderByDirection,
                dateFilters: filterDto?.dateFilters
                );
            }
            else
            {
                result = await _unitOfWork.Repository<ReschedulePmWoRequest>().FindAllRequestsAsync(
                isCreator: true,
                userId: User.FindFirstValue(ClaimTypes.NameIdentifier)!,
                userCondition: userCondition,
                filters: filterDto?.Filters,
                includes: includes,
                skip: ((filterDto?.PageNo ?? 1) - 1) * (filterDto?.PageSize ?? 10),
                take: filterDto?.PageSize ?? 10,
                orderBy: filterDto?.orderBy,
                orderByDirection: filterDto?.orderByDirection,
                dateFilters: filterDto?.dateFilters
                );
            }

            var totalCount = result.TotalCount;
            var totalPages = (int)Math.Ceiling((decimal)totalCount / (filterDto?.PageSize ?? 10));

            var requests = _mapper.Map<List<ReschedulePmWoRequestReadDto>>(result.PaginatedData);

            var response = new FilterReadDto<ReschedulePmWoRequestReadDto>
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = filterDto?.PageNo ?? 1,
                PageSize = requests.Count,
                PaginatedData = requests
            };
            return Ok(new ApiResponse<FilterReadDto<ReschedulePmWoRequestReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = response });
        }

        /// <summary>
        /// Get All Reschedule Pm/Wo Requests By Reviewer With Filter
        /// </summary>
        /// <param name="filterDto">filter information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of All Reviewer Reschedule Pm/Wo Requests</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FilterReadDto<ReschedulePmWoRequestReviewerReadDto>>))]
        [HttpPost("AssignedToMe")]
        [Authorize(Roles = "Engineering")]
        public async Task<ActionResult> GetReviewerReschedulePmWoRequestsFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetReviewerReschedulePmWoRequestsFiltered from {nameof(RequestController)} with filter: {JsonSerializer.Serialize(filterDto)}");
            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            string? userCondition = null;

            (int TotalCount, IEnumerable<ReschedulePmWoRequest> PaginatedData) result;

            userCondition = "Request.RequestReviewers.Any(AssignedReviewerId == @0 )";

            if (!string.IsNullOrEmpty(filterDto?.FilterValue))
            {
                result = await _unitOfWork.Repository<ReschedulePmWoRequest>().FindAllRequestsAsync(
                userId: User.FindFirstValue(ClaimTypes.NameIdentifier)!,
                userCondition: userCondition,
                filterValue: filterDto?.FilterValue,
                includes: includes,
                skip: ((filterDto?.PageNo ?? 1) - 1) * (filterDto?.PageSize ?? 10),
                take: filterDto?.PageSize ?? 10,
                orderBy: filterDto?.orderBy,
                orderByDirection: filterDto?.orderByDirection,
                dateFilters: filterDto?.dateFilters
                );
            }
            else
            {
                result = await _unitOfWork.Repository<ReschedulePmWoRequest>().FindAllRequestsAsync(
                isCreator: false,
                userId: User.FindFirstValue(ClaimTypes.NameIdentifier)!,
                userCondition: userCondition,
                filters: filterDto?.Filters,
                includes: includes,
                skip: ((filterDto?.PageNo ?? 1) - 1) * (filterDto?.PageSize ?? 10),
                take: filterDto?.PageSize ?? 10,
                orderBy: filterDto?.orderBy,
                orderByDirection: filterDto?.orderByDirection,
                dateFilters: filterDto?.dateFilters
                );
            }

            var totalCount = result.TotalCount;
            var totalPages = (int)Math.Ceiling((decimal)totalCount / (filterDto?.PageSize ?? 10));

            var requests = _mapper.Map<List<ReschedulePmWoRequestReviewerReadDto>>(result.PaginatedData);

            foreach (var request in requests)
            {
                var reviewer = request.RequestReviewers?.OrderBy(r => r.StageNumber).FirstOrDefault(y => y.AssignedReviewerId == User.FindFirstValue(ClaimTypes.NameIdentifier));

                request.ReviewerStatus = reviewer?.Status;
                request.ReviewerStage = reviewer?.StageNumber;
            }

            var response = new FilterReadDto<ReschedulePmWoRequestReviewerReadDto>
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = filterDto?.PageNo ?? 1,
                PageSize = requests.Count,
                PaginatedData = requests
            };
            return Ok(new ApiResponse<FilterReadDto<ReschedulePmWoRequestReviewerReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = response });
        }

        /// <summary>
        /// Create Reschedule Pm/Wo Request
        /// </summary>
        /// <param name="reschedulePmWoRequestCreateDto">Reschedule Pm/Wo request Information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [Consumes("multipart/form-data")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPost("Create")]
        [Authorize(Roles = "Engineering")]
        public async Task<ActionResult> CreateReschedulePmWoRequest([FromForm] ReschedulePmWoRequestCreateDto reschedulePmWoRequestCreateDto)
        {
            _logger.LogInformation($"Start CreateReschedulePmWoRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(reschedulePmWoRequestCreateDto)} ");
            var requestId = long.Parse(DateTime.Now.ToString("yyyyMMddhhmmssff"));

            var requestNo = $"ReschedulePmWo-{DateTime.Now.ToString("yyyyMMddhhmmss")}";
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var request = new Request { Id = requestId, DefinedRequestId = reschedulePmWoRequestCreateDto.DefinedRequestId };
            request.Notes = reschedulePmWoRequestCreateDto.Notes;
            request.ReschedulePmWoRequest = _mapper.Map<ReschedulePmWoRequest>(reschedulePmWoRequestCreateDto);
            request.ReschedulePmWoRequest.RequestNumber = requestNo;

            if (reschedulePmWoRequestCreateDto.Attachments != null && reschedulePmWoRequestCreateDto.Attachments.Count > 0)
            {
                request.Attachments = _fileService.UploadAttachments(requestId, $@"ReschedulePmWoRequest\{requestId}", reschedulePmWoRequestCreateDto.Attachments, user.FullName);
            }

            request.CreatorId = user?.Id;
            request.ReschedulePmWoRequest.CreatedBy = user?.FullName;
            request.CreatedBy = user?.FullName;
            request.ReschedulePmWoRequest.CreatedBy = user?.FullName;

            _unitOfWork.Repository<Request>().Add(request);

            var result = _unitOfWork.Complete();

            await _requestReviewerRepository.BeginRequestCycle(reschedulePmWoRequestCreateDto.DefinedRequestId, requestId, user.Id, true);


            #region Send Emails

            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {user.FullName.Split(" ")[0]},
                    Kindly not that your Reschedule Pm/Wo Request on eDocuement has been created successfully and it's under reviewing now.
                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with your request Status.

                    - eDocument Request Reference No.: {requestNo}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"Reschedule Pm/Wo Request No. {requestNo} on eDocuement",
                To = user.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            var reviewersEmails = await _requestReviewerRepository.GetAllRequestReviewersEmailsByStageNumberAsync(requestId, request.CurrentStage);
            var reviewerMailContent = new MailContent
            {
                Body = $"""
                Dears,
                    Kindly note that {user.FullName} has created Reschedule Pm/Wo Request for on eDocuement and need to be reviewed from your side.

                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                    - eDocument Request Reference No.: {requestNo}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                """,
                IsHTMLBody = false,
                Subject = $"Reschedule Pm/Wo Request No. {requestNo} on eDocuement",
                To = reviewersEmails
            };

            _mailService.SendMailAsync(reviewerMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Request has been created successfully - Request No. {requestNo}" });
        }

        /// <summary>
        /// Update Reschedule Pm/Wo Request
        /// </summary>
        /// <param name="id">Travel Desk request Id</param>
        /// <param name="reschedulePmWoRequestUpdateDto">ReschedulePmWo request Information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [Consumes("multipart/form-data")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("Update/{id}")]
        [Authorize(Roles = "Engineering")]
        public async Task<ActionResult> UpdateReschedulePmWoRequest(long id, [FromForm] ReschedulePmWoRequestUpdateDto reschedulePmWoRequestUpdateDto)
        {
            _logger.LogInformation($"Start UpdateReschedulePmWoRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(reschedulePmWoRequestUpdateDto)} ");

            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == id);

            var request = await _unitOfWork.Repository<Request>().FindAsync(requestRxpression, new string[] { "ReschedulePmWoRequest", "RequestReviewers", "Attachments" });

            if (request == null)
            {
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"Request not found" });

            }
            else if (request.Status == RequestStatus.Approved.ToString())
            {
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = $"You cannot update this request as it has been already approved" });
            }
            else if (request.RequestReviewers.Any(rr => rr.Status == RequestStatus.Approved.ToString()) && request.Status == RequestStatus.Pending.ToString())
            {
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "You cannot update the request after one of the reviewers took his action" });
            }

            var oldAttachments = request.Attachments;
            request.Notes = reschedulePmWoRequestUpdateDto.Notes;
            _mapper.Map(reschedulePmWoRequestUpdateDto, request.ReschedulePmWoRequest);

            if (reschedulePmWoRequestUpdateDto.Attachments == null || reschedulePmWoRequestUpdateDto.Attachments.Count == 0)
            {
                request.Attachments = oldAttachments;
            }
            else
            {
                foreach (var attachment in request.Attachments)
                {
                    attachment.ModifiedAt = DateTime.Now;
                    attachment.ModifiedBy = user.FullName;
                }

                foreach (var oldAttachment in oldAttachments)
                {
                    _fileService.DeleteFile(oldAttachment.FilePath);
                }

                request.Attachments = _fileService.UploadAttachments(request.Id, $@"ReschedulePmWoRequestUpdateDto\{request.Id}", reschedulePmWoRequestUpdateDto.Attachments, createdBy: request.CreatedBy, modifiedBy: user.FullName, modifiedAt: DateTime.Now);
            }

            request.ReschedulePmWoRequest.ModifiedAt = DateTime.Now;
            request.ReschedulePmWoRequest.ModifiedBy = user?.FullName;
            request.ModifiedBy = user?.FullName;

            var result = _unitOfWork.Complete();

            await _requestReviewerRepository.BeginRequestCycle(request.DefinedRequestId, request.Id, user.Id, false);

            #region Send Emails

            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {user.FullName.Split(" ")[0]},
                    Kindly not that your Reschedule Pm/Wo Request on eDocuement has been updated successfully and it's under reviewing now.
                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with your request Status.

                    - eDocument Request Reference No.: {request.ReschedulePmWoRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"Reschedule Pm/Wo Request No. {request.ReschedulePmWoRequest.RequestNumber} on eDocuement",
                To = user.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            var reviewersEmails = await _requestReviewerRepository.GetAllRequestReviewersEmailsByStageNumberAsync(request.Id, request.CurrentStage);
            var reviewerMailContent = new MailContent
            {
                Body = $"""
                Dears,
                    Kindly note that {user.FullName} has updated Reschedule Pm/Wo Request for on eDocuement and need to be reviewed from your side.

                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                    - eDocument Request Reference No.: {request.ReschedulePmWoRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                """,
                IsHTMLBody = false,
                Subject = $"Reschedule Pm/Wo Request No. {request.ReschedulePmWoRequest.RequestNumber} on eDocuement",
                To = reviewersEmails
            };

            _mailService.SendMailAsync(reviewerMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Request has been updated successfully" });
        }

        /// <summary>
        /// Approve Reschedule Pm/Wo Request
        /// </summary>
        /// <param name="requestReviewerWriteDto">Approve Reschedule Pm/Wo Request</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("Approve")]
        [Authorize(Roles = "Engineering")]
        public async Task<ActionResult> ApproveReschedulePmWoRequest(ApproveRequestReviewerDto requestReviewerWriteDto)
        {
            _logger.LogInformation($"Start ApproveReschedulePmWoRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(requestReviewerWriteDto)} ");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var result = await _requestReviewerRepository.ApproveRequestAsync(requestReviewerWriteDto, user);

            if (!result.IsSucceded)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = result.Message });

            #region Send Emails

            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == requestReviewerWriteDto.RequestId);
            var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "ReschedulePmWoRequest", "Creator" });
            var requestCreator = request.Creator;
            if (request?.Status == RequestStatus.Approved.ToString())
            {

                var creatorMailContent = new MailContent
                {
                    Body = $"""
                Dear {requestCreator.FullName.Split(" ")[0]},
                    Kindly not that your Reschedule Pm/Wo Request {request.ReschedulePmWoRequest.RequestNumber} on eDocuement has been approved successfully.
                    For more detail, please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}).

                    - eDocument Request Reference No.: {request.ReschedulePmWoRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                    IsHTMLBody = false,
                    Subject = $"Reschedule Pm/Wo Request No. {request.ReschedulePmWoRequest.RequestNumber} on eDocuement",
                    To = requestCreator.Email
                };

                _mailService.SendMailAsync(creatorMailContent);
            }
            else
            {
                var reviewersEmails = await _requestReviewerRepository.GetAllRequestReviewersEmailsByStageNumberAsync(requestReviewerWriteDto.RequestId, request.CurrentStage);
                var reviewerMailContent = new MailContent
                {
                    Body = $"""
                    Dears,
                        Kindly note that {requestCreator.FullName} has created Reschedule Pm/Wo Request for on eDocuement and need to be reviewed from your side.

                        Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                        - eDocument Request Reference No.: {request.ReschedulePmWoRequest.RequestNumber}

                    Thanks,

                    “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                    """,
                    IsHTMLBody = false,
                    Subject = $"Reschedule Pm/Wo Request No. {request.ReschedulePmWoRequest.RequestNumber} on eDocuement",
                    To = reviewersEmails
                };

                _mailService.SendMailAsync(reviewerMailContent);
            }

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Your action has been recorded successfully" });
        }

        /// <summary>
        /// Decline Reschedule Pm/Wo Request
        /// </summary>
        /// <param name="requestReviewerWriteDto">Decline Reschedule Pm/Wo Request</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("Decline")]
        [Authorize(Roles = "Engineering")]
        public async Task<ActionResult> DeclineReschedulePmWoRequest(DeclineRequestReviewerDto requestReviewerWriteDto)
        {
            _logger.LogInformation($"Start DeclineReschedulePmWoRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(requestReviewerWriteDto)} ");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var result = await _requestReviewerRepository.DeclineRequestAsync(requestReviewerWriteDto, user);
            if (!result.IsSucceded)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = result.Message });

            #region Send Emails

            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == requestReviewerWriteDto.RequestId);
            var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "ReschedulePmWoRequest", "Creator" });

            var requestCreator = request.Creator;
            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {requestCreator.FullName.Split(" ")[0]},
                    Kindly not that your Reschedule Pm/Wo Request No. {request.ReschedulePmWoRequest.RequestNumber} on eDocuement has been declined by {user.FullName}.
                    For more detail, please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}).

                    - eDocument Request Reference No.: {request.ReschedulePmWoRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"Reschedule Pm/Wo Request No. {request.ReschedulePmWoRequest.RequestNumber} on eDocuement",
                To = requestCreator.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Your action has been recorded successfully" });
        }

    }
}
