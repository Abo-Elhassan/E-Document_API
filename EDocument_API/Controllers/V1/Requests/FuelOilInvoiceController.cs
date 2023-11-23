using AutoMapper;
using EDocument_Data.Consts;
using EDocument_Data.Consts.Enums;
using EDocument_Data.DTOs.Attachments;
using EDocument_Data.DTOs.Filter;
using EDocument_Data.DTOs.Requests.FuelOilInvoiceRequest;
using EDocument_Data.DTOs.Requests.RefundRequest;
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
    public class FuelOilInvoiceController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private readonly ILogger<FuelOilInvoiceController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRequestReviewerRepository _requestReviewerRepository;
        private readonly IMailService _mailService;
        private readonly IFileService _fileService;

        public FuelOilInvoiceController(
            ILogger<FuelOilInvoiceController> logger,
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
        /// Get Fuel Oil Invoice Requests Details
        /// </summary>
        /// <param name="id">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>Fuel Oil Invoice Request</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FuelOilInvoiceRequestReadDto>))]
        [HttpGet("{id}")]
        [Authorize(Roles = "Store,Finance_FuelOil")]
        public async Task<ActionResult> GetFuelOilInvoiceRequestById(long id)
        {
            _logger.LogInformation($"Start GetFuelOilInvoiceRequestById from {nameof(RequestController)} for request id = {id}");

            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            var fuelOilInvoiceRequest = await _unitOfWork.Repository<FuelOilInvoiceRequest>().FindRequestAsync(
            requestId: id,
            expression: "Request.Id==@0",
            includes: includes
            );

            if (fuelOilInvoiceRequest is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Request not found" });

            var result = _mapper.Map<FuelOilInvoiceRequestReadDto>(fuelOilInvoiceRequest);

            return Ok(new ApiResponse<FuelOilInvoiceRequestReadDto> { StatusCode = (int)HttpStatusCode.OK, Details = result });
        }

        /// <summary>
        /// Delete Fuel Oil Invoice Requests By Id
        /// </summary>
        /// <param name="id">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        [Authorize(Roles = "Store")]
        public async Task<ActionResult> DeleteFuelOilInvoiceRequest(long id)
        {
            _logger.LogInformation($"Start DeleteFuelOilInvoiceRequest from {nameof(RequestController)} for request id = {id}");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var includes = new string[] { "FuelOilInvoiceRequest", "Attachments", "RequestReviewers" };

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

            request.FuelOilInvoiceRequest.ModifiedBy = user?.FullName;
            request.ModifiedBy = user?.FullName;
            _unitOfWork.Complete();

            _unitOfWork.Repository<Request>().Delete(request);
            _unitOfWork.Complete();

            _fileService.DeleteFolder($@"FuelOilInvoiceRequest\{id}");

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = "Request deleted successfully" });
        }

        /// <summary>
        /// Get All Fuel Oil Invoice Requests By Creator With Filter
        /// </summary>
        /// <param name="filterDto">filter information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of All Created Fuel Oil Invoice Requests</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FilterReadDto<FuelOilInvoiceRequestReadDto>>))]
        [HttpPost("Inbox")]
        [Authorize(Roles = "Store")]
        public async Task<ActionResult> GetCreatorFuelOilInvoiceRequestsFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetCreatorFuelOilInvoiceRequestsFiltered from {nameof(RequestController)} with filter: {JsonSerializer.Serialize(filterDto)}");
            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            string? userCondition = null;

            (int TotalCount, IEnumerable<FuelOilInvoiceRequest> PaginatedData) result;

            userCondition = "Request.CreatorId ==@0";

            if (!string.IsNullOrEmpty(filterDto?.FilterValue))
            {
                result = await _unitOfWork.Repository<FuelOilInvoiceRequest>().FindAllRequestsAsync(
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
                result = await _unitOfWork.Repository<FuelOilInvoiceRequest>().FindAllRequestsAsync(
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

            var requests = _mapper.Map<List<FuelOilInvoiceRequestReadDto>>(result.PaginatedData);

            var response = new FilterReadDto<FuelOilInvoiceRequestReadDto>
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = filterDto?.PageNo ?? 1,
                PageSize = requests.Count,
                PaginatedData = requests
            };
            return Ok(new ApiResponse<FilterReadDto<FuelOilInvoiceRequestReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = response });
        }

        /// <summary>
        /// Get All Fuel Oil Invoice Requests By Reviewer With Filter
        /// </summary>
        /// <param name="filterDto">filter information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of All Reviewer Fuel Oil Invoice Requests</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FilterReadDto<FuelOilInvoiceRequestReviewerReadDto>>))]
        [HttpPost("AssignedToMe")]
        [Authorize(Roles = "Finance_FuelOil")]
        public async Task<ActionResult> GetReviewerFuelOilInvoiceRequestsFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetReviewerFuelOilInvoiceRequestsFiltered from {nameof(RequestController)} with filter: {JsonSerializer.Serialize(filterDto)}");
            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            string? userCondition = null;

            (int TotalCount, IEnumerable<FuelOilInvoiceRequest> PaginatedData) result;

            userCondition = "Request.RequestReviewers.Any(AssignedReviewerId == @0 )";

            if (!string.IsNullOrEmpty(filterDto?.FilterValue))
            {
                result = await _unitOfWork.Repository<FuelOilInvoiceRequest>().FindAllRequestsAsync(
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
                result = await _unitOfWork.Repository<FuelOilInvoiceRequest>().FindAllRequestsAsync(
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

            var requests = _mapper.Map<List<FuelOilInvoiceRequestReviewerReadDto>>(result.PaginatedData);

            foreach (var request in requests)
            {
                var reviewer = request.RequestReviewers?.OrderBy(r => r.StageNumber).FirstOrDefault(y => y.AssignedReviewerId == User.FindFirstValue(ClaimTypes.NameIdentifier));

                request.ReviewerStatus = reviewer?.Status;
                request.ReviewerStage = reviewer?.StageNumber;
            }

            var response = new FilterReadDto<FuelOilInvoiceRequestReviewerReadDto>
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = filterDto?.PageNo ?? 1,
                PageSize = requests.Count,
                PaginatedData = requests
            };
            return Ok(new ApiResponse<FilterReadDto<FuelOilInvoiceRequestReviewerReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = response });
        }

        /// <summary>
        /// Create Fuel Oil Invoice Request
        /// </summary>
        /// <param name="fuelOilInvoiceRequestCreateDto">Fuel Oil Invoice request Information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [Consumes("multipart/form-data")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPost("Create")]
        [Authorize(Roles = "Store")]
        public async Task<ActionResult> CreateFuelOilInvoiceRequest([FromForm] FuelOilInvoiceRequestCreateDto fuelOilInvoiceRequestCreateDto)
        {
            _logger.LogInformation($"Start CreateFuelOilInvoiceRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(fuelOilInvoiceRequestCreateDto)} ");

            if (!string.IsNullOrEmpty(fuelOilInvoiceRequestCreateDto.InvoiceNumber))
            {
                Expression<Func<FuelOilInvoiceRequest, bool>> criteria = (r => r.InvoiceNumber == fuelOilInvoiceRequestCreateDto.InvoiceNumber);

                var checkDuplicateInvoiceResult = await _unitOfWork.Repository<FuelOilInvoiceRequest>().FindAsync(criteria);

                if (checkDuplicateInvoiceResult != null)
                    return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = $"There is request already created for invoice no. {checkDuplicateInvoiceResult.InvoiceNumber}" });

            }



            var user = await _userManager.Users.Include(t => t.Department).FirstOrDefaultAsync(u => u.Id == User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var requestId = long.Parse(DateTime.Now.ToString("yyyyMMddhhmmssff"));
            var requestNo = $"FuelInvoice-{DateTime.Now.ToString("yyyyMMddhhmmss")}";

            var request = new Request { Id = requestId, DefinedRequestId = fuelOilInvoiceRequestCreateDto.DefinedRequestId };
            request.Notes = fuelOilInvoiceRequestCreateDto.Notes;
            request.FuelOilInvoiceRequest = _mapper.Map<FuelOilInvoiceRequest>(fuelOilInvoiceRequestCreateDto);
            _mapper.Map(user, request.FuelOilInvoiceRequest);
            request.FuelOilInvoiceRequest.RequestNumber = requestNo;

            if (fuelOilInvoiceRequestCreateDto.Attachments != null && fuelOilInvoiceRequestCreateDto.Attachments.Count > 0)
            {
                request.Attachments = _fileService.UploadAttachments(requestId, $@"FuelOilInvoiceRequest\{requestId}", fuelOilInvoiceRequestCreateDto.Attachments, user.FullName);
            }

            request.CreatorId = user?.Id;
            request.FuelOilInvoiceRequest.CreatedBy = user?.FullName;
            request.CreatedBy = user?.FullName;
            request.FuelOilInvoiceRequest.CreatedBy = user?.FullName;

            _unitOfWork.Repository<Request>().Add(request);

            var result = _unitOfWork.Complete();

            await _requestReviewerRepository.BeginRequestCycle(fuelOilInvoiceRequestCreateDto.DefinedRequestId, requestId, user.Id, true);


            #region Send Emails

            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {user.FullName.Split(" ")[0]},
                    Kindly not that your Fuel Oil Invoice Request on eDocuement has been created successfully and it's under reviewing now.
                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with your request Status.

                    - eDocument Request Reference No.: {requestNo}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"Fuel Oil Invoice Request No. {requestNo} on eDocuement",
                To = user.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            var reviewersEmails = await _requestReviewerRepository.GetAllRequestReviewersEmailsByStageNumberAsync(requestId, request.CurrentStage);
            var reviewerMailContent = new MailContent
            {
                Body = $"""
                Dears,
                    Kindly note that {user.FullName} has created Fuel Oil Invoice Request for on eDocuement and need to be reviewed from your side.

                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                    - eDocument Request Reference No.: {requestNo}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                """,
                IsHTMLBody = false,
                Subject = $"Fuel Oil Invoice Request No. {requestNo} on eDocuement",
                To = reviewersEmails
            };

            _mailService.SendMailAsync(reviewerMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Request has been created successfully - Request No. {requestNo}" });
        }

        /// <summary>
        /// Update Fuel Oil Invoice Request
        /// </summary>
        /// <param name="id">Fuel Oil Invoice request Id</param>
        /// <param name="fuelOilInvoiceRequestUpdateDto">Fuel Oil Invoice request Information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [Consumes("multipart/form-data")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("Update/{id}")]
        [Authorize(Roles = "Store")]
        public async Task<ActionResult> UpdateFuelOilInvoiceRequest(long id, [FromForm] FuelOilInvoiceRequestUpdateDto fuelOilInvoiceRequestUpdateDto)
        {
            _logger.LogInformation($"Start UpdateFuelOilInvoiceRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(fuelOilInvoiceRequestUpdateDto)} ");
            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == id);

            var request = await _unitOfWork.Repository<Request>().FindAsync(requestRxpression, new string[] { "FuelOilInvoiceRequest", "RequestReviewers", "Attachments" });

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
            request.Notes = fuelOilInvoiceRequestUpdateDto.Notes;
            _mapper.Map(fuelOilInvoiceRequestUpdateDto, request.FuelOilInvoiceRequest);
            request.FuelOilInvoiceRequest.RequestId = id;

            if (fuelOilInvoiceRequestUpdateDto.Attachments == null || fuelOilInvoiceRequestUpdateDto.Attachments.Count == 0)
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

                request.Attachments = _fileService.UploadAttachments(request.Id, $@"FuelOilInvoiceRequest\{request.Id}", fuelOilInvoiceRequestUpdateDto.Attachments, createdBy: request.CreatedBy, modifiedBy: user.FullName, modifiedAt: DateTime.Now);
            }

            request.FuelOilInvoiceRequest.ModifiedAt = DateTime.Now;
            request.FuelOilInvoiceRequest.ModifiedBy = user?.FullName;
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
                    Kindly not that your Fuel Oil Invoice Request on eDocuement has been updated successfully and it's under reviewing now.
                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with your request Status.

                    - eDocument Request Reference No.: {request.FuelOilInvoiceRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"Fuel Oil Invoice Request No. {request.FuelOilInvoiceRequest.RequestNumber} on eDocuement",
                To = user.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            var reviewersEmails = await _requestReviewerRepository.GetAllRequestReviewersEmailsByStageNumberAsync(request.Id, request.CurrentStage);
            var reviewerMailContent = new MailContent
            {
                Body = $"""
                Dears,
                    Kindly note that {user.FullName} has updated Fuel Oil Invoice Request for on eDocuement and need to be reviewed from your side.

                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                    - eDocument Request Reference No.: {request.FuelOilInvoiceRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                """,
                IsHTMLBody = false,
                Subject = $"Fuel Oil Invoice Request No. {request.FuelOilInvoiceRequest.RequestNumber} on eDocuement",
                To = reviewersEmails
            };

            _mailService.SendMailAsync(reviewerMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Request has been updated successfully" });
        }

        /// <summary>
        /// Approve Fuel Oil Invoice Request
        /// </summary>
        /// <param name="requestReviewerWriteDto">Approve Fuel Oil Invoice Request</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("Approve")]
        [Authorize(Roles = "Finance_FuelOil")]
        public async Task<ActionResult> ApproveFuelOilInvoiceRequest(ApproveFuelOilInvoiceRequestDto requestReviewerWriteDto)
        {
            _logger.LogInformation($"Start ApproveFuelOilInvoiceRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(requestReviewerWriteDto)} ");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == requestReviewerWriteDto.RequestId);
            var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "FuelOilInvoiceRequest", "Creator", "Creator.Department", "Creator.Department.Manager" });

            if (request != null)
            {
                request.FuelOilInvoiceRequest.SwiftNumber = requestReviewerWriteDto.SwiftNumber;
                request.FuelOilInvoiceRequest.ModifiedBy = user?.FullName;
            }
            else
            {
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Request Not Found" });

            }

            var result = await _requestReviewerRepository.ApproveRequestAsync(_mapper.Map<ApproveRequestReviewerDto>(requestReviewerWriteDto), user);

            if (!result.IsSucceded)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = result.Message });

            #region Send Emails

            var requestCreator = request.Creator;
            if (request?.Status == RequestStatus.Approved.ToString())
            {
                var requestCreatorDirectManager = request.Creator.Manager;
                var requestCreatorDepartmentManager = request.Creator.Department.Manager;
                var creatorMailContent = new MailContent
                {
                    Body = $"""
                Dear {requestCreator.FullName.Split(" ")[0]},
                    Kindly not that your Fuel Oil Invoice Request {request.FuelOilInvoiceRequest.RequestNumber} on eDocuement has been approved successfully.
                    For more detail, please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}).

                    - eDocument Request Reference No.: {request.FuelOilInvoiceRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                    IsHTMLBody = false,
                    Subject = $"Fuel Oil Invoice Request No. {request.FuelOilInvoiceRequest.RequestNumber} on eDocuement",
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
                        Kindly note that {requestCreator.FullName} has created Fuel Oil Invoice Request for on eDocuement and need to be reviewed from your side.

                        Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                        - eDocument Request Reference No.: {request.FuelOilInvoiceRequest.RequestNumber}

                    Thanks,

                    “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                    """,
                    IsHTMLBody = false,
                    Subject = $"Fuel Oil Invoice Request No. {request.FuelOilInvoiceRequest.RequestNumber} on eDocuement",
                    To = reviewersEmails
                };

                _mailService.SendMailAsync(reviewerMailContent);
            }

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Your action has been recorded successfully" });
        }

        /// <summary>
        /// Decline Fuel Oil Invoice Request
        /// </summary>
        /// <param name="requestReviewerWriteDto">Decline Fuel Oil Invoice Request</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("Decline")]
        [Authorize(Roles = "Finance_FuelOil")]
        public async Task<ActionResult> DeclineFuelOilInvoiceRequest(DeclineRequestReviewerDto requestReviewerWriteDto)
        {
            _logger.LogInformation($"Start DeclineFuelOilInvoiceRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(requestReviewerWriteDto)} ");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var result = await _requestReviewerRepository.DeclineRequestAsync(requestReviewerWriteDto, user);
            if (!result.IsSucceded)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = result.Message });

            #region Send Emails

            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == requestReviewerWriteDto.RequestId);
            var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "FuelOilInvoiceRequest", "Creator" });

            var requestCreator = request.Creator;
            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {requestCreator.FullName.Split(" ")[0]},
                    Kindly not that your Fuel Oil Invoice Request No. {request.FuelOilInvoiceRequest.RequestNumber} on eDocuement has been declined by {user.FullName}.
                    For more detail, please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}).

                    - eDocument Request Reference No.: {request.FuelOilInvoiceRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"Fuel Oil Invoice Request No. {request.FuelOilInvoiceRequest.RequestNumber} on eDocuement",
                To = requestCreator.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Your action has been recorded successfully" });
        }

       

    }
}
