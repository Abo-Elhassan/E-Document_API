using AutoMapper;
using EDocument_Data.Consts;
using EDocument_Data.Consts.Enums;
using EDocument_Data.DTOs.Filter;
using EDocument_Data.DTOs.Requests.VoucherRequest;
using EDocument_Data.DTOs.Requests.RequestReviewer;
using EDocument_Data.Models;
using EDocument_Data.Models.Shared;
using EDocument_Repositories.Application_Repositories.Request_Reviewer_Repository;
using EDocument_Services.File_Service;
using EDocument_Services.Mail_Service;
using EDocument_UnitOfWork;
using Microsoft.AspNetCore.Authorization;
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
    public class VoucherController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private readonly ILogger<VoucherController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRequestReviewerRepository _requestReviewerRepository;
        private readonly IMailService _mailService;
        private readonly IFileService _fileService;

        public VoucherController(
            ILogger<VoucherController> logger,
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
        /// Get Voucher Request Details
        /// </summary>
        /// <param name="id">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>Voucher Request</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<VoucherRequestReadDto>))]
        [HttpGet("{id}")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> GetVoucherRequestById(long id)
        {
            _logger.LogInformation($"Start GetVoucherRequestById from {nameof(RequestController)} for request id = {id}");

            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            var VoucherRequest = await _unitOfWork.Repository<VoucherRequest>().FindRequestAsync(
            requestId: id,
            expression: "Request.Id==@0",
            includes: includes
            );

            if (VoucherRequest is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Request not found" });

            var result = _mapper.Map<VoucherRequestReadDto>(VoucherRequest);

            return Ok(new ApiResponse<VoucherRequestReadDto> { StatusCode = (int)HttpStatusCode.OK, Details = result });
        }

        /// <summary>
        /// Delete Voucher Request By Id
        /// </summary>
        /// <param name="id">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> DeleteVoucherRequest(long id)
        {
            _logger.LogInformation($"Start DeleteVoucherRequest from {nameof(RequestController)} for request id = {id}");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var includes = new string[] { "VoucherRequest", "Attachments", "RequestReviewers" };

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

            request.VoucherRequest.ModifiedBy = user?.FullName;
            request.ModifiedBy = user?.FullName;
            _unitOfWork.Complete();

            _unitOfWork.Repository<Request>().Delete(request);
            _unitOfWork.Complete();

            _fileService.DeleteFolder($@"VoucherRequest\{id}");

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = "Request deleted successfully" });
        }

        /// <summary>
        /// Get All Voucher Requests By Creator With Filter
        /// </summary>
        /// <param name="filterDto">filter information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of All Created Voucher Requests</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FilterReadDto<VoucherRequestReadDto>>))]
        [HttpPost("Inbox")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> GetCreatorVoucherRequestsFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetCreatorVoucherRequestsFiltered from {nameof(RequestController)} with filter: {JsonSerializer.Serialize(filterDto)}");
            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            string? userCondition = null;

            (int TotalCount, IEnumerable<VoucherRequest> PaginatedData) result;

            userCondition = "Request.CreatorId ==@0";

            if (!string.IsNullOrEmpty(filterDto?.FilterValue))
            {
                result = await _unitOfWork.Repository<VoucherRequest>().FindAllRequestsAsync(
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
                result = await _unitOfWork.Repository<VoucherRequest>().FindAllRequestsAsync(
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

            var requests = _mapper.Map<List<VoucherRequestReadDto>>(result.PaginatedData);

            var response = new FilterReadDto<VoucherRequestReadDto>
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = filterDto?.PageNo ?? 1,
                PageSize = requests.Count,
                PaginatedData = requests
            };
            return Ok(new ApiResponse<FilterReadDto<VoucherRequestReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = response });
        }

        /// <summary>
        /// Get All Voucher Requests By Reviewer With Filter
        /// </summary>
        /// <param name="filterDto">filter information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of All Reviewer Voucher Requests</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FilterReadDto<VoucherRequestReviewerReadDto>>))]
        [HttpPost("AssignedToMe")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> GetReviewerVoucherRequestsFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetReviewerVoucherRequestsFiltered from {nameof(RequestController)} with filter: {JsonSerializer.Serialize(filterDto)}");
            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            string? userCondition = null;

            (int TotalCount, IEnumerable<VoucherRequest> PaginatedData) result;

            userCondition = "Request.RequestReviewers.Any(AssignedReviewerId == @0 )";

            if (!string.IsNullOrEmpty(filterDto?.FilterValue))
            {
                result = await _unitOfWork.Repository<VoucherRequest>().FindAllRequestsAsync(
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
                result = await _unitOfWork.Repository<VoucherRequest>().FindAllRequestsAsync(
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

            var requests = _mapper.Map<List<VoucherRequestReviewerReadDto>>(result.PaginatedData);

            foreach (var request in requests)
            {
                var reviewer = request.RequestReviewers?.OrderBy(r => r.StageNumber).FirstOrDefault(y => y.AssignedReviewerId == User.FindFirstValue(ClaimTypes.NameIdentifier));

                request.ReviewerStatus = reviewer?.Status;
                request.ReviewerStage = reviewer?.StageNumber;
            }

            var response = new FilterReadDto<VoucherRequestReviewerReadDto>
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = filterDto?.PageNo ?? 1,
                PageSize = requests.Count,
                PaginatedData = requests
            };
            return Ok(new ApiResponse<FilterReadDto<VoucherRequestReviewerReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = response });
        }

        /// <summary>
        /// Create Voucher Request
        /// </summary>
        /// <param name="voucherRequestCreateDto">Voucher request Information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [Consumes("multipart/form-data")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPost("Create")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> CreateVoucherRequest([FromForm] VoucherRequestCreateDto voucherRequestCreateDto)
        {
            _logger.LogInformation($"Start CreateVoucherRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(voucherRequestCreateDto)} ");

            if (!string.IsNullOrEmpty(voucherRequestCreateDto.InvoiceNumber))
            {
                Expression<Func<VoucherRequest, bool>> criteria = (r => r.InvoiceNumber == voucherRequestCreateDto.InvoiceNumber);

                var checkDuplicateInvoiceResult = await _unitOfWork.Repository<VoucherRequest>().FindAsync(criteria);

                if (checkDuplicateInvoiceResult != null)
                    return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = $"There is request already created for invoice no. {checkDuplicateInvoiceResult.InvoiceNumber}" });

            }



            var user = await _userManager.Users.Include(t => t.Department).FirstOrDefaultAsync(u => u.Id == User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var requestId = long.Parse(DateTime.Now.ToString("yyyyMMddhhmmssff"));
            var requestNo = $"FuelInvoice-{DateTime.Now.ToString("yyyyMMddhhmmss")}";

            var request = new Request { Id = requestId, DefinedRequestId = voucherRequestCreateDto.DefinedRequestId };
            request.Notes = voucherRequestCreateDto.Notes;
            request.VoucherRequest = _mapper.Map<VoucherRequest>(voucherRequestCreateDto);
            _mapper.Map(user, request.VoucherRequest);
            request.VoucherRequest.RequestNumber = requestNo;

            if (voucherRequestCreateDto.Attachments != null && voucherRequestCreateDto.Attachments.Count > 0)
            {
                request.Attachments = _fileService.UploadAttachments(requestId, $@"VoucherRequest\{requestId}", voucherRequestCreateDto.Attachments, user.FullName);
            }

            request.CreatorId = user?.Id;
            request.VoucherRequest.CreatedBy = user?.FullName;
            request.CreatedBy = user?.FullName;
            request.VoucherRequest.CreatedBy = user?.FullName;

            _unitOfWork.Repository<Request>().Add(request);

            var result = _unitOfWork.Complete();

            await _requestReviewerRepository.BeginRequestCycle(voucherRequestCreateDto.DefinedRequestId, requestId, user.Id, true);


            #region Send Emails

            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {user.FullName.Split(" ")[0]},
                    Kindly not that your Voucher Request on eDocuement has been created successfully and it's under reviewing now.
                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with your request Status.

                    - eDocument Request Reference No.: {requestNo}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"Voucher Request No. {requestNo} on eDocuement",
                To = user.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            var reviewersEmails = await _requestReviewerRepository.GetAllRequestReviewersEmailsByStageNumberAsync(requestId, request.CurrentStage);
            var reviewerMailContent = new MailContent
            {
                Body = $"""
                Dears,
                    Kindly note that {user.FullName} has created Voucher Request for on eDocuement and need to be reviewed from your side.

                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                    - eDocument Request Reference No.: {requestNo}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                """,
                IsHTMLBody = false,
                Subject = $"Voucher Request No. {requestNo} on eDocuement",
                To = reviewersEmails
            };

            _mailService.SendMailAsync(reviewerMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Request has been created successfully - Request No. {requestNo}" });
        }

        /// <summary>
        /// Update Voucher Request
        /// </summary>
        /// <param name="id">Voucher request Id</param>
        /// <param name="voucherRequestUpdateDto">Voucher request Information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [Consumes("multipart/form-data")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("Update/{id}")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> UpdateVoucherRequest(long id, [FromForm] VoucherRequestUpdateDto voucherRequestUpdateDto)
        {
            _logger.LogInformation($"Start UpdateVoucherRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(voucherRequestUpdateDto)} ");
            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == id);

            var request = await _unitOfWork.Repository<Request>().FindAsync(requestRxpression, new string[] { "VoucherRequest", "RequestReviewers", "Attachments" });

            if (request == null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"Request not found" });

            if (request.Status == RequestStatus.Approved.ToString())
            {
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = $"You cannot update this request as it has been already approved" });
            }
            else if (request.RequestReviewers.Any(rr => rr.Status == RequestStatus.Approved.ToString()) && request.Status == RequestStatus.Pending.ToString())
            {
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "You cannot update the request after one of the reviewers took his action" });
            }

            var user = await _userManager.Users.Include(t => t.Department).FirstOrDefaultAsync(u => u.Id == User.FindFirstValue(ClaimTypes.NameIdentifier)!);




            var oldAttachments = request.Attachments;
            request.Notes = voucherRequestUpdateDto.Notes;
            _mapper.Map(voucherRequestUpdateDto, request.VoucherRequest);
            request.VoucherRequest.RequestId = id;

            if (voucherRequestUpdateDto.Attachments == null || voucherRequestUpdateDto.Attachments.Count == 0)
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

                request.Attachments = _fileService.UploadAttachments(request.Id, $@"VoucherRequest\{request.Id}", voucherRequestUpdateDto.Attachments, createdBy: request.CreatedBy, modifiedBy: user.FullName, modifiedAt: DateTime.Now);
            }

            request.VoucherRequest.ModifiedAt = DateTime.Now;
            request.VoucherRequest.ModifiedBy = user?.FullName;
            request.ModifiedBy = user?.FullName;

            var result = _unitOfWork.Complete();

            await _requestReviewerRepository.BeginRequestCycle(request.DefinedRequestId, request.Id, user.Id, false);

            if (result < 1)
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "Request update has been failed" });

            #region Send Emails

            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {user.FullName.Split(" ")[0]},
                    Kindly not that your Voucher Request on eDocuement has been updated successfully and it's under reviewing now.
                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with your request Status.

                    - eDocument Request Reference No.: {request.VoucherRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"Voucher Request No. {request.VoucherRequest.RequestNumber} on eDocuement",
                To = user.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            var reviewersEmails = await _requestReviewerRepository.GetAllRequestReviewersEmailsByStageNumberAsync(request.Id, request.CurrentStage);
            var reviewerMailContent = new MailContent
            {
                Body = $"""
                Dears,
                    Kindly note that {user.FullName} has updated Voucher Request for on eDocuement and need to be reviewed from your side.

                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                    - eDocument Request Reference No.: {request.VoucherRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                """,
                IsHTMLBody = false,
                Subject = $"Voucher Request No. {request.VoucherRequest.RequestNumber} on eDocuement",
                To = reviewersEmails
            };

            _mailService.SendMailAsync(reviewerMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Request has been updated successfully" });
        }

        /// <summary>
        /// Approve Voucher Request
        /// </summary>
        /// <param name="requestReviewerWriteDto">Approve Voucher Request</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("Approve")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> ApproveVoucherRequest(ApproveRequestReviewerDto requestReviewerWriteDto)
        {
            _logger.LogInformation($"Start ApproveVoucherRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(requestReviewerWriteDto)} ");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == requestReviewerWriteDto.RequestId);
            var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "VoucherRequest", "Creator", "Creator.Department", "Creator.Department.Manager" });

            if (request == null)
            {
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Request Not Found" });
            }

            var result = await _requestReviewerRepository.ApproveRequestAsync(requestReviewerWriteDto, user);

            if (!result.IsSucceded)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = result.Message });

            #region Send Emails

            var requestCreator = request.Creator;
            if (request?.Status == RequestStatus.Approved.ToString())
            {
                var creatorMailContent = new MailContent
                {
                    Body = $"""
                Dear {requestCreator.FullName.Split(" ")[0]},
                    Kindly not that your Voucher Request {request.VoucherRequest.RequestNumber} on eDocuement has been approved successfully.
                    For more detail, please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}).

                    - eDocument Request Reference No.: {request.VoucherRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                    IsHTMLBody = false,
                    Subject = $"Voucher Request No. {request.VoucherRequest.RequestNumber} on eDocuement",
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
                        Kindly note that {requestCreator.FullName} has created Voucher Request for on eDocuement and need to be reviewed from your side.

                        Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                        - eDocument Request Reference No.: {request.VoucherRequest.RequestNumber}

                    Thanks,

                    “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                    """,
                    IsHTMLBody = false,
                    Subject = $"Voucher Request No. {request.VoucherRequest.RequestNumber} on eDocuement",
                    To = reviewersEmails
                };

                _mailService.SendMailAsync(reviewerMailContent);
            }

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Your action has been recorded successfully" });
        }

        /// <summary>
        /// Decline Voucher Request
        /// </summary>
        /// <param name="requestReviewerWriteDto">Decline Voucher Request</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("Decline")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> DeclineVoucherRequest(DeclineRequestReviewerDto requestReviewerWriteDto)
        {
            _logger.LogInformation($"Start DeclineVoucherRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(requestReviewerWriteDto)} ");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var result = await _requestReviewerRepository.DeclineRequestAsync(requestReviewerWriteDto, user);
            if (!result.IsSucceded)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = result.Message });

            #region Send Emails

            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == requestReviewerWriteDto.RequestId);
            var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "VoucherRequest", "Creator" });

            var requestCreator = request.Creator;
            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {requestCreator.FullName.Split(" ")[0]},
                    Kindly not that your Voucher Request No. {request.VoucherRequest.RequestNumber} on eDocuement has been declined by {user.FullName}.
                    For more detail, please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}).

                    - eDocument Request Reference No.: {request.VoucherRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"Voucher Request No. {request.VoucherRequest.RequestNumber} on eDocuement",
                To = requestCreator.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Your action has been recorded successfully" });
        }

       

    }
}
