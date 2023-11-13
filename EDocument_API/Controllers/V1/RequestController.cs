using AutoMapper;
using EDocument_Data.Consts;
using EDocument_Data.Consts.Enums;
using EDocument_Data.DTOs.Attachments;
using EDocument_Data.DTOs.Filter;
using EDocument_Data.DTOs.Requests;
using EDocument_Data.DTOs.Requests.AccessControlRequest;
using EDocument_Data.DTOs.Requests.CCTVAccessRequest;
using EDocument_Data.DTOs.Requests.DiscountRequest;
using EDocument_Data.DTOs.Requests.EquipmentInAreaRequest;
using EDocument_Data.DTOs.Requests.EquipmentOutAreaRequest;
using EDocument_Data.DTOs.Requests.FuelOilInvoiceRequest;
using EDocument_Data.DTOs.Requests.NewItemRequest;
using EDocument_Data.DTOs.Requests.PoRequest;
using EDocument_Data.DTOs.Requests.PRRequest;
using EDocument_Data.DTOs.Requests.RefundRequest;
using EDocument_Data.DTOs.Requests.RequestReviewer;
using EDocument_Data.DTOs.Requests.TravelDeskRequest;
using EDocument_Data.DTOs.Requests.VehicleRequest;
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
using Newtonsoft.Json;
using System.Linq.Expressions;
using System.Net;
using System.Net.Mime;
using System.Security.Claims;
using JsonSerializer = System.Text.Json.JsonSerializer;

using Models = EDocument_Data.Models;

namespace EDocument_API.Controllers.V1
{
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiResponse<string>))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ApiResponse<string>))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ApiResponse<string>))]
    public class RequestController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private readonly ILogger<RequestController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRequestReviewerRepository _requestReviewerRepository;
        private readonly IMailService _mailService;
        private readonly IFileService _fileService;

        public RequestController(
            ILogger<RequestController> logger,
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
        /// Get Requests Dashboard Info
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>Requests Dashboard Info</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<RequestDashboardReadDto>))]
        [HttpGet("Dashboard")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> GetRequestsDashboardInfo()
        {
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            _logger.LogInformation($"Start GetRequestsDashboardInfo from {nameof(RequestController)} for user id = {user.Id}");

            Expression<Func<Request, bool>> allRequestsExpression = (r => r.CreatorId == user.Id);
            var createdRequests = await _unitOfWork.Repository<Request>().FindAllAsync(allRequestsExpression, new string[] { "DefinedRequest" });

            var response = new RequestDashboardReadDto();

            response.CreatedRequests = createdRequests.Count();
            response.PendingRequests = createdRequests.Count(r => r.Status == RequestStatus.Pending.ToString());
            response.ApprovedRequests = createdRequests.Count(r => r.Status == RequestStatus.Approved.ToString());
            response.DeclinedRequests = createdRequests.Count(r => r.Status == RequestStatus.Declined.ToString());
            var recentCreatedRequests = _mapper.Map<List<RecentRequestReadDto>>(createdRequests);

            foreach (var request in recentCreatedRequests)
            {
                request.UserRole = "Creator";
            }

            Expression<Func<Request, bool>> reviewingRequestsExpression = (r => r.RequestReviewers.Any(rr => rr.AssignedReviewerId == user.Id && r.CurrentStage == rr.StageNumber));
            var reviewingRequests = await _unitOfWork.Repository<Request>().FindAllAsync(reviewingRequestsExpression, new string[] { "RequestReviewers", "DefinedRequest" });

            var recentReviewingRequests = _mapper.Map<List<RecentRequestReadDto>>(reviewingRequests);

            foreach (var request in recentReviewingRequests)
            {
                request.UserRole = "Reviewer";
            }
            var recentRequests = new List<RecentRequestReadDto>();
            recentRequests.AddRange(recentCreatedRequests);
            recentRequests.AddRange(recentReviewingRequests);
            response.RecentRequests = recentRequests;
            response.RecentRequests = response.RecentRequests.OrderByDescending(r => r.CreatedAt).Take(10).ToList();

            return Ok(new ApiResponse<RequestDashboardReadDto> { StatusCode = (int)HttpStatusCode.OK, Details = response });
        }

        /// <summary>
        /// Get Request Reviewers Details
        /// </summary>
        /// <param name="id">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>Request Reviewers Details</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<ReviewersDetailsDto>))]
        [HttpGet("Reviewers/{id}")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> GetRequestReviewersById(long id)
        {
            _logger.LogInformation($"Start GetRequestReviewersById from {nameof(RequestController)} for request id = {id}");
            var reviewerDetails = new ReviewersDetailsDto();
            (int CurrentStage, List<ReviewersDetails> ReviewersDetails) response;
            var request = await _unitOfWork.Repository<Models.Request>().GetByIdAsync(id);
            if (request is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Request not found" });

            reviewerDetails.ReviewersDetails = await _requestReviewerRepository.GetAllRequestReviewersAsync(id);
            reviewerDetails.CurrentStage = request.CurrentStage;
            reviewerDetails.Status = (RequestStatus)Enum.Parse(typeof(RequestStatus), request.Status);

            return Ok(new ApiResponse<ReviewersDetailsDto> { StatusCode = (int)HttpStatusCode.OK, Details = reviewerDetails });
        }

        #region Procurement

        #region PO Request

        /// <summary>
        /// Get PO Requests By Id
        /// </summary>
        /// <param name="id">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>PO Request</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<PoRequestReadDto>))]
        [HttpGet("Po/{id}")]
        [Authorize(Roles = "Finance,Procurement")]
        public async Task<ActionResult> GetPoRequestById(long id)
        {
            _logger.LogInformation($"Start GetPoRequestById from {nameof(RequestController)} for request id = {id}");

            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            var poRequest = await _unitOfWork.Repository<PoRequest>().FindRequestAsync(
            requestId: id,
            expression: "Request.Id==@0",
            includes: includes
            );

            if (poRequest is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Request not found" });

            var result = _mapper.Map<PoRequestReadDto>(poRequest);
            result.InvoiceAttachment = _mapper.Map<AttachmentReadDto>(poRequest.InvoiceAttachmentPath);
            result.PoAttachment = _mapper.Map<AttachmentReadDto>(poRequest.PoAttachmentPath);

            return Ok(new ApiResponse<PoRequestReadDto> { StatusCode = (int)HttpStatusCode.OK, Details = result });
        }

        /// <summary>
        /// Delete PO Requests By Id
        /// </summary>
        /// <param name="id">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpDelete("Po/{id}")]
        [Authorize(Roles = "Procurement")]
        public async Task<ActionResult> DeletePoRequest(long id)
        {
            _logger.LogInformation($"Start DeletePoRequest from {nameof(RequestController)} for request id = {id}");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var includes = new string[] { "PoRequest", "Attachments", "RequestReviewers" };

            var request = await _unitOfWork.Repository<Models.Request>().FindRequestAsync(
            requestId: id,
            expression: "Id==@0",
            includes: includes
                );

            if (request is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Request not found" });

            if (request.Status == RequestStatus.Approved.ToString() || request.Status == RequestStatus.Declined.ToString())
            {
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = $"You cannot delete this request after as it has been already {request.Status}" });
            }
            else if (request.RequestReviewers.Any(rr => rr.Status == RequestStatus.Approved.ToString()))
            {
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "You cannot delete the request after one of the reviewers took his action" });
            }

            request.PoRequest.ModifiedBy = user?.FullName;
            request.ModifiedBy = user?.FullName;
            _unitOfWork.Complete();

            _unitOfWork.Repository<Models.Request>().Delete(request);
            _unitOfWork.Complete();

            _fileService.DeleteFolder($@"PoRequest\{id}");

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = "Request deleted successfully" });
        }

        /// <summary>
        /// Get All PO Requests By Creator With Filter
        /// </summary>
        /// <param name="filterDto">filter information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of All Created PO Requests</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FilterReadDto<PoRequestReadDto>>))]
        [HttpPost("Po/Inbox")]
        [Authorize(Roles = "Procurement")]
        public async Task<ActionResult> GetCreatorPoRequestsFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetCreatorPoRequestsFiltered from {nameof(RequestController)} with filter: {JsonSerializer.Serialize(filterDto)}");
            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            string? userCondition = null;

            (int TotalCount, IEnumerable<PoRequest> PaginatedData) result;

            userCondition = "Request.CreatorId ==@0";

            if (!string.IsNullOrEmpty(filterDto?.FilterValue))
            {
                result = await _unitOfWork.Repository<PoRequest>().FindAllRequestsAsync(
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
                result = await _unitOfWork.Repository<PoRequest>().FindAllRequestsAsync(
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

            var requests = _mapper.Map<List<PoRequestReadDto>>(result.PaginatedData);

            var response = new FilterReadDto<PoRequestReadDto>
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = filterDto?.PageNo ?? 1,
                PageSize = requests.Count,
                PaginatedData = requests
            };
            return Ok(new ApiResponse<FilterReadDto<PoRequestReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = response });
        }

        /// <summary>
        /// Get All PO Requests By Reviewer With Filter
        /// </summary>
        /// <param name="filterDto">filter information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of All Reviewer PO Requests</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FilterReadDto<PoRequestReviewerReadDto>>))]
        [HttpPost("Po/AssignedToMe")]
        [Authorize(Roles = "Finance")]
        public async Task<ActionResult> GetReviewerPoRequestsFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetReviewerPoRequestsFiltered from {nameof(RequestController)} with filter: {JsonSerializer.Serialize(filterDto)}");
            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            string? userCondition = null;

            (int TotalCount, IEnumerable<PoRequest> PaginatedData) result;

            userCondition = "Request.RequestReviewers.Any(AssignedReviewerId == @0 && Request.CurrentStage >= StageNumber)";

            if (!string.IsNullOrEmpty(filterDto?.FilterValue))
            {
                result = await _unitOfWork.Repository<PoRequest>().FindAllRequestsAsync(
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
                result = await _unitOfWork.Repository<PoRequest>().FindAllRequestsAsync(
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

            var requests = _mapper.Map<List<PoRequestReviewerReadDto>>(result.PaginatedData);

            foreach (var request in requests)
            {
                var reviewer = request.RequestReviewers?.OrderBy(r => r.StageNumber).LastOrDefault(y => y.AssignedReviewerId == User.FindFirstValue(ClaimTypes.NameIdentifier) && y.Status != RequestStatus.None);

                request.ReviewerStatus = reviewer?.Status;
                request.ReviewerStage = reviewer?.StageNumber;
            }

            var response = new FilterReadDto<PoRequestReviewerReadDto>
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = filterDto?.PageNo ?? 1,
                PageSize = requests.Count,
                PaginatedData = requests
            };
            return Ok(new ApiResponse<FilterReadDto<PoRequestReviewerReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = response });
        }

        /// <summary>
        /// Create PO Request
        /// </summary>
        /// <param name="poRequestCreateDto">Po request Informarion</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [Consumes("multipart/form-data")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPost("Po/Create")]
        [Authorize(Roles = "Procurement")]
        public async Task<ActionResult> CreatePoRequest([FromForm] PoRequestCreateDto poRequestCreateDto)
        {
            _logger.LogInformation($"Start CreatePoRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(poRequestCreateDto)} ");
            var requestId = long.Parse(DateTime.Now.ToString("yyyyMMddhhmmssff"));

            var requestNo = $"PO-{DateTime.Now.ToString("yyyyMMddhhmmss")}";
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var request = new Models.Request { Id = requestId, DefinedRequestId = poRequestCreateDto.DefinedRequestId };

            request.Notes = poRequestCreateDto.Remarks;
            request.PoRequest = _mapper.Map<PoRequest>(poRequestCreateDto);
            request.PoRequest.RequestNumber = requestNo;
            request.PoRequest.PoAttachmentPath = _fileService.UploadAttachment($@"PoRequest\{requestId}", poRequestCreateDto.PoAttachment);
            request.PoRequest.InvoiceAttachmentPath = _fileService.UploadAttachment($@"PoRequest\{requestId}", poRequestCreateDto.InvoiceAttachment);

            if (poRequestCreateDto.Attachments != null && poRequestCreateDto.Attachments.Count > 0)
            {
                request.Attachments = _fileService.UploadAttachments(requestId, $@"PoRequest\{requestId}", poRequestCreateDto.Attachments, user.FullName);
            }

            request.CreatorId = user?.Id;
            request.PoRequest.CreatedBy = user?.FullName;
            request.CreatedBy = user?.FullName;
            request.PoRequest.CreatedBy = user?.FullName;

            _unitOfWork.Repository<Models.Request>().Add(request);

            var result = _unitOfWork.Complete();

            await _requestReviewerRepository.BeginRequestCycle(poRequestCreateDto.DefinedRequestId, requestId, user.Id, true);
            if (result < 1) BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "Adding new request has been failed" });

            #region Send Emails

            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {user.FullName.Split(" ")[0]},
                    Kindly not that your Po Request  for PO Number {request.PoRequest.PoNumber} on eDocuement has been created successfully and it's under reviewing now.
                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with your request Status.

                    - eDocument Request Reference No.: {requestNo}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"PO Request for {request.PoRequest.PoNumber} on eDocuement",
                To = user.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            var reviewersEmails = await _requestReviewerRepository.GetAllRequestReviewersEmailsByStageNumberAsync(requestId, request.CurrentStage);
            var reviewerMailContent = new MailContent
            {
                Body = $"""
                Dears,
                    Kindly note that {user.FullName} has created Po Request for PO Number ({request.PoRequest.PoNumber}) on eDocuement and need to be reviewed from your side.

                    Request Details:

                    - PO Number: {request.PoRequest.PoNumber}
                    - Invoice Number: {request.PoRequest.InvoiceNumber}
                    - Vendor Name: {request.PoRequest.VendorName}
                    - Vendor Number: {request.PoRequest.VendorNumber}
                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                    - eDocument Request Reference No.: {requestNo}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                """,
                IsHTMLBody = false,
                Subject = $"PO Request for {request.PoRequest.PoNumber} on eDocuement",
                To = reviewersEmails
            };

            _mailService.SendMailAsync(reviewerMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Request has been created successfully - Request No. {requestNo}" });
        }

        /// <summary>
        /// Update PO Request
        /// </summary>
        /// <param name="id">Po request Id</param>
        /// <param name="poRequestUpdateDto">Po request Informarion</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [Consumes("multipart/form-data")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("Po/Update/{id}")]
        [Authorize(Roles = "Procurement")]
        public async Task<ActionResult> UpdatePoRequest(long id, [FromForm] PoRequestUpdateDto poRequestUpdateDto)
        {
            _logger.LogInformation($"Start UpdatePoRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(poRequestUpdateDto)} ");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            Expression<Func<Models.Request, bool>> requestRxpression = (r => r.Id == id);

            var request = await _unitOfWork.Repository<Models.Request>().FindAsync(requestRxpression, new string[] { "PoRequest", "Attachments" });

            if (request == null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"Request not found" });

            var oldPoAttachmentPath = request.PoRequest.PoAttachmentPath;
            var oldInvoiceAtachmentPath = request.PoRequest.InvoiceAttachmentPath;
            var oldAttachments = request.Attachments;

            request.Notes = poRequestUpdateDto.Remarks;
            _mapper.Map(poRequestUpdateDto, request);
            _mapper.Map(poRequestUpdateDto, request.PoRequest);

            if (poRequestUpdateDto.PoAttachment == null)
            {
                request.PoRequest.PoAttachmentPath = oldPoAttachmentPath;
            }
            else
            {
                _fileService.DeleteFile(oldPoAttachmentPath);
                request.PoRequest.PoAttachmentPath = _fileService.UploadAttachment($@"PoRequest\{request.Id}", poRequestUpdateDto.PoAttachment);
            }

            if (poRequestUpdateDto.InvoiceAttachment == null)
            {
                request.PoRequest.InvoiceAttachmentPath = oldInvoiceAtachmentPath;
            }
            else
            {
                _fileService.DeleteFile(oldInvoiceAtachmentPath);
                request.PoRequest.InvoiceAttachmentPath = _fileService.UploadAttachment($@"PoRequest\{request.Id}", poRequestUpdateDto.InvoiceAttachment);
            }

            if (poRequestUpdateDto.Attachments == null || poRequestUpdateDto.Attachments.Count == 0)
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

                request.Attachments = _fileService.UploadAttachments(request.Id, $@"PoRequest\{request.Id}", poRequestUpdateDto.Attachments, createdBy: request.PoRequest.CreatedBy, modifiedBy: user.FullName, modifiedAt: DateTime.Now);
            }

            request.PoRequest.ModifiedAt = DateTime.Now;
            request.PoRequest.ModifiedBy = user?.FullName;
            request.ModifiedBy = user?.FullName;

            var result = _unitOfWork.Complete();

            await _requestReviewerRepository.BeginRequestCycle(request.DefinedRequestId, request.Id, user.Id, false);

            if (result < 1) BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "Request update has been failed" });

            #region Send Emails

            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {user.FullName.Split(" ")[0]},
                    Kindly not that your Po Request  for PO Number {request.PoRequest.PoNumber} on eDocuement has been updated successfully and it's under reviewing now.
                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with your request Status.

                    - eDocument Request Reference No.: {request.PoRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"PO Request for {request.PoRequest.PoNumber} on eDocuement",
                To = user.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            var reviewersEmails = await _requestReviewerRepository.GetAllRequestReviewersEmailsByStageNumberAsync(id, request.CurrentStage);
            var reviewerMailContent = new MailContent
            {
                Body = $"""
                Dears,
                    Kindly note that {user.FullName} has updated Po Request for PO Number ({request.PoRequest.PoNumber}) on eDocuement and need to be reviewed from your side.

                    Request Details:

                    - PO Number: {request.PoRequest.PoNumber}
                    - Invoice Number: {request.PoRequest.InvoiceNumber}
                    - Vendor Name: {request.PoRequest.VendorName}
                    - Vendor Number: {request.PoRequest.VendorNumber}
                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                    - eDocument Request Reference No.: {request.PoRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                """,
                IsHTMLBody = false,
                Subject = $"PO Request for {request.PoRequest.PoNumber} on eDocuement",
                To = reviewersEmails
            };

            _mailService.SendMailAsync(reviewerMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Request has been updated successfully" });
        }

        /// <summary>
        /// Approve PO Request
        /// </summary>
        /// <param name="requestReviewerWriteDto">Approve Po Request</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("Po/Approve")]
        [Authorize(Roles = "Finance")]
        public async Task<ActionResult> ApprovePoRequest(ApproveRequestReviewerDto requestReviewerWriteDto)
        {
            _logger.LogInformation($"Start ApprovePoRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(requestReviewerWriteDto)} ");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var result = await _requestReviewerRepository.ApproveRequestAsync(requestReviewerWriteDto, user);
            if (!result.IsSucceded)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = result.Message });

            #region Send Emails

            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == requestReviewerWriteDto.RequestId);
            var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "PoRequest", "Creator", "Creator.Manager", "Creator.Department", "Creator.Department.Manager" });

            var requestCreator = request.Creator;
            var requestCreatorDirectManager = request.Creator.Manager;
            var requestCreatorDepartmentManager = request.Creator.Department.Manager;
            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {requestCreator.FullName.Split(" ")[0]},
                    Kindly not that your Po Request for PO Number {request.PoRequest.PoNumber} on eDocuement has been approved successfully by {user.FullName}.
                    For more detail, please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}).

                    - eDocument Request Reference No.: {request.PoRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"PO Request for {request.PoRequest.PoNumber} on eDocuement",
                Cc = $"{requestCreatorDirectManager.Email};{requestCreatorDepartmentManager.Email}",
                To = requestCreator.Email,
            };

            _mailService.SendMailAsync(creatorMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Your action has been recorded successfully" });
        }

        /// <summary>
        /// Decline PO Request
        /// </summary>
        /// <param name="requestReviewerWriteDto">Decline Po Request</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("Po/Decline")]
        [Authorize(Roles = "Finance")]
        public async Task<ActionResult> DeclinePoRequest(DeclineRequestReviewerDto requestReviewerWriteDto)
        {
            _logger.LogInformation($"Start DeclinePoRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(requestReviewerWriteDto)} ");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var result = await _requestReviewerRepository.DeclineRequestAsync(requestReviewerWriteDto, user);
            if (!result.IsSucceded)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = result.Message });

            #region Send Emails

            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == requestReviewerWriteDto.RequestId);
            var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "PoRequest", "Creator", "Creator.Manager", "Creator.Department", "Creator.Department.Manager" });

            var requestCreator = request.Creator;
            var requestCreatorDirectManager = request.Creator.Manager;
            var requestCreatorDepartmentManager = request.Creator.Department.Manager;
            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {requestCreator.FullName.Split(" ")[0]},
                    Kindly not that your Po Request for PO Number {request.PoRequest.PoNumber} on eDocuement has been declined by {user.FullName}.
                    For more detail, please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}).

                    - eDocument Request Reference No.: {request.PoRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"PO Request for {request.PoRequest.PoNumber} on eDocuement",
                Cc = $"{requestCreatorDirectManager.Email};{requestCreatorDepartmentManager.Email}",
                To = requestCreator.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Your action has been recorded successfully" });
        }

        #endregion PO Request

        #endregion Procurement

        #region Administration

        #region Vehicle Request

        /// <summary>
        /// Get Vehicle Requests By Id
        /// </summary>
        /// <param name="id">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>Vehicle Request</returns>

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<VehicleRequestReadDto>))]
        [HttpGet("Vehicle/{id}")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> GetVehicleRequestById(long id)
        {
            _logger.LogInformation($"Start GetVehicleRequestById from {nameof(RequestController)} for request id = {id}");

            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            var vehicleRequest = await _unitOfWork.Repository<VehicleRequest>().FindRequestAsync(
            requestId: id,
            expression: "Request.Id==@0",
            includes: includes
            );

            if (vehicleRequest is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Request not found" });

            var result = _mapper.Map<VehicleRequestReadDto>(vehicleRequest);

            return Ok(new ApiResponse<VehicleRequestReadDto> { StatusCode = (int)HttpStatusCode.OK, Details = result });
        }

        /// <summary>
        /// Delete Vehicle Requests By Id
        /// </summary>
        /// <param name="id">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpDelete("Vehicle/{id}")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> DeleteVehicleRequest(long id)
        {
            _logger.LogInformation($"Start DeleteVehicleRequest from {nameof(RequestController)} for request id = {id}");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var includes = new string[] { "VehicleRequest", "Attachments", "RequestReviewers" };

            var request = await _unitOfWork.Repository<Models.Request>().FindRequestAsync(
            requestId: id,
            expression: "Id==@0",
            includes: includes
                );

            if (request is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Request not found" });

            if (request.Status == RequestStatus.Approved.ToString() || request.Status == RequestStatus.Declined.ToString())
            {
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = $"You cannot delete this request after as it has been already {request.Status}" });
            }
            else if (request.RequestReviewers.Any(rr => rr.Status == RequestStatus.Approved.ToString()))
            {
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "You cannot delete the request after one of the reviewers took his action" });
            }

            request.VehicleRequest.ModifiedBy = user?.FullName;
            request.ModifiedBy = user?.FullName;
            _unitOfWork.Complete();

            _unitOfWork.Repository<Models.Request>().Delete(request);
            _unitOfWork.Complete();

            _fileService.DeleteFolder($@"VehicleRequest\{id}");

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = "Request deleted successfully" });
        }

        /// <summary>
        /// Get All Vehicle Requests By Creator With Filter
        /// </summary>
        /// <param name="filterDto">filter information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of All Created Vehicle Requests</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FilterReadDto<VehicleRequestReadDto>>))]
        [HttpPost("Vehicle/Inbox")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> GetCreatorVehicleRequestsFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetCreatorVehicleRequestsFiltered from {nameof(RequestController)} with filter: {JsonSerializer.Serialize(filterDto)}");
            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            string? userCondition = null;

            (int TotalCount, IEnumerable<VehicleRequest> PaginatedData) result;

            userCondition = "Request.CreatorId ==@0";

            if (!string.IsNullOrEmpty(filterDto?.FilterValue))
            {
                result = await _unitOfWork.Repository<VehicleRequest>().FindAllRequestsAsync(
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
                result = await _unitOfWork.Repository<VehicleRequest>().FindAllRequestsAsync(
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

            var requests = _mapper.Map<List<VehicleRequestReadDto>>(result.PaginatedData);

            var response = new FilterReadDto<VehicleRequestReadDto>
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = filterDto?.PageNo ?? 1,
                PageSize = requests.Count,
                PaginatedData = requests
            };
            return Ok(new ApiResponse<FilterReadDto<VehicleRequestReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = response });
        }

        /// <summary>
        /// Get All Vehicle Requests By Reviewer With Filter
        /// </summary>
        /// <param name="filterDto">filter information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of All Reviewer Vehicle Requests</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FilterReadDto<VehicleRequestReviewerReadDto>>))]
        [HttpPost("Vehicle/AssignedToMe")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> GetReviewerVehicleRequestsFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetReviewerVehicleRequestsFiltered from {nameof(RequestController)} with filter: {JsonSerializer.Serialize(filterDto)}");
            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            string? userCondition = null;

            (int TotalCount, IEnumerable<VehicleRequest> PaginatedData) result;

            userCondition = "Request.RequestReviewers.Any(AssignedReviewerId == @0 && Request.CurrentStage >= StageNumber)";

            if (!string.IsNullOrEmpty(filterDto?.FilterValue))
            {
                result = await _unitOfWork.Repository<VehicleRequest>().FindAllRequestsAsync(
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
                result = await _unitOfWork.Repository<VehicleRequest>().FindAllRequestsAsync(
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

            var requests = _mapper.Map<List<VehicleRequestReviewerReadDto>>(result.PaginatedData);

            foreach (var request in requests)
            {
                var reviewer = request.RequestReviewers?.OrderBy(r => r.StageNumber).LastOrDefault(y => y.AssignedReviewerId == User.FindFirstValue(ClaimTypes.NameIdentifier) && y.Status != RequestStatus.None);

                request.ReviewerStatus = reviewer?.Status;
                request.ReviewerStage = reviewer?.StageNumber;
            }

            var response = new FilterReadDto<VehicleRequestReviewerReadDto>
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = filterDto?.PageNo ?? 1,
                PageSize = requests.Count,
                PaginatedData = requests
            };
            return Ok(new ApiResponse<FilterReadDto<VehicleRequestReviewerReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = response });
        }

        /// <summary>
        /// Create Vehicle Request
        /// </summary>
        /// <param name="vehicleRequestCreateDto">Vehicle request Informarion</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [Consumes("multipart/form-data")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPost("Vehicle/Create")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> CreateVehicleRequest([FromForm] VehicleRequestCreateDto vehicleRequestCreateDto)
        {
            _logger.LogInformation($"Start CreateVehicleRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(vehicleRequestCreateDto)} ");

            var beneficiaryUser = await _userManager.Users.Include(t => t.Department).FirstOrDefaultAsync(u => u.Id == vehicleRequestCreateDto.BeneficiaryId);

            if (beneficiaryUser is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"Beneficiary user '{vehicleRequestCreateDto.BeneficiaryId}' not found" });

            if (beneficiaryUser.Company != "DP World")
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = $"Beneficiary user '{vehicleRequestCreateDto.BeneficiaryId}' is not DP WORLD Employee" });

            var requestId = long.Parse(DateTime.Now.ToString("yyyyMMddhhmmssff"));

            var requestNo = $"Vehicle-{DateTime.Now.ToString("yyyyMMddhhmmss")}";
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var request = new Models.Request { Id = requestId, DefinedRequestId = vehicleRequestCreateDto.DefinedRequestId };
            request.Notes = vehicleRequestCreateDto.Justification;
            request.VehicleRequest = _mapper.Map<VehicleRequest>(vehicleRequestCreateDto);
            request.VehicleRequest.RequestNumber = requestNo;
            _mapper.Map(beneficiaryUser, request.VehicleRequest);

            if (vehicleRequestCreateDto.Attachments != null && vehicleRequestCreateDto.Attachments.Count > 0)
            {
                request.Attachments = _fileService.UploadAttachments(requestId, $@"VehicleRequest\{requestId}", vehicleRequestCreateDto.Attachments, user.FullName);
            }

            request.CreatorId = user?.Id;
            request.VehicleRequest.CreatedBy = user?.FullName;
            request.CreatedBy = user?.FullName;
            request.VehicleRequest.CreatedBy = user?.FullName;

            _unitOfWork.Repository<Models.Request>().Add(request);

            var result = _unitOfWork.Complete();

            await _requestReviewerRepository.BeginRequestCycle(vehicleRequestCreateDto.DefinedRequestId, requestId, beneficiaryUser.Id, true);
            if (result < 1)
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "Adding new request has been failed" });

            #region Send Emails

            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {user.FullName.Split(" ")[0]},
                    Kindly not that your Vehicle Request on eDocuement has been created successfully and it's under reviewing now.
                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with your request Status.

                    - eDocument Request Reference No.: {requestNo}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"Vehicle Request No. {requestNo} on eDocuement",
                To = user.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            var reviewersEmails = await _requestReviewerRepository.GetAllRequestReviewersEmailsByStageNumberAsync(requestId, request.CurrentStage);
            var reviewerMailContent = new MailContent
            {
                Body = $"""
                Dears,
                    Kindly note that {user.FullName} has created Vehicle Request for on eDocuement and need to be reviewed from your side.

                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                    - eDocument Request Reference No.: {requestNo}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                """,
                IsHTMLBody = false,
                Subject = $"Vehicle Request No. {requestNo} on eDocuement",
                To = reviewersEmails
            };

            _mailService.SendMailAsync(reviewerMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Request has been created successfully - Request No. {requestNo}" });
        }

        /// <summary>
        /// Update Vehicle Request
        /// </summary>
        /// <param name="id">Vehicle request Id</param>
        /// <param name="vehicleRequestUpdateDto">Vehicle request Informarion</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [Consumes("multipart/form-data")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("Vehicle/Update/{id}")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> UpdateVehicleRequest(long id, [FromForm] VehicleRequestUpdateDto vehicleRequestUpdateDto)
        {
            _logger.LogInformation($"Start UpdateVehicleRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(vehicleRequestUpdateDto)} ");

            var beneficiaryUser = await _userManager.Users.Include(t => t.Department).FirstOrDefaultAsync(u => u.Id == vehicleRequestUpdateDto.BeneficiaryId);

            if (beneficiaryUser is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"Beneficiary user '{vehicleRequestUpdateDto.BeneficiaryId}' not found" });

            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            Expression<Func<Models.Request, bool>> requestRxpression = (r => r.Id == id);

            var request = await _unitOfWork.Repository<Models.Request>().FindAsync(requestRxpression, new string[] { "VehicleRequest", "Attachments" });

            if (request == null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"Request not found" });

            if (beneficiaryUser.Company != "DP World")
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = $"Beneficiary user '{vehicleRequestUpdateDto.BeneficiaryId}' is not DP WORLD Employee" });

            var oldAttachments = request.Attachments;

            request.Notes = vehicleRequestUpdateDto.Justification;
            _mapper.Map(vehicleRequestUpdateDto, request);
            _mapper.Map(vehicleRequestUpdateDto, request.VehicleRequest);
            _mapper.Map(beneficiaryUser, request.VehicleRequest);

            if (vehicleRequestUpdateDto.Attachments == null || vehicleRequestUpdateDto.Attachments.Count == 0)
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

                request.Attachments = _fileService.UploadAttachments(request.Id, $@"VehicleRequest\{request.Id}", vehicleRequestUpdateDto.Attachments, createdBy: request.PoRequest.CreatedBy, modifiedBy: user.FullName, modifiedAt: DateTime.Now);
            }

            request.VehicleRequest.ModifiedAt = DateTime.Now;
            request.VehicleRequest.ModifiedBy = user?.FullName;
            request.ModifiedBy = user?.FullName;

            var result = _unitOfWork.Complete();

            await _requestReviewerRepository.BeginRequestCycle(request.DefinedRequestId, request.Id, beneficiaryUser.Id, false);

            if (result < 1)
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "Request update has been failed" });

            #region Send Emails

            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {user.FullName.Split(" ")[0]},
                    Kindly not that your Vehicle Request on eDocuement has been updated successfully and it's under reviewing now.
                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with your request Status.

                    - eDocument Request Reference No.: {request.VehicleRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"Vehicle Request No. {request.VehicleRequest.RequestNumber} on eDocuement",
                To = user.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            var reviewersEmails = await _requestReviewerRepository.GetAllRequestReviewersEmailsByStageNumberAsync(request.Id, request.CurrentStage);
            var reviewerMailContent = new MailContent
            {
                Body = $"""
                Dears,
                    Kindly note that {user.FullName} has updated Vehicle Request for on eDocuement and need to be reviewed from your side.

                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                    - eDocument Request Reference No.: {request.VehicleRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                """,
                IsHTMLBody = false,
                Subject = $"Vehicle Request No. {request.VehicleRequest.RequestNumber} on eDocuement",
                To = reviewersEmails
            };

            _mailService.SendMailAsync(reviewerMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Request has been updated successfully" });
        }

        /// <summary>
        /// Approve Vehicle Request
        /// </summary>
        /// <param name="requestReviewerWriteDto">Approve Vehicle Request</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("Vehicle/Approve")]
        [Authorize]
        public async Task<ActionResult> ApproveVehicleRequest(ApproveRequestReviewerDto requestReviewerWriteDto)
        {
            _logger.LogInformation($"Start ApproveVehicleRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(requestReviewerWriteDto)} ");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var result = await _requestReviewerRepository.ApproveRequestAsync(requestReviewerWriteDto, user);
            if (!result.IsSucceded)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = result.Message });

            #region Send Emails

            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == requestReviewerWriteDto.RequestId);
            var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "VehicleRequest", "Creator" });
            var requestCreator = request.Creator;
            if (request?.Status == RequestStatus.Approved.ToString())
            {
                var creatorMailContent = new MailContent
                {
                    Body = $"""
                Dear {requestCreator.FullName.Split(" ")[0]},
                    Kindly not that your Vehicle Request {request.VehicleRequest.RequestNumber} on eDocuement has been approved successfully.
                    For more detail, please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}).

                    - eDocument Request Reference No.: {request.VehicleRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                    IsHTMLBody = false,
                    Subject = $"Vehicle Request No. {request.VehicleRequest.RequestNumber} on eDocuement",
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
                        Kindly note that {requestCreator.FullName} has created Vehicle Request for on eDocuement and need to be reviewed from your side.

                        Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                        - eDocument Request Reference No.: {request.VehicleRequest.RequestNumber}

                    Thanks,

                    “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                    """,
                    IsHTMLBody = false,
                    Subject = $"Vehicle Request No. {request.VehicleRequest.RequestNumber} on eDocuement",
                    To = reviewersEmails
                };

                _mailService.SendMailAsync(reviewerMailContent);
            }

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Your action has been recorded successfully" });
        }

        /// <summary>
        /// Decline Vehicle Request
        /// </summary>
        /// <param name="requestReviewerWriteDto">Decline Vehicle Request</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("Vehicle/Decline")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> DeclineVehicleRequest(DeclineRequestReviewerDto requestReviewerWriteDto)
        {
            _logger.LogInformation($"Start DeclineVehicleRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(requestReviewerWriteDto)} ");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var result = await _requestReviewerRepository.DeclineRequestAsync(requestReviewerWriteDto, user);

            if (!result.IsSucceded)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = result.Message });

            #region Send Emails

            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == requestReviewerWriteDto.RequestId);
            var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "VehicleRequest", "Creator" });

            var requestCreator = request.Creator;
            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {requestCreator.FullName.Split(" ")[0]},
                    Kindly not that your Vehicle Request No. {request.VehicleRequest.RequestNumber} on eDocuement has been declined by {user.FullName}.
                    For more detail, please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}).

                    - eDocument Request Reference No.: {request.VehicleRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"Vehicle Request No. {request.VehicleRequest.RequestNumber} on eDocuement",
                To = requestCreator.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Your action has been recorded successfully" });
        }

        #endregion Vehicle Request

        #region TravelDesk Request

        /// <summary>
        /// Get TravelDesk Requests By for Edit Id
        /// </summary>
        /// <param name="id">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>TravelDesk Request</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<TravelDeskRequestEditReadDto>))]
        [HttpGet("TravelDesk/{id}")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> GetTravelDeskRequestById(long id)
        {
            _logger.LogInformation($"Start GetTravelDeskRequestById from {nameof(RequestController)} for request id = {id}");

            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            var travelDeskRequest = await _unitOfWork.Repository<TravelDeskRequest>().FindRequestAsync(
            requestId: id,
            expression: "Request.Id==@0",
            includes: includes
            );

            if (travelDeskRequest is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Request not found" });

            var result = _mapper.Map<TravelDeskRequestEditReadDto>(travelDeskRequest);

            return Ok(new ApiResponse<TravelDeskRequestEditReadDto> { StatusCode = (int)HttpStatusCode.OK, Details = result });
        }

        /// <summary>
        /// Delete TravelDesk Requests By Id
        /// </summary>
        /// <param name="id">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpDelete("TravelDesk/{id}")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> DeleteTravelDeskRequest(long id)
        {
            _logger.LogInformation($"Start DeleteTravelDeskRequest from {nameof(RequestController)} for request id = {id}");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var includes = new string[] { "TravelDeskRequest", "Attachments", "RequestReviewers" };

            var request = await _unitOfWork.Repository<Models.Request>().FindRequestAsync(
            requestId: id,
            expression: "Id==@0",
            includes: includes
                );

            if (request is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Request not found" });

            if (request.Status == RequestStatus.Approved.ToString() || request.Status == RequestStatus.Declined.ToString())
            {
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = $"You cannot delete this request after as it has been already {request.Status}" });
            }
            else if (request.RequestReviewers.Any(rr => rr.Status == RequestStatus.Approved.ToString()))
            {
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "You cannot delete the request after one of the reviewers took his action" });
            }

            request.TravelDeskRequest.ModifiedBy = user?.FullName;
            request.ModifiedBy = user?.FullName;
            _unitOfWork.Complete();

            _unitOfWork.Repository<Models.Request>().Delete(request);
            _unitOfWork.Complete();

            _fileService.DeleteFolder($@"TravelDeskRequest\{id}");

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = "Request deleted successfully" });
        }

        /// <summary>
        /// Get All TravelDesk Requests By Creator With Filter
        /// </summary>
        /// <param name="filterDto">filter information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of All Created TravelDesk Requests</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FilterReadDto<TravelDeskRequestDetailsReadDto>>))]
        [HttpPost("TravelDesk/Inbox")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> GetCreatorTravelDeskRequestsFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetCreatorTravelDeskRequestsFiltered from {nameof(RequestController)} with filter: {JsonSerializer.Serialize(filterDto)}");
            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            string? userCondition = null;

            (int TotalCount, IEnumerable<TravelDeskRequest> PaginatedData) result;

            userCondition = "Request.CreatorId ==@0";

            if (!string.IsNullOrEmpty(filterDto?.FilterValue))
            {
                result = await _unitOfWork.Repository<TravelDeskRequest>().FindAllRequestsAsync(
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
                result = await _unitOfWork.Repository<TravelDeskRequest>().FindAllRequestsAsync(
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

            var requests = _mapper.Map<List<TravelDeskRequestDetailsReadDto>>(result.PaginatedData);

            var response = new FilterReadDto<TravelDeskRequestDetailsReadDto>
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = filterDto?.PageNo ?? 1,
                PageSize = requests.Count,
                PaginatedData = requests
            };
            return Ok(new ApiResponse<FilterReadDto<TravelDeskRequestDetailsReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = response });
        }

        /// <summary>
        /// Get All TravelDesk Requests By Reviewer With Filter
        /// </summary>
        /// <param name="filterDto">filter information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of All Reviewer TravelDesk Requests</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FilterReadDto<TravelDeskRequestReviewerReadDto>>))]
        [HttpPost("TravelDesk/AssignedToMe")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> GetReviewerTravelDeskRequestsFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetReviewerTravelDeskRequestsFiltered from {nameof(RequestController)} with filter: {JsonSerializer.Serialize(filterDto)}");
            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            string? userCondition = null;

            (int TotalCount, IEnumerable<TravelDeskRequest> PaginatedData) result;

            userCondition = "Request.RequestReviewers.Any(AssignedReviewerId == @0 && Request.CurrentStage >= StageNumber)";

            if (!string.IsNullOrEmpty(filterDto?.FilterValue))
            {
                result = await _unitOfWork.Repository<TravelDeskRequest>().FindAllRequestsAsync(
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
                result = await _unitOfWork.Repository<TravelDeskRequest>().FindAllRequestsAsync(
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

            var requests = _mapper.Map<List<TravelDeskRequestReviewerReadDto>>(result.PaginatedData);

            foreach (var request in requests)
            {
                var reviewer = request.RequestReviewers?.OrderBy(r => r.StageNumber).LastOrDefault(y => y.AssignedReviewerId == User.FindFirstValue(ClaimTypes.NameIdentifier) && y.Status != RequestStatus.None);

                request.ReviewerStatus = reviewer?.Status;
                request.ReviewerStage = reviewer?.StageNumber;
            }

            var response = new FilterReadDto<TravelDeskRequestReviewerReadDto>
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = filterDto?.PageNo ?? 1,
                PageSize = requests.Count,
                PaginatedData = requests
            };
            return Ok(new ApiResponse<FilterReadDto<TravelDeskRequestReviewerReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = response });
        }

        /// <summary>
        /// Create TravelDesk Request
        /// </summary>
        /// <param name="travelDeskRequestCreateDto">TravelDesk request Informarion</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [Consumes("multipart/form-data")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPost("TravelDesk/Create")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> CreateTravelDeskRequest([FromForm] TravelDeskRequestCreateDto travelDeskRequestCreateDto)
        {
            _logger.LogInformation($"Start CreateTravelDeskRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(travelDeskRequestCreateDto)} ");

            var beneficiaryUser = await _userManager.Users.Include(t => t.Department).FirstOrDefaultAsync(u => u.Id == travelDeskRequestCreateDto.BeneficiaryId);

            if (beneficiaryUser is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"Beneficiary user '{travelDeskRequestCreateDto.BeneficiaryId}' not found" });

            if (beneficiaryUser.Company != "DP World")
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = $"Beneficiary user '{travelDeskRequestCreateDto.BeneficiaryId}' is not DP WORLD Employee" });

            var requestId = long.Parse(DateTime.Now.ToString("yyyyMMddhhmmssff"));

            var requestNo = $"Travel-{DateTime.Now.ToString("yyyyMMddhhmmss")}";
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var request = new Models.Request { Id = requestId, DefinedRequestId = travelDeskRequestCreateDto.DefinedRequestId };
            request.Notes = travelDeskRequestCreateDto.Justification;
            request.TravelDeskRequest = _mapper.Map<TravelDeskRequest>(travelDeskRequestCreateDto);
            _mapper.Map(beneficiaryUser, request.TravelDeskRequest);
            request.TravelDeskRequest.RequestNumber = requestNo;

            if (travelDeskRequestCreateDto.Attachments != null && travelDeskRequestCreateDto.Attachments.Count > 0)
            {
                request.Attachments = _fileService.UploadAttachments(requestId, $@"TravelDeskRequest\{requestId}", travelDeskRequestCreateDto.Attachments, user.FullName);
            }

            request.CreatorId = user?.Id;
            request.TravelDeskRequest.CreatedBy = user?.FullName;
            request.CreatedBy = user?.FullName;
            request.TravelDeskRequest.CreatedBy = user?.FullName;

            _unitOfWork.Repository<Models.Request>().Add(request);

            var result = _unitOfWork.Complete();

            await _requestReviewerRepository.BeginRequestCycle(travelDeskRequestCreateDto.DefinedRequestId, requestId, beneficiaryUser.Id, true);

            if (result < 1)
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "Adding new request has been failed" });

            #region Send Emails

            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {user.FullName.Split(" ")[0]},
                    Kindly not that your TravelDesk Request on eDocuement has been created successfully and it's under reviewing now.
                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with your request Status.

                    - eDocument Request Reference No.: {requestNo}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"TravelDesk Request No. {requestNo} on eDocuement",
                To = user.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            var reviewersEmails = await _requestReviewerRepository.GetAllRequestReviewersEmailsByStageNumberAsync(requestId, request.CurrentStage);
            var reviewerMailContent = new MailContent
            {
                Body = $"""
                Dears,
                    Kindly note that {user.FullName} has created TravelDesk Request for on eDocuement and need to be reviewed from your side.

                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                    - eDocument Request Reference No.: {requestNo}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                """,
                IsHTMLBody = false,
                Subject = $"TravelDesk Request No. {requestNo} on eDocuement",
                To = reviewersEmails
            };

            _mailService.SendMailAsync(reviewerMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Request has been created successfully - Request No. {requestNo}" });
        }

        /// <summary>
        /// Update TravelDesk Request
        /// </summary>
        /// <param name="id">Travel Desk request Id</param>
        /// <param name="travelDeskRequestUpdateDto">TravelDesk request Informarion</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [Consumes("multipart/form-data")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("TravelDesk/Update/{id}")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> UpdateTravelDeskRequest(long id, [FromForm] TravelDeskRequestUpdateDto travelDeskRequestUpdateDto)
        {
            _logger.LogInformation($"Start UpdateTravelDeskRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(travelDeskRequestUpdateDto)} ");

            var beneficiaryUser = await _userManager.Users.Include(t => t.Department).FirstOrDefaultAsync(u => u.Id == travelDeskRequestUpdateDto.BeneficiaryId);

            if (beneficiaryUser is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"Beneficiary user '{travelDeskRequestUpdateDto.BeneficiaryId}' not found" });

            if (beneficiaryUser.Company != "DP World")
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = $"Beneficiary user '{travelDeskRequestUpdateDto.BeneficiaryId}' is not DP WORLD Employee" });

            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            Expression<Func<Models.Request, bool>> requestRxpression = (r => r.Id == id);

            var request = await _unitOfWork.Repository<Models.Request>().FindAsync(requestRxpression, new string[] { "TravelDeskRequest", "Attachments" });

            if (request == null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"Request not found" });

            var oldAttachments = request.Attachments;
            request.Notes = travelDeskRequestUpdateDto.Justification;
            _mapper.Map(travelDeskRequestUpdateDto, request);
            _mapper.Map(travelDeskRequestUpdateDto, request.TravelDeskRequest);
            _mapper.Map(beneficiaryUser, request.TravelDeskRequest);

            if (travelDeskRequestUpdateDto.Attachments == null || travelDeskRequestUpdateDto.Attachments.Count == 0)
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

                request.Attachments = _fileService.UploadAttachments(request.Id, $@"TravelDeskRequest\{request.Id}", travelDeskRequestUpdateDto.Attachments, createdBy: request.PoRequest.CreatedBy, modifiedBy: user.FullName, modifiedAt: DateTime.Now);
            }

            request.TravelDeskRequest.ModifiedAt = DateTime.Now;
            request.TravelDeskRequest.ModifiedBy = user?.FullName;
            request.ModifiedBy = user?.FullName;

            var result = _unitOfWork.Complete();

            await _requestReviewerRepository.BeginRequestCycle(request.DefinedRequestId, request.Id, beneficiaryUser.Id, false);

            if (result < 1)
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "Request update has been failed" });

            #region Send Emails

            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {user.FullName.Split(" ")[0]},
                    Kindly not that your TravelDesk Request on eDocuement has been updated successfully and it's under reviewing now.
                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with your request Status.

                    - eDocument Request Reference No.: {request.TravelDeskRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"TravelDesk Request No. {request.TravelDeskRequest.RequestNumber} on eDocuement",
                To = user.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            var reviewersEmails = await _requestReviewerRepository.GetAllRequestReviewersEmailsByStageNumberAsync(request.Id, request.CurrentStage);
            var reviewerMailContent = new MailContent
            {
                Body = $"""
                Dears,
                    Kindly note that {user.FullName} has updated TravelDesk Request for on eDocuement and need to be reviewed from your side.

                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                    - eDocument Request Reference No.: {request.TravelDeskRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                """,
                IsHTMLBody = false,
                Subject = $"TravelDesk Request No. {request.TravelDeskRequest.RequestNumber} on eDocuement",
                To = reviewersEmails
            };

            _mailService.SendMailAsync(reviewerMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Request has been updated successfully" });
        }

        /// <summary>
        /// Approve TravelDesk Request
        /// </summary>
        /// <param name="requestReviewerWriteDto">Approve TravelDesk Request</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("TravelDesk/Approve")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> ApproveTravelDeskRequest(ApproveRequestReviewerDto requestReviewerWriteDto)
        {
            _logger.LogInformation($"Start ApproveTravelDeskRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(requestReviewerWriteDto)} ");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var result = await _requestReviewerRepository.ApproveRequestAsync(requestReviewerWriteDto, user);

            if (!result.IsSucceded)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = result.Message });

            #region Send Emails

            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == requestReviewerWriteDto.RequestId);
            var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "TravelDeskRequest", "Creator", "Creator.Department", "Creator.Department.Manager" });
            var requestCreator = request.Creator;
            if (request?.Status == RequestStatus.Approved.ToString())
            {
                var requestCreatorDirectManager = request.Creator.Manager;
                var requestCreatorDepartmentManager = request.Creator.Department.Manager;
                var creatorMailContent = new MailContent
                {
                    Body = $"""
                Dear {requestCreator.FullName.Split(" ")[0]},
                    Kindly not that your TravelDesk Request {request.TravelDeskRequest.RequestNumber} on eDocuement has been approved successfully.
                    For more detail, please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}).

                    - eDocument Request Reference No.: {request.TravelDeskRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                    IsHTMLBody = false,
                    Subject = $"TravelDesk Request No. {request.TravelDeskRequest.RequestNumber} on eDocuement",
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
                        Kindly note that {requestCreator.FullName} has created TravelDesk Request for on eDocuement and need to be reviewed from your side.

                        Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                        - eDocument Request Reference No.: {request.TravelDeskRequest.RequestNumber}

                    Thanks,

                    “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                    """,
                    IsHTMLBody = false,
                    Subject = $"TravelDesk Request No. {request.TravelDeskRequest.RequestNumber} on eDocuement",
                    To = reviewersEmails
                };

                _mailService.SendMailAsync(reviewerMailContent);
            }

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Your action has been recorded successfully" });
        }

        /// <summary>
        /// Decline TravelDesk Request
        /// </summary>
        /// <param name="requestReviewerWriteDto">Decline TravelDesk Request</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("TravelDesk/Decline")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> DeclineTravelDeskRequest(DeclineRequestReviewerDto requestReviewerWriteDto)
        {
            _logger.LogInformation($"Start DeclineTravelDeskRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(requestReviewerWriteDto)} ");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var result = await _requestReviewerRepository.DeclineRequestAsync(requestReviewerWriteDto, user);
            if (!result.IsSucceded)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = result.Message });

            #region Send Emails

            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == requestReviewerWriteDto.RequestId);
            var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "TravelDeskRequest", "Creator" });

            var requestCreator = request.Creator;
            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {requestCreator.FullName.Split(" ")[0]},
                    Kindly not that your TravelDesk Request No. {request.TravelDeskRequest.RequestNumber} on eDocuement has been declined by {user.FullName}.
                    For more detail, please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}).

                    - eDocument Request Reference No.: {request.TravelDeskRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"TravelDesk Request No. {request.TravelDeskRequest.RequestNumber} on eDocuement",
                To = requestCreator.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Your action has been recorded successfully" });
        }

        #endregion TravelDesk Request

        #endregion Administration

        #region Customer Service

        #region Refund Request

        /// <summary>
        /// Get Refund Requests By for Edit Id
        /// </summary>
        /// <param name="id">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>Refund Request</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<RefundRequestReadDto>))]
        [HttpGet("Refund/{id}")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> GetRefundRequestById(long id)
        {
            _logger.LogInformation($"Start GetRefundRequestById from {nameof(RequestController)} for request id = {id}");

            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            var refundRequest = await _unitOfWork.Repository<RefundRequest>().FindRequestAsync(
            requestId: id,
            expression: "Request.Id==@0",
            includes: includes
            );

            if (refundRequest is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Request not found" });

            var result = _mapper.Map<RefundRequestReadDto>(refundRequest);

            return Ok(new ApiResponse<RefundRequestReadDto> { StatusCode = (int)HttpStatusCode.OK, Details = result });
        }

        /// <summary>
        /// Delete Refund Requests By Id
        /// </summary>
        /// <param name="id">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpDelete("Refund/{id}")]
        [Authorize(Roles = "CustomerService")]
        public async Task<ActionResult> DeleteRefundRequest(long id)
        {
            _logger.LogInformation($"Start DeleteRefundRequest from {nameof(RequestController)} for request id = {id}");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var includes = new string[] { "RefundRequest", "Attachments", "RequestReviewers" };

            var request = await _unitOfWork.Repository<Models.Request>().FindRequestAsync(
            requestId: id,
            expression: "Id==@0",
            includes: includes
                );

            if (request is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Request not found" });

            if (request.Status == RequestStatus.Approved.ToString() || request.Status == RequestStatus.Declined.ToString())
            {
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = $"You cannot delete this request after as it has been already {request.Status}" });
            }
            else if (request.RequestReviewers.Any(rr => rr.Status == RequestStatus.Approved.ToString()))
            {
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "You cannot delete the request after one of the reviewers took his action" });
            }

            request.RefundRequest.ModifiedBy = user?.FullName;
            request.ModifiedBy = user?.FullName;
            _unitOfWork.Complete();

            _unitOfWork.Repository<Models.Request>().Delete(request);
            _unitOfWork.Complete();

            _fileService.DeleteFolder($@"RefundRequest\{id}");

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = "Request deleted successfully" });
        }

        /// <summary>
        /// Get All Refund Requests By Creator With Filter
        /// </summary>
        /// <param name="filterDto">filter information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of All Created Refund Requests</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FilterReadDto<RefundRequestReadDto>>))]
        [HttpPost("Refund/Inbox")]
        [Authorize(Roles = "CustomerService")]
        public async Task<ActionResult> GetCreatorRefundRequestsFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetCreatorRefundRequestsFiltered from {nameof(RequestController)} with filter: {JsonSerializer.Serialize(filterDto)}");
            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };

            (int TotalCount, IEnumerable<RefundRequest> PaginatedData) result;

            if (!string.IsNullOrEmpty(filterDto?.FilterValue))
            {
                result = await _unitOfWork.Repository<RefundRequest>().FindAllRequestsAsync(
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
                result = await _unitOfWork.Repository<RefundRequest>().FindAllRequestsAsync(
                isCreator: true,
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

            var requests = _mapper.Map<List<RefundRequestReadDto>>(result.PaginatedData);

            var response = new FilterReadDto<RefundRequestReadDto>
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = filterDto?.PageNo ?? 1,
                PageSize = requests.Count,
                PaginatedData = requests
            };
            return Ok(new ApiResponse<FilterReadDto<RefundRequestReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = response });
        }

        /// <summary>
        /// Get All Refund Requests By Reviewer With Filter
        /// </summary>
        /// <param name="filterDto">filter information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of All Reviewer Refund Requests</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FilterReadDto<RefundRequestReviewerReadDto>>))]
        [HttpPost("Refund/AssignedToMe")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> GetReviewerRefundRequestsFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetReviewerRefundRequestsFiltered from {nameof(RequestController)} with filter: {JsonSerializer.Serialize(filterDto)}");
            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            string? userCondition = null;

            (int TotalCount, IEnumerable<RefundRequest> PaginatedData) result;

            userCondition = "Request.RequestReviewers.Any(AssignedReviewerId == @0 && Request.CurrentStage >= StageNumber)";

            if (!string.IsNullOrEmpty(filterDto?.FilterValue))
            {
                result = await _unitOfWork.Repository<RefundRequest>().FindAllRequestsAsync(
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
                result = await _unitOfWork.Repository<RefundRequest>().FindAllRequestsAsync(
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

            var requests = _mapper.Map<List<RefundRequestReviewerReadDto>>(result.PaginatedData);

            foreach (var request in requests)
            {
                var reviewer = request.RequestReviewers?.OrderBy(r => r.StageNumber).LastOrDefault(y => y.AssignedReviewerId == User.FindFirstValue(ClaimTypes.NameIdentifier) && y.Status != RequestStatus.None);

                request.ReviewerStatus = reviewer?.Status;
                request.ReviewerStage = reviewer?.StageNumber;
            }

            var response = new FilterReadDto<RefundRequestReviewerReadDto>
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = filterDto?.PageNo ?? 1,
                PageSize = requests.Count,
                PaginatedData = requests
            };
            return Ok(new ApiResponse<FilterReadDto<RefundRequestReviewerReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = response });
        }

        /// <summary>
        /// Create Refund Request
        /// </summary>
        /// <param name="refundRequestCreateDto">Refund request Informarion</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [Consumes("multipart/form-data")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPost("Refund/Create")]
        [Authorize(Roles = "CustomerService")]
        public async Task<ActionResult> CreateRefundRequest([FromForm] RefundRequestCreateDto refundRequestCreateDto)
        {
            _logger.LogInformation($"Start CreateRefundRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(refundRequestCreateDto)} ");

            var requestId = long.Parse(DateTime.Now.ToString("yyyyMMddhhmmssff"));

            var requestNo = $"Refund-{DateTime.Now.ToString("yyyyMMddhhmmss")}";
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var request = new Models.Request { Id = requestId, DefinedRequestId = refundRequestCreateDto.DefinedRequestId };
            request.Notes = refundRequestCreateDto.Notes;
            request.RefundRequest = _mapper.Map<RefundRequest>(refundRequestCreateDto);
            request.RefundRequest.RequestNumber = requestNo;

            if (refundRequestCreateDto.Attachments != null && refundRequestCreateDto.Attachments.Count > 0)
            {
                request.Attachments = _fileService.UploadAttachments(requestId, $@"RefundRequest\{requestId}", refundRequestCreateDto.Attachments, user.FullName);
            }

            request.CreatorId = user?.Id;
            request.RefundRequest.CreatedBy = user?.FullName;
            request.CreatedBy = user?.FullName;
            request.RefundRequest.CreatedBy = user?.FullName;

            _unitOfWork.Repository<Models.Request>().Add(request);

            var result = _unitOfWork.Complete();

            await _requestReviewerRepository.BeginRequestCycle(refundRequestCreateDto.DefinedRequestId, requestId, user.Id, true);

            await _requestReviewerRepository.NominateReviewer(requestId, refundRequestCreateDto.ConcernedEmployeeId, user?.FullName);

            if (result < 1)
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "Adding new request has been failed" });

            #region Send Emails

            //var creatorMailContent = new MailContent
            //{
            //    Body = $"""
            //    Dear {user.FullName.Split(" ")[0]},
            //        Kindly not that your Refund Request on eDocuement has been created successfully and it's under reviewing now.
            //        Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with your request Status.

            //        - eDocument Request Reference No.: {requestNo}

            //    Thanks,

            //    “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

            //    """,
            //    IsHTMLBody = false,
            //    Subject = $"Refund Request No. {requestNo} on eDocuement",
            //
            //    To = $"{user.Email};DPWSokhna.CustomerService@dpworld.com;"
            //};

            //_mailService.SendMailAsync(creatorMailContent);

            //var reviewersEmails = await _requestReviewerRepository.GetAllRequestReviewersEmailsByStageNumberAsync(requestId,request.CurrentStage);
            //var reviewerMailContent =  new MailContent
            //{
            //    Body = $"""
            //    Dears,
            //        Kindly note that {user.FullName} has created Refund Request for on eDocuement and need to be reviewed from your side.

            //        Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

            //        - eDocument Request Reference No.: {requestNo}

            //    Thanks,

            //    “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
            //    """,
            //    IsHTMLBody = false,
            //    Subject = $"Refund Request No. {requestNo} on eDocuement",
            //    To = reviewersEmails
            //};

            //_mailService.SendMailAsync(reviewerMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Request has been created successfully - Request No. {requestNo}" });
        }

        /// <summary>
        /// Update Refund Request
        /// </summary>
        /// <param name="id">Refund request Id</param>
        /// <param name="refundRequestUpdateDto">Refund request Informarion</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [Consumes("multipart/form-data")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("Refund/Update/{id}")]
        [Authorize(Roles = "CustomerService")]
        public async Task<ActionResult> UpdateRefundRequest(long id, [FromForm] RefundRequestUpdateDto refundRequestUpdateDto)
        {
            _logger.LogInformation($"Start UpdateRefundRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(refundRequestUpdateDto)} ");

            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            Expression<Func<Models.Request, bool>> requestRxpression = (r => r.Id == id);

            var request = await _unitOfWork.Repository<Models.Request>().FindAsync(requestRxpression, new string[] { "RefundRequest", "Attachments" });

            if (request == null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"Request not found" });

            var oldAttachments = request.Attachments;
            request.Notes = refundRequestUpdateDto.Notes;
            _mapper.Map(refundRequestUpdateDto, request);
            _mapper.Map(refundRequestUpdateDto, request.RefundRequest);

            if (refundRequestUpdateDto.Attachments == null || refundRequestUpdateDto.Attachments.Count == 0)
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

                request.Attachments = _fileService.UploadAttachments(request.Id, $@"RefundRequest\{request.Id}", refundRequestUpdateDto.Attachments, createdBy: request.PoRequest.CreatedBy, modifiedBy: user.FullName, modifiedAt: DateTime.Now);
            }

            request.RefundRequest.ModifiedAt = DateTime.Now;
            request.RefundRequest.ModifiedBy = user?.FullName;
            request.ModifiedBy = user?.FullName;

            var result = _unitOfWork.Complete();
            await _requestReviewerRepository.BeginRequestCycle(request.DefinedRequestId, request.Id, user.Id, false);
            await _requestReviewerRepository.NominateReviewer(request.Id, refundRequestUpdateDto.ConcernedEmployeeId, user?.FullName);

            if (result < 1)
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "Request update has been failed" });

            #region Send Emails

            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {user.FullName.Split(" ")[0]},
                    Kindly not that your Refund Request on eDocuement has been updated successfully and it's under reviewing now.
                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with your request Status.

                    - eDocument Request Reference No.: {request.RefundRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"Refund Request No. {request.RefundRequest.RequestNumber} on eDocuement",
                To = $"{user.Email};DPWSokhna.CustomerService@dpworld.com;"
            };

            _mailService.SendMailAsync(creatorMailContent);

            var reviewersEmails = await _requestReviewerRepository.GetAllRequestReviewersEmailsByStageNumberAsync(id, request.CurrentStage);
            var reviewerMailContent = new MailContent
            {
                Body = $"""
                Dears,
                    Kindly note that {user.FullName} has updated Refund Request for on eDocuement and need to be reviewed from your side.

                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                    - eDocument Request Reference No.: {request.RefundRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                """,
                IsHTMLBody = false,
                Subject = $"Refund Request No. {request.RefundRequest.RequestNumber} on eDocuement",
                To = reviewersEmails
            };

            _mailService.SendMailAsync(reviewerMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Request has been updated successfully" });
        }

        /// <summary>
        /// Approve Refund Request
        /// </summary>
        /// <param name="approveRefundRequestDto">Approve Refund Request</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("Refund/Approve")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> ApproveRefundRequest(ApproveRefundRequestDto approveRefundRequestDto)
        {
            _logger.LogInformation($"Start ApproveRefundRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(approveRefundRequestDto)} ");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == approveRefundRequestDto.RequestId);
            var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "RefundRequest", "Creator", "Creator.Department", "Creator.Department.Manager" });

            if (request != null && request?.CurrentStage == 2)
            {
                request.RefundRequest.CreditNote = approveRefundRequestDto.CreditNote;
                request.RefundRequest.Amount = approveRefundRequestDto.Amount;

                request.ModifiedBy = user?.FullName;
                request.RefundRequest.ModifiedBy = user?.FullName;
            }
            var result = await _requestReviewerRepository.ApproveRequestAsync(_mapper.Map<ApproveRequestReviewerDto>(approveRefundRequestDto), user);
            if (!result.IsSucceded)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = result.Message });

            #region Send Emails

            var requestCreator = request.Creator;
            var requestCreatorDepartmentManager = request.Creator.Department.Manager;
            //if (request?.Status==RequestStatus.Approved.ToString())
            //{
            //
            //
            //    var creatorMailContent = new MailContent
            //    {
            //        Body = $"""
            //    Dear {requestCreator.FullName.Split(" ")[0]},
            //        Kindly not that your Refund Request {request.RefundRequest.RequestNumber} on eDocuement has been approved successfully.
            //        For more detail, please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}).

            //        - eDocument Request Reference No.: {request.RefundRequest.RequestNumber}

            //    Thanks,

            //    “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

            //    """,
            //        IsHTMLBody = false,
            //        Subject = $"Refund Request No. {request.RefundRequest.RequestNumber} on eDocuement",
            //        Cc = requestCreatorDepartmentManager.Email,
            //        To = $"{requestCreator.Email};DPWSokhna.CustomerService@dpworld.com;"
            //    };

            //    _mailService.SendMailAsync(creatorMailContent);
            //}
            //else
            //{
            //    var reviewersEmails = await _requestReviewerRepository.GetAllRequestReviewersEmailsByStageNumberAsync(requestReviewerWriteDto.RequestId, request.CurrentStage);
            //    var reviewerMailContent = new MailContent
            //    {
            //        Body = $"""
            //        Dears,
            //            Kindly note that {requestCreator.FullName} has created Refund Request for on eDocuement and need to be reviewed from your side.

            //            Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

            //            - eDocument Request Reference No.: {request.RefundRequest.RequestNumber}

            //        Thanks,

            //        “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
            //        """,
            //        IsHTMLBody = false,
            //        Subject = $"Refund Request No. {request.RefundRequest.RequestNumber} on eDocuement",
            //        To = reviewersEmails
            //    };

            //    _mailService.SendMailAsync(reviewerMailContent);
            //}

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Your action has been recorded successfully" });
        }

        /// <summary>
        /// Decline Refund Request
        /// </summary>
        /// <param name="requestReviewerWriteDto">Decline Refund Request</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("Refund/Decline")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> DeclineRefundRequest(DeclineRequestReviewerDto requestReviewerWriteDto)
        {
            _logger.LogInformation($"Start DeclineRefundRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(requestReviewerWriteDto)} ");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var result = await _requestReviewerRepository.DeclineRequestAsync(requestReviewerWriteDto, user);
            if (!result.IsSucceded)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = result.Message });

            #region Send Emails

            //Expression<Func<Request, bool>> requestRxpression = (r => r.Id == requestReviewerWriteDto.RequestId);
            //var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "RefundRequest", "Creator", "Creator.Department", "Creator.Department.Manager" });

            //var requestCreator = request.Creator;
            //var requestCreatorDepartmentManager = request.Creator.Department.Manager;
            //var creatorMailContent = new MailContent
            //{
            //    Body = $"""
            //    Dear {requestCreator.FullName.Split(" ")[0]},
            //        Kindly not that your Refund Request No. {request.RefundRequest.RequestNumber} on eDocuement has been declined by {user.FullName}.
            //        For more detail, please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}).

            //        - eDocument Request Reference No.: {request.RefundRequest.RequestNumber}

            //    Thanks,

            //    “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

            //    """,
            //    IsHTMLBody = false,
            //    Subject = $"Refund Request No. {request.RefundRequest.RequestNumber} on eDocuement",
            //    Cc = requestCreatorDepartmentManager.Email,
            //    To = $"{requestCreator.Email};DPWSokhna.CustomerService@dpworld.com;"
            //};

            //_mailService.SendMailAsync(creatorMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Your action has been recorded successfully" });
        }

        #endregion Refund Request

        #endregion Customer Service

        #region Commercial

        #region Discount Request

        /// <summary>
        /// Get Discount Requests By for Edit Id
        /// </summary>
        /// <param name="id">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>Discount Request</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<DiscountRequestReadDto>))]
        [HttpGet("Discount/{id}")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> GetDiscountRequestById(long id)
        {
            _logger.LogInformation($"Start GetDiscountRequestById from {nameof(RequestController)} for request id = {id}");

            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            var discountRequest = await _unitOfWork.Repository<DiscountRequest>().FindRequestAsync(
            requestId: id,
            expression: "Request.Id==@0",
            includes: includes
            );

            if (discountRequest is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Request not found" });

            var result = _mapper.Map<DiscountRequestReadDto>(discountRequest);

            return Ok(new ApiResponse<DiscountRequestReadDto> { StatusCode = (int)HttpStatusCode.OK, Details = result });
        }

        /// <summary>
        /// Delete Discount Requests By Id
        /// </summary>
        /// <param name="id">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpDelete("Discount/{id}")]
        [Authorize(Roles = "CustomerService,Commercial")]
        public async Task<ActionResult> DeleteDiscountRequest(long id)
        {
            _logger.LogInformation($"Start DeleteDiscountRequest from {nameof(RequestController)} for request id = {id}");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var includes = new string[] { "DiscountRequest", "Attachments", "RequestReviewers" };

            var request = await _unitOfWork.Repository<Models.Request>().FindRequestAsync(
            requestId: id,
            expression: "Id==@0",
            includes: includes
                );

            if (request is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Request not found" });

            if (request.Status == RequestStatus.Approved.ToString() || request.Status == RequestStatus.Declined.ToString())
            {
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = $"You cannot delete this request after as it has been already {request.Status}" });
            }
            else if (request.RequestReviewers.Any(rr => rr.Status == RequestStatus.Approved.ToString()))
            {
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "You cannot delete the request after one of the reviewers took his action" });
            }

            request.DiscountRequest.ModifiedBy = user?.FullName;
            request.ModifiedBy = user?.FullName;
            _unitOfWork.Complete();

            _unitOfWork.Repository<Models.Request>().Delete(request);
            _unitOfWork.Complete();

            _fileService.DeleteFolder($@"DiscountRequest\{id}");

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = "Request deleted successfully" });
        }

        /// <summary>
        /// Get All Discount Requests By Creator With Filter
        /// </summary>
        /// <param name="filterDto">filter information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of All Created Discount Requests</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FilterReadDto<DiscountRequestReadDto>>))]
        [HttpPost("Discount/Inbox")]
        [Authorize(Roles = "CustomerService,Commercial")]
        public async Task<ActionResult> GetCreatorDiscountRequestsFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetCreatorDiscountRequestsFiltered from {nameof(RequestController)} with filter: {JsonSerializer.Serialize(filterDto)}");
            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };

            (int TotalCount, IEnumerable<DiscountRequest> PaginatedData) result;

            if (!string.IsNullOrEmpty(filterDto?.FilterValue))
            {
                result = await _unitOfWork.Repository<DiscountRequest>().FindAllRequestsAsync(
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
                result = await _unitOfWork.Repository<DiscountRequest>().FindAllRequestsAsync(
                isCreator: true,
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

            var requests = _mapper.Map<List<DiscountRequestReadDto>>(result.PaginatedData);

            var response = new FilterReadDto<DiscountRequestReadDto>
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = filterDto?.PageNo ?? 1,
                PageSize = requests.Count,
                PaginatedData = requests
            };
            return Ok(new ApiResponse<FilterReadDto<DiscountRequestReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = response });
        }

        /// <summary>
        /// Get All Discount Requests By Reviewer With Filter
        /// </summary>
        /// <param name="filterDto">filter information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of All Reviewer Discount Requests</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FilterReadDto<DiscountRequestReviewerReadDto>>))]
        [HttpPost("Discount/AssignedToMe")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> GetReviewerDiscountRequestsFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetReviewerDiscountRequestsFiltered from {nameof(RequestController)} with filter: {JsonSerializer.Serialize(filterDto)}");
            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            string? userCondition = null;

            (int TotalCount, IEnumerable<DiscountRequest> PaginatedData) result;

            userCondition = "Request.RequestReviewers.Any(AssignedReviewerId == @0 && Request.CurrentStage >= StageNumber)";

            if (!string.IsNullOrEmpty(filterDto?.FilterValue))
            {
                result = await _unitOfWork.Repository<DiscountRequest>().FindAllRequestsAsync(
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
                result = await _unitOfWork.Repository<DiscountRequest>().FindAllRequestsAsync(
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

            var requests = _mapper.Map<List<DiscountRequestReviewerReadDto>>(result.PaginatedData);

            foreach (var request in requests)
            {
                var reviewer = request.RequestReviewers?.OrderBy(r => r.StageNumber).LastOrDefault(y => y.AssignedReviewerId == User.FindFirstValue(ClaimTypes.NameIdentifier) && y.Status != RequestStatus.None);

                request.ReviewerStatus = reviewer?.Status;
                request.ReviewerStage = reviewer?.StageNumber;
            }

            var response = new FilterReadDto<DiscountRequestReviewerReadDto>
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = filterDto?.PageNo ?? 1,
                PageSize = requests.Count,
                PaginatedData = requests
            };
            return Ok(new ApiResponse<FilterReadDto<DiscountRequestReviewerReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = response });
        }

        /// <summary>
        /// Create Discount Request
        /// </summary>
        /// <param name="discountRequestCreateDto">Discount request Informarion</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [Consumes("multipart/form-data")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPost("Discount/Create")]
        [Authorize(Roles = "CustomerService,Commercial")]
        public async Task<ActionResult> CreateDiscountRequest([FromForm] DiscountRequestCreateDto discountRequestCreateDto)
        {
            _logger.LogInformation($"Start CreateDiscountRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(discountRequestCreateDto)} ");

            Expression<Func<DiscountRequest, bool>> documenteNumberCriteria = (r => r.DocumentNumber == discountRequestCreateDto.DocumentNumber);
            var discountRequest = await _unitOfWork.Repository<DiscountRequest>().FindAsync(documenteNumberCriteria);
            if (discountRequest != null)
            {
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = $"Submitted document number has beed already used in another request no. {discountRequest.RequestNumber}" });
            }
            else if (discountRequestCreateDto.InvoiceNumber != null)
            {
                Expression<Func<DiscountRequest, bool>> invoiceNumberCriteria = (r => r.InvoiceNumber == discountRequestCreateDto.InvoiceNumber);
                discountRequest = await _unitOfWork.Repository<DiscountRequest>().FindAsync(invoiceNumberCriteria);
                if (discountRequest != null)
                    return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = $"Submitted invoice number has beed already used in another request no. {discountRequest.RequestNumber}" });
            }

            var requestId = long.Parse(DateTime.Now.ToString("yyyyMMddhhmmssff"));

            var requestNo = $"Discount-{DateTime.Now.ToString("yyyyMMddhhmmss")}";
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var request = new Models.Request { Id = requestId, DefinedRequestId = discountRequestCreateDto.DefinedRequestId };
            request.Notes = discountRequestCreateDto.Notes;
            request.DiscountRequest = _mapper.Map<DiscountRequest>(discountRequestCreateDto);
            request.DiscountRequest.RequestNumber = requestNo;

            if (discountRequestCreateDto.Attachments != null && discountRequestCreateDto.Attachments.Count > 0)
            {
                request.Attachments = _fileService.UploadAttachments(requestId, $@"DiscountRequest\{requestId}", discountRequestCreateDto.Attachments, user.FullName);
            }

            request.CreatorId = user?.Id;
            request.DiscountRequest.CreatedBy = user?.FullName;
            request.CreatedBy = user?.FullName;
            request.DiscountRequest.CreatedBy = user?.FullName;

            _unitOfWork.Repository<Models.Request>().Add(request);

            var result = _unitOfWork.Complete();

            await _requestReviewerRepository.BeginRequestCycle(discountRequestCreateDto.DefinedRequestId, requestId, user.Id, true);

            if (result < 1)
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "Adding new request has been failed" });

            #region Send Emails

            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {user.FullName.Split(" ")[0]},
                    Kindly not that your Discount Request on eDocuement has been created successfully and it's under reviewing now.
                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with your request Status.

                    - eDocument Request Reference No.: {requestNo}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"Discount Request No. {requestNo} on eDocuement",

                To = $"{user.Email};DPWSokhna.CustomerService@dpworld.com;DPWSokhna.Commercial@dpworld.com;"
            };

            _mailService.SendMailAsync(creatorMailContent);

            var reviewersEmails = await _requestReviewerRepository.GetAllRequestReviewersEmailsByStageNumberAsync(requestId, request.CurrentStage);
            var reviewerMailContent = new MailContent
            {
                Body = $"""
                Dears,
                    Kindly note that {user.FullName} has created Discount Request for on eDocuement and need to be reviewed from your side.

                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                    - eDocument Request Reference No.: {requestNo}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                """,
                IsHTMLBody = false,
                Subject = $"Discount Request No. {requestNo} on eDocuement",
                To = reviewersEmails
            };

            _mailService.SendMailAsync(reviewerMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Request has been created successfully - Request No. {requestNo}" });
        }

        /// <summary>
        /// Update Discount Request
        /// </summary>
        /// <param name="id">Discount request Id</param>
        /// <param name="discountRequestUpdateDto">Discount request Informarion</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [Consumes("multipart/form-data")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("Discount/Update/{id}")]
        [Authorize(Roles = "CustomerService,Commercial")]
        public async Task<ActionResult> UpdateDiscountRequest(long id, [FromForm] DiscountRequestUpdateDto discountRequestUpdateDto)
        {
            _logger.LogInformation($"Start UpdateDiscountRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(discountRequestUpdateDto)} ");

            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            Expression<Func<Models.Request, bool>> requestRxpression = (r => r.Id == id);

            var request = await _unitOfWork.Repository<Models.Request>().FindAsync(requestRxpression, new string[] { "DiscountRequest", "Attachments" });

            if (request == null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"Request not found" });

            var oldAttachments = request.Attachments;
            request.Notes = discountRequestUpdateDto.Notes;
            _mapper.Map(discountRequestUpdateDto, request);
            _mapper.Map(discountRequestUpdateDto, request.DiscountRequest);

            if (discountRequestUpdateDto.Attachments == null || discountRequestUpdateDto.Attachments.Count == 0)
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

                request.Attachments = _fileService.UploadAttachments(request.Id, $@"DiscountRequest\{request.Id}", discountRequestUpdateDto.Attachments, createdBy: request.PoRequest.CreatedBy, modifiedBy: user.FullName, modifiedAt: DateTime.Now);
            }

            request.DiscountRequest.ModifiedAt = DateTime.Now;
            request.DiscountRequest.ModifiedBy = user?.FullName;
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
                    Kindly not that your Discount Request on eDocuement has been updated successfully and it's under reviewing now.
                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with your request Status.

                    - eDocument Request Reference No.: {request.DiscountRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"Discount Request No. {request.DiscountRequest.RequestNumber} on eDocuement",
                To = $"{user.Email};DPWSokhna.CustomerService@dpworld.com;DPWSokhna.Commercial@dpworld.com;"
            };

            _mailService.SendMailAsync(creatorMailContent);

            var reviewersEmails = await _requestReviewerRepository.GetAllRequestReviewersEmailsByStageNumberAsync(id, request.CurrentStage);
            var reviewerMailContent = new MailContent
            {
                Body = $"""
                Dears,
                    Kindly note that {user.FullName} has updated Discount Request for on eDocuement and need to be reviewed from your side.

                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                    - eDocument Request Reference No.: {request.DiscountRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                """,
                IsHTMLBody = false,
                Subject = $"Discount Request No. {request.DiscountRequest.RequestNumber} on eDocuement",
                To = reviewersEmails
            };

            _mailService.SendMailAsync(reviewerMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Request has been updated successfully" });
        }

        /// <summary>
        /// Approve Discount Request
        /// </summary>
        /// <param name="requestReviewerWriteDto">Approve Discount Request</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("Discount/Approve")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> ApproveDiscountRequest(ApproveRequestReviewerDto requestReviewerWriteDto)
        {
            _logger.LogInformation($"Start ApproveDiscountRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(requestReviewerWriteDto)} ");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == requestReviewerWriteDto.RequestId);
            var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "DiscountRequest", "Creator", "Creator.Department", "Creator.Department.Manager" });

            var result = await _requestReviewerRepository.ApproveRequestAsync(requestReviewerWriteDto, user);
            if (!result.IsSucceded)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = result.Message });

            #region Send Emails

            var requestCreator = request.Creator;
            var requestCreatorDepartmentManager = request.Creator.Department.Manager;
            if (request?.Status == RequestStatus.Approved.ToString())
            {
                var creatorMailContent = new MailContent
                {
                    Body = $"""
                Dear {requestCreator.FullName.Split(" ")[0]},
                    Kindly not that your Discount Request {request.DiscountRequest.RequestNumber} on eDocuement has been approved successfully.
                    For more detail, please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}).

                    - eDocument Request Reference No.: {request.DiscountRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                    IsHTMLBody = false,
                    Subject = $"Discount Request No. {request.DiscountRequest.RequestNumber} on eDocuement",
                    To = $"{requestCreator.Email};DPWSokhna.CustomerService@dpworld.com;DPWSokhna.Commercial@dpworld.com;"
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
                        Kindly note that {requestCreator.FullName} has created Discount Request for on eDocuement and need to be reviewed from your side.

                        Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                        - eDocument Request Reference No.: {request.DiscountRequest.RequestNumber}

                    Thanks,

                    “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                    """,
                    IsHTMLBody = false,
                    Subject = $"Discount Request No. {request.DiscountRequest.RequestNumber} on eDocuement",
                    To = reviewersEmails
                };

                _mailService.SendMailAsync(reviewerMailContent);
            }

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Your action has been recorded successfully" });
        }

        /// <summary>
        /// Decline Discount Request
        /// </summary>
        /// <param name="requestReviewerWriteDto">Decline Discount Request</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("Discount/Decline")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> DeclineDiscountRequest(DeclineRequestReviewerDto requestReviewerWriteDto)
        {
            _logger.LogInformation($"Start DeclineDiscountRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(requestReviewerWriteDto)} ");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var result = await _requestReviewerRepository.DeclineRequestAsync(requestReviewerWriteDto, user);
            if (!result.IsSucceded)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = result.Message });

            #region Send Emails

            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == requestReviewerWriteDto.RequestId);
            var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "DiscountRequest", "Creator", "Creator.Department", "Creator.Department.Manager" });

            var requestCreator = request.Creator;
            var requestCreatorDepartmentManager = request.Creator.Department.Manager;
            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {requestCreator.FullName.Split(" ")[0]},
                    Kindly not that your Discount Request No. {request.DiscountRequest.RequestNumber} on eDocuement has been declined by {user.FullName}.
                    For more detail, please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}).

                    - eDocument Request Reference No.: {request.DiscountRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"Discount Request No. {request.DiscountRequest.RequestNumber} on eDocuement",
                Cc = requestCreatorDepartmentManager.Email,
                To = $"{requestCreator.Email};DPWSokhna.CustomerService@dpworld.com;DPWSokhna.Commercial@dpworld.com;"
            };

            _mailService.SendMailAsync(creatorMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Your action has been recorded successfully" });
        }

        #endregion Discount Request

        #endregion Commercial

        #region Security

        #region Access Control Request

        /// <summary>
        /// Get Access Control Requests By for Edit Id
        /// </summary>
        /// <param name="id">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>Access Control Request</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<AccessControlRequestEditReadDto>))]
        [HttpGet("AccessControl/{id}")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> GetAccessControlRequestById(long id)
        {
            _logger.LogInformation($"Start GetAccessControlRequestById from {nameof(RequestController)} for request id = {id}");

            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            var accessControlRequest = await _unitOfWork.Repository<AccessControlRequest>().FindRequestAsync(
            requestId: id,
            expression: "Request.Id==@0",
            includes: includes
            );

            if (accessControlRequest is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Request not found" });

            var result = _mapper.Map<AccessControlRequestEditReadDto>(accessControlRequest);
            result.EmployeeSignature = _mapper.Map<AttachmentReadDto>(accessControlRequest.EmployeeSignaturePath);
            result.EmployeeSignature.FileHref = _fileService.GetImageHref(accessControlRequest.EmployeeSignaturePath);

            return Ok(new ApiResponse<AccessControlRequestEditReadDto> { StatusCode = (int)HttpStatusCode.OK, Details = result });
        }

        /// <summary>
        /// Delete Access Control Requests By Id
        /// </summary>
        /// <param name="id">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpDelete("AccessControl/{id}")]
        [Authorize(Roles = "HR")]
        public async Task<ActionResult> DeleteAccessControlRequest(long id)
        {
            _logger.LogInformation($"Start DeleteAccessControlRequest from {nameof(RequestController)} for request id = {id}");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var includes = new string[] { "AccessControlRequest", "Attachments", "RequestReviewers" };

            var request = await _unitOfWork.Repository<Models.Request>().FindRequestAsync(
            requestId: id,
            expression: "Id==@0",
            includes: includes
                );

            if (request is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Request not found" });

            if (request.Status == RequestStatus.Approved.ToString() || request.Status == RequestStatus.Declined.ToString())
            {
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = $"You cannot delete this request after as it has been already {request.Status}" });
            }
            else if (request.RequestReviewers.Any(rr => rr.Status == RequestStatus.Approved.ToString()))
            {
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "You cannot delete the request after one of the reviewers took his action" });
            }

            request.AccessControlRequest.ModifiedBy = user?.FullName;
            request.ModifiedBy = user?.FullName;
            _unitOfWork.Complete();

            _unitOfWork.Repository<Models.Request>().Delete(request);
            _unitOfWork.Complete();

            _fileService.DeleteFolder($@"AccessControlRequest\{id}");

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = "Request deleted successfully" });
        }

        /// <summary>
        /// Get All Access Control Requests By Creator With Filter
        /// </summary>
        /// <param name="filterDto">filter information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of All Created Access Control Requests</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FilterReadDto<AccessControlRequestDetailsReadDto>>))]
        [HttpPost("AccessControl/Inbox")]
        [Authorize(Roles = "HR")]
        public async Task<ActionResult> GetCreatorAccessControlRequestsFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetCreatorAccessControlRequestsFiltered from {nameof(RequestController)} with filter: {JsonSerializer.Serialize(filterDto)}");
            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            string? userCondition = null;

            (int TotalCount, IEnumerable<AccessControlRequest> PaginatedData) result;

            userCondition = "Request.CreatorId ==@0";

            if (!string.IsNullOrEmpty(filterDto?.FilterValue))
            {
                result = await _unitOfWork.Repository<AccessControlRequest>().FindAllRequestsAsync(
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
                result = await _unitOfWork.Repository<AccessControlRequest>().FindAllRequestsAsync(
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

            var requests = _mapper.Map<List<AccessControlRequestDetailsReadDto>>(result.PaginatedData);

            var response = new FilterReadDto<AccessControlRequestDetailsReadDto>
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = filterDto?.PageNo ?? 1,
                PageSize = requests.Count,
                PaginatedData = requests
            };
            return Ok(new ApiResponse<FilterReadDto<AccessControlRequestDetailsReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = response });
        }

        /// <summary>
        /// Get All Access Control Requests By Reviewer With Filter
        /// </summary>
        /// <param name="filterDto">filter information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of All Reviewer Access Control Requests</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FilterReadDto<AccessControlRequestReviewerReadDto>>))]
        [HttpPost("AccessControl/AssignedToMe")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> GetReviewerAccessControlRequestsFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetReviewerAccessControlRequestsFiltered from {nameof(RequestController)} with filter: {JsonSerializer.Serialize(filterDto)}");
            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            string? userCondition = null;

            (int TotalCount, IEnumerable<AccessControlRequest> PaginatedData) result;

            userCondition = "Request.RequestReviewers.Any(AssignedReviewerId == @0 && Request.CurrentStage >= StageNumber)";

            if (!string.IsNullOrEmpty(filterDto?.FilterValue))
            {
                result = await _unitOfWork.Repository<AccessControlRequest>().FindAllRequestsAsync(
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
                result = await _unitOfWork.Repository<AccessControlRequest>().FindAllRequestsAsync(
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

            var requests = _mapper.Map<List<AccessControlRequestReviewerReadDto>>(result.PaginatedData);

            foreach (var request in requests)
            {
                var reviewer = request.RequestReviewers?.OrderBy(r => r.StageNumber).LastOrDefault(y => y.AssignedReviewerId == User.FindFirstValue(ClaimTypes.NameIdentifier) && y.Status != RequestStatus.None);

                request.ReviewerStatus = reviewer?.Status;
                request.ReviewerStage = reviewer?.StageNumber;
            }

            var response = new FilterReadDto<AccessControlRequestReviewerReadDto>
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = filterDto?.PageNo ?? 1,
                PageSize = requests.Count,
                PaginatedData = requests
            };
            return Ok(new ApiResponse<FilterReadDto<AccessControlRequestReviewerReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = response });
        }

        /// <summary>
        /// Create Access Control Request
        /// </summary>
        /// <param name="accessControlRequestCreateDto">Trave lDesk request Informarion</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [Consumes("multipart/form-data")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPost("AccessControl/Create")]
        [Authorize(Roles = "HR")]
        public async Task<ActionResult> CreateAccessControlRequest([FromForm] AccessControlRequestCreateDto accessControlRequestCreateDto)
        {
            _logger.LogInformation($"Start CreateAccessControlRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(accessControlRequestCreateDto)} ");

            var beneficiaryUser = await _userManager.Users.Include(t => t.Department).FirstOrDefaultAsync(u => u.Id == accessControlRequestCreateDto.BeneficiaryId);

            if (beneficiaryUser is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"Beneficiary user '{accessControlRequestCreateDto.BeneficiaryId}' not found" });

            var requestId = long.Parse(DateTime.Now.ToString("yyyyMMddhhmmssff"));

            var requestNo = $"AccessControl-{DateTime.Now.ToString("yyyyMMddhhmmss")}";
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var request = new Request { Id = requestId, DefinedRequestId = accessControlRequestCreateDto.DefinedRequestId };
            request.Notes = accessControlRequestCreateDto.Notes;
            request.AccessControlRequest = _mapper.Map<AccessControlRequest>(accessControlRequestCreateDto);
            _mapper.Map(beneficiaryUser, request.AccessControlRequest);
            request.AccessControlRequest.RequestNumber = requestNo;
            request.AccessControlRequest.EmployeeSignaturePath = _fileService.UploadAttachment($@"AccessControlRequest\{requestId}", accessControlRequestCreateDto.EmployeeSignature);

            request.CreatorId = user?.Id;
            request.AccessControlRequest.CreatedBy = user?.FullName;
            request.CreatedBy = user?.FullName;
            request.AccessControlRequest.CreatedBy = user?.FullName;

            _unitOfWork.Repository<Request>().Add(request);

            var result = _unitOfWork.Complete();

            await _requestReviewerRepository.BeginRequestCycle(accessControlRequestCreateDto.DefinedRequestId, requestId, beneficiaryUser.Id, true);

            if (result < 1)
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "Adding new request has been failed" });

            #region Send Emails

            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {user.FullName.Split(" ")[0]},
                    Kindly not that your Access Control Request on eDocuement has been created successfully and it's under reviewing now.
                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with your request Status.

                    - eDocument Request Reference No.: {requestNo}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"Access Control Request No. {requestNo} on eDocuement",
                To = user.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            var reviewersEmails = await _requestReviewerRepository.GetAllRequestReviewersEmailsByStageNumberAsync(requestId, request.CurrentStage);
            var reviewerMailContent = new MailContent
            {
                Body = $"""
                Dears,
                    Kindly note that {user.FullName} has created Access Control Request for on eDocuement and need to be reviewed from your side.

                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                    - eDocument Request Reference No.: {requestNo}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                """,
                IsHTMLBody = false,
                Subject = $"Access Control Request No. {requestNo} on eDocuement",
                To = reviewersEmails
            };

            _mailService.SendMailAsync(reviewerMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Request has been created successfully - Request No. {requestNo}" });
        }

        /// <summary>
        /// Update Access Control Request
        /// </summary>
        /// <param name="id">Travel Desk request Id</param>
        /// <param name="accessControlRequestUpdateDto">AccessControl request Informarion</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [Consumes("multipart/form-data")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("AccessControl/Update/{id}")]
        [Authorize(Roles = "HR")]
        public async Task<ActionResult> UpdateAccessControlRequest(long id, [FromForm] AccessControlRequestUpdateDto accessControlRequestUpdateDto)
        {
            _logger.LogInformation($"Start UpdateAccessControlRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(accessControlRequestUpdateDto)} ");

            var beneficiaryUser = await _userManager.Users.Include(t => t.Department).FirstOrDefaultAsync(u => u.Id == accessControlRequestUpdateDto.BeneficiaryId);

            if (beneficiaryUser is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"Beneficiary user '{accessControlRequestUpdateDto.BeneficiaryId}' not found" });

            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            Expression<Func<Models.Request, bool>> requestRxpression = (r => r.Id == id);

            var request = await _unitOfWork.Repository<Models.Request>().FindAsync(requestRxpression, new string[] { "AccessControlRequest", "Attachments" });

            if (request == null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"Request not found" });

            var oldEmployeeSignaturePath = request.AccessControlRequest.EmployeeSignaturePath;
            request.Notes = accessControlRequestUpdateDto.Notes;
            _mapper.Map(accessControlRequestUpdateDto, request);
            _mapper.Map(accessControlRequestUpdateDto, request.AccessControlRequest);
            _mapper.Map(beneficiaryUser, request.AccessControlRequest);

            if (accessControlRequestUpdateDto.EmployeeSignature == null)
            {
                request.AccessControlRequest.EmployeeSignaturePath = oldEmployeeSignaturePath;
            }
            else
            {
                _fileService.DeleteFile(oldEmployeeSignaturePath);
                request.AccessControlRequest.EmployeeSignaturePath = _fileService.UploadAttachment($@"AccessControlRequest\{request.Id}", accessControlRequestUpdateDto.EmployeeSignature);
            }

            request.AccessControlRequest.ModifiedAt = DateTime.Now;
            request.AccessControlRequest.ModifiedBy = user?.FullName;
            request.ModifiedBy = user?.FullName;

            var result = _unitOfWork.Complete();

            await _requestReviewerRepository.BeginRequestCycle(request.DefinedRequestId, request.Id, beneficiaryUser.Id, false);

            if (result < 1)
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "Request update has been failed" });

            #region Send Emails

            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {user.FullName.Split(" ")[0]},
                    Kindly not that your Access Control Request on eDocuement has been updated successfully and it's under reviewing now.
                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with your request Status.

                    - eDocument Request Reference No.: {request.AccessControlRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"Access Control Request No. {request.AccessControlRequest.RequestNumber} on eDocuement",
                To = user.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            var reviewersEmails = await _requestReviewerRepository.GetAllRequestReviewersEmailsByStageNumberAsync(request.Id, request.CurrentStage);
            var reviewerMailContent = new MailContent
            {
                Body = $"""
                Dears,
                    Kindly note that {user.FullName} has updated Access Control Request for on eDocuement and need to be reviewed from your side.

                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                    - eDocument Request Reference No.: {request.AccessControlRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                """,
                IsHTMLBody = false,
                Subject = $"Access Control Request No. {request.AccessControlRequest.RequestNumber} on eDocuement",
                To = reviewersEmails
            };

            _mailService.SendMailAsync(reviewerMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Request has been updated successfully" });
        }

        /// <summary>
        /// Approve Access Control Request
        /// </summary>
        /// <param name="requestReviewerWriteDto">Approve Access Control Request</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("AccessControl/Approve")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> ApproveAccessControlRequest(ApproveRequestReviewerDto requestReviewerWriteDto)
        {
            _logger.LogInformation($"Start ApproveAccessControlRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(requestReviewerWriteDto)} ");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var result = await _requestReviewerRepository.ApproveRequestAsync(requestReviewerWriteDto, user);

            if (!result.IsSucceded)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = result.Message });

            #region Send Emails

            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == requestReviewerWriteDto.RequestId);
            var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "AccessControlRequest", "Creator", "Creator.Department", "Creator.Department.Manager" });
            var requestCreator = request.Creator;
            if (request?.Status == RequestStatus.Approved.ToString())
            {
                var requestCreatorDirectManager = request.Creator.Manager;
                var requestCreatorDepartmentManager = request.Creator.Department.Manager;
                var creatorMailContent = new MailContent
                {
                    Body = $"""
                Dear {requestCreator.FullName.Split(" ")[0]},
                    Kindly not that your Access Control Request {request.AccessControlRequest.RequestNumber} on eDocuement has been approved successfully.
                    For more detail, please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}).

                    - eDocument Request Reference No.: {request.AccessControlRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                    IsHTMLBody = false,
                    Subject = $"Access Control Request No. {request.AccessControlRequest.RequestNumber} on eDocuement",
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
                        Kindly note that {requestCreator.FullName} has created Access Control Request for on eDocuement and need to be reviewed from your side.

                        Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                        - eDocument Request Reference No.: {request.AccessControlRequest.RequestNumber}

                    Thanks,

                    “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                    """,
                    IsHTMLBody = false,
                    Subject = $"Access Control Request No. {request.AccessControlRequest.RequestNumber} on eDocuement",
                    To = reviewersEmails
                };

                _mailService.SendMailAsync(reviewerMailContent);
            }

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Your action has been recorded successfully" });
        }

        /// <summary>
        /// Decline Access Control Request
        /// </summary>
        /// <param name="requestReviewerWriteDto">Decline Access Control Request</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("AccessControl/Decline")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> DeclineAccessControlRequest(DeclineRequestReviewerDto requestReviewerWriteDto)
        {
            _logger.LogInformation($"Start DeclineAccessControlRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(requestReviewerWriteDto)} ");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var result = await _requestReviewerRepository.DeclineRequestAsync(requestReviewerWriteDto, user);
            if (!result.IsSucceded)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = result.Message });

            #region Send Emails

            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == requestReviewerWriteDto.RequestId);
            var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "AccessControlRequest", "Creator" });

            var requestCreator = request.Creator;
            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {requestCreator.FullName.Split(" ")[0]},
                    Kindly not that your Access Control Request No. {request.AccessControlRequest.RequestNumber} on eDocuement has been declined by {user.FullName}.
                    For more detail, please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}).

                    - eDocument Request Reference No.: {request.AccessControlRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"Access Control Request No. {request.AccessControlRequest.RequestNumber} on eDocuement",
                To = requestCreator.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Your action has been recorded successfully" });
        }

        #endregion Access Control Request

        #region CCTV Request

        /// <summary>
        /// Get CCTV Access Requests By for Edit Id
        /// </summary>
        /// <param name="id">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>CCTV Access Request</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<CCTVAccessRequestEditReadDto>))]
        [HttpGet("CCTVAccess/{id}")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> GetCCTVAccessRequestById(long id)
        {
            _logger.LogInformation($"Start GetCCTVAccessRequestById from {nameof(RequestController)} for request id = {id}");

            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            var cctvAccessRequest = await _unitOfWork.Repository<CCTVAccessRequest>().FindRequestAsync(
            requestId: id,
            expression: "Request.Id==@0",
            includes: includes
            );

            if (cctvAccessRequest is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Request not found" });

            var result = _mapper.Map<CCTVAccessRequestEditReadDto>(cctvAccessRequest);

            return Ok(new ApiResponse<CCTVAccessRequestEditReadDto> { StatusCode = (int)HttpStatusCode.OK, Details = result });
        }

        /// <summary>
        /// Delete CCTV Access Requests By Id
        /// </summary>
        /// <param name="id">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpDelete("CCTVAccess/{id}")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> DeleteCCTVAccessRequest(long id)
        {
            _logger.LogInformation($"Start DeleteCCTVAccessRequest from {nameof(RequestController)} for request id = {id}");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var includes = new string[] { "CCTVAccessRequest", "Attachments", "RequestReviewers" };

            var request = await _unitOfWork.Repository<Models.Request>().FindRequestAsync(
            requestId: id,
            expression: "Id==@0",
            includes: includes
                );

            if (request is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Request not found" });

            if (request.Status == RequestStatus.Approved.ToString() || request.Status == RequestStatus.Declined.ToString())
            {
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = $"You cannot delete this request after as it has been already {request.Status}" });
            }
            else if (request.RequestReviewers.Any(rr => rr.Status == RequestStatus.Approved.ToString()))
            {
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "You cannot delete the request after one of the reviewers took his action" });
            }

            request.CCTVAccessRequest.ModifiedBy = user?.FullName;
            request.ModifiedBy = user?.FullName;
            _unitOfWork.Complete();

            _unitOfWork.Repository<Models.Request>().Delete(request);
            _unitOfWork.Complete();

            _fileService.DeleteFolder($@"CCTVAccessRequest\{id}");

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = "Request deleted successfully" });
        }

        /// <summary>
        /// Get All CCTV Access Requests By Creator With Filter
        /// </summary>
        /// <param name="filterDto">filter information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of All Created CCTV Access Requests</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FilterReadDto<CCTVAccessRequestDetailsReadDto>>))]
        [HttpPost("CCTVAccess/Inbox")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> GetCreatorCCTVAccessRequestsFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetCreatorCCTVAccessRequestsFiltered from {nameof(RequestController)} with filter: {JsonSerializer.Serialize(filterDto)}");
            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            string? userCondition = null;

            (int TotalCount, IEnumerable<CCTVAccessRequest> PaginatedData) result;

            userCondition = "Request.CreatorId ==@0";

            if (!string.IsNullOrEmpty(filterDto?.FilterValue))
            {
                result = await _unitOfWork.Repository<CCTVAccessRequest>().FindAllRequestsAsync(
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
                result = await _unitOfWork.Repository<CCTVAccessRequest>().FindAllRequestsAsync(
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

            var requests = _mapper.Map<List<CCTVAccessRequestDetailsReadDto>>(result.PaginatedData);

            var response = new FilterReadDto<CCTVAccessRequestDetailsReadDto>
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = filterDto?.PageNo ?? 1,
                PageSize = requests.Count,
                PaginatedData = requests
            };
            return Ok(new ApiResponse<FilterReadDto<CCTVAccessRequestDetailsReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = response });
        }

        /// <summary>
        /// Get All CCTV Access Requests By Reviewer With Filter
        /// </summary>
        /// <param name="filterDto">filter information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of All Reviewer CCTV Access Requests</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FilterReadDto<CCTVAccessRequestReviewerReadDto>>))]
        [HttpPost("CCTVAccess/AssignedToMe")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> GetReviewerCCTVAccessRequestsFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetReviewerCCTVAccessRequestsFiltered from {nameof(RequestController)} with filter: {JsonSerializer.Serialize(filterDto)}");
            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            string? userCondition = null;

            (int TotalCount, IEnumerable<CCTVAccessRequest> PaginatedData) result;

            userCondition = "Request.RequestReviewers.Any(AssignedReviewerId == @0 && Request.CurrentStage >= StageNumber)";

            if (!string.IsNullOrEmpty(filterDto?.FilterValue))
            {
                result = await _unitOfWork.Repository<CCTVAccessRequest>().FindAllRequestsAsync(
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
                result = await _unitOfWork.Repository<CCTVAccessRequest>().FindAllRequestsAsync(
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

            var requests = _mapper.Map<List<CCTVAccessRequestReviewerReadDto>>(result.PaginatedData);

            foreach (var request in requests)
            {
                var reviewer = request.RequestReviewers?.OrderBy(r => r.StageNumber).LastOrDefault(y => y.AssignedReviewerId == User.FindFirstValue(ClaimTypes.NameIdentifier) && y.Status != RequestStatus.None);

                request.ReviewerStatus = reviewer?.Status;
                request.ReviewerStage = reviewer?.StageNumber;
            }

            var response = new FilterReadDto<CCTVAccessRequestReviewerReadDto>
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = filterDto?.PageNo ?? 1,
                PageSize = requests.Count,
                PaginatedData = requests
            };
            return Ok(new ApiResponse<FilterReadDto<CCTVAccessRequestReviewerReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = response });
        }

        /// <summary>
        /// Create CCTV Access Request
        /// </summary>
        /// <param name="cctvAccessRequestCreateDto">CCTV Access request Informarion</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPost("CCTVAccess/Create")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> CreateCCTVAccessRequest(CCTVAccessRequestCreateDto cctvAccessRequestCreateDto)
        {
            _logger.LogInformation($"Start CreateCCTVAccessRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(cctvAccessRequestCreateDto)} ");
            var user = await _userManager.Users.Include(t => t.Department).FirstOrDefaultAsync(u => u.Id == User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var requestId = long.Parse(DateTime.Now.ToString("yyyyMMddhhmmssff"));
            var requestNo = $"CCTVAccess-{DateTime.Now.ToString("yyyyMMddhhmmss")}";

            var request = new Models.Request { Id = requestId, DefinedRequestId = cctvAccessRequestCreateDto.DefinedRequestId };
            request.Notes = cctvAccessRequestCreateDto.Notes;
            request.CCTVAccessRequest = _mapper.Map<CCTVAccessRequest>(cctvAccessRequestCreateDto);
            _mapper.Map(user, request.CCTVAccessRequest);
            request.CCTVAccessRequest.RequestNumber = requestNo;

            request.CreatorId = user?.Id;
            request.CCTVAccessRequest.CreatedBy = user?.FullName;
            request.CreatedBy = user?.FullName;
            request.CCTVAccessRequest.CreatedBy = user?.FullName;

            _unitOfWork.Repository<Models.Request>().Add(request);

            var result = _unitOfWork.Complete();

            await _requestReviewerRepository.BeginRequestCycle(cctvAccessRequestCreateDto.DefinedRequestId, requestId, user.Id, true);

            if (result < 1)
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "Adding new request has been failed" });

            #region Send Emails

            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {user.FullName.Split(" ")[0]},
                    Kindly not that your CCTV Access Request on eDocuement has been created successfully and it's under reviewing now.
                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with your request Status.

                    - eDocument Request Reference No.: {requestNo}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"CCTV Access Request No. {requestNo} on eDocuement",
                To = user.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            var reviewersEmails = await _requestReviewerRepository.GetAllRequestReviewersEmailsByStageNumberAsync(requestId, request.CurrentStage);
            var reviewerMailContent = new MailContent
            {
                Body = $"""
                Dears,
                    Kindly note that {user.FullName} has created CCTV Access Request for on eDocuement and need to be reviewed from your side.

                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                    - eDocument Request Reference No.: {requestNo}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                """,
                IsHTMLBody = false,
                Subject = $"CCTV Access Request No. {requestNo} on eDocuement",
                To = reviewersEmails
            };

            _mailService.SendMailAsync(reviewerMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Request has been created successfully - Request No. {requestNo}" });
        }

        /// <summary>
        /// Update CCTV Access Request
        /// </summary>
        /// <param name="id">CCTV Access request Id</param>
        /// <param name="cctvAccessRequestUpdateDto">CCTV Access request Informarion</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("CCTVAccess/Update/{id}")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> UpdateCCTVAccessRequest(long id, CCTVAccessRequestUpdateDto cctvAccessRequestUpdateDto)
        {
            _logger.LogInformation($"Start UpdateCCTVAccessRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(cctvAccessRequestUpdateDto)} ");

            var user = await _userManager.Users.Include(t => t.Department).FirstOrDefaultAsync(u => u.Id == User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == id);

            var request = await _unitOfWork.Repository<Request>().FindAsync(requestRxpression, new string[] { "CCTVAccessRequest", "Attachments" });

            if (request == null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"Request not found" });

            request.Notes = cctvAccessRequestUpdateDto.Notes;
            _mapper.Map(cctvAccessRequestUpdateDto, request);
            _mapper.Map(cctvAccessRequestUpdateDto, request.CCTVAccessRequest);
            request.CCTVAccessRequest.RequestId = id;
            request.CCTVAccessRequest.ModifiedAt = DateTime.Now;
            request.CCTVAccessRequest.ModifiedBy = user?.FullName;
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
                    Kindly not that your CCTV Access Request on eDocuement has been created successfully and it's under reviewing now.
                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with your request Status.

                    - eDocument Request Reference No.: {request.CCTVAccessRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"CCTV Access Request No. {request.CCTVAccessRequest.RequestNumber} on eDocuement",
                To = user.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            var reviewersEmails = await _requestReviewerRepository.GetAllRequestReviewersEmailsByStageNumberAsync(request.Id, request.CurrentStage);
            var reviewerMailContent = new MailContent
            {
                Body = $"""
                Dears,
                    Kindly note that {user.FullName} has updated CCTV Access Request for on eDocuement and need to be reviewed from your side.

                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                    - eDocument Request Reference No.: {request.CCTVAccessRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                """,
                IsHTMLBody = false,
                Subject = $"CCTV Access Request No. {request.CCTVAccessRequest.RequestNumber} on eDocuement",
                To = reviewersEmails
            };

            _mailService.SendMailAsync(reviewerMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Request has been updated successfully" });
        }

        /// <summary>
        /// Approve CCTV Access Request
        /// </summary>
        /// <param name="requestReviewerWriteDto">Approve CCTV Access Request</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("CCTVAccess/Approve")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> ApproveCCTVAccessRequest(ApproveRequestReviewerDto requestReviewerWriteDto)
        {
            _logger.LogInformation($"Start ApproveCCTVAccessRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(requestReviewerWriteDto)} ");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var result = await _requestReviewerRepository.ApproveRequestAsync(requestReviewerWriteDto, user);

            if (!result.IsSucceded)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = result.Message });

            #region Send Emails

            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == requestReviewerWriteDto.RequestId);
            var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "CCTVAccessRequest", "Creator", "Creator.Department", "Creator.Department.Manager" });
            var requestCreator = request.Creator;
            if (request?.Status == RequestStatus.Approved.ToString())
            {
                var requestCreatorDirectManager = request.Creator.Manager;
                var requestCreatorDepartmentManager = request.Creator.Department.Manager;
                var creatorMailContent = new MailContent
                {
                    Body = $"""
                Dear {requestCreator.FullName.Split(" ")[0]},
                    Kindly not that your CCTV Access Request {request.CCTVAccessRequest.RequestNumber} on eDocuement has been approved successfully.
                    For more detail, please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}).

                    - eDocument Request Reference No.: {request.CCTVAccessRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                    IsHTMLBody = false,
                    Subject = $"CCTV Access Request No. {request.CCTVAccessRequest.RequestNumber} on eDocuement",
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
                        Kindly note that {requestCreator.FullName} has created CCTV Access Request for on eDocuement and need to be reviewed from your side.

                        Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                        - eDocument Request Reference No.: {request.CCTVAccessRequest.RequestNumber}

                    Thanks,

                    “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                    """,
                    IsHTMLBody = false,
                    Subject = $"CCTV Access Request No. {request.CCTVAccessRequest.RequestNumber} on eDocuement",
                    To = reviewersEmails
                };

                _mailService.SendMailAsync(reviewerMailContent);
            }

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Your action has been recorded successfully" });
        }

        /// <summary>
        /// Decline CCTV Access Request
        /// </summary>
        /// <param name="requestReviewerWriteDto">Decline CCTV Access Request</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("CCTVAccess/Decline")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> DeclineCCTVAccessRequest(DeclineRequestReviewerDto requestReviewerWriteDto)
        {
            _logger.LogInformation($"Start DeclineCCTVAccessRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(requestReviewerWriteDto)} ");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var result = await _requestReviewerRepository.DeclineRequestAsync(requestReviewerWriteDto, user);
            if (!result.IsSucceded)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = result.Message });

            #region Send Emails

            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == requestReviewerWriteDto.RequestId);
            var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "CCTVAccessRequest", "Creator" });

            var requestCreator = request.Creator;
            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {requestCreator.FullName.Split(" ")[0]},
                    Kindly not that your CCTV Access Request No. {request.CCTVAccessRequest.RequestNumber} on eDocuement has been declined by {user.FullName}.
                    For more detail, please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}).

                    - eDocument Request Reference No.: {request.CCTVAccessRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"CCTV Access Request No. {request.CCTVAccessRequest.RequestNumber} on eDocuement",
                To = requestCreator.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Your action has been recorded successfully" });
        }

        #endregion CCTV Request

        #endregion Security

        #region Store
      
        #region Fuel Oil Invoice Request

        /// <summary>
        /// Get Fuel Oil Invoice Requests Details
        /// </summary>
        /// <param name="id">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>Fuel Oil Invoice Request</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FuelOilInvoiceRequestReadDto>))]
        [HttpGet("FuelOilInvoice/{id}")]
        [Authorize(Roles = "Basic")]
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
        [HttpDelete("FuelOilInvoice/{id}")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> DeleteFuelOilInvoiceRequest(long id)
        {
            _logger.LogInformation($"Start DeleteFuelOilInvoiceRequest from {nameof(RequestController)} for request id = {id}");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var includes = new string[] { "FuelOilInvoiceRequest", "Attachments", "RequestReviewers" };

            var request = await _unitOfWork.Repository<Models.Request>().FindRequestAsync(
            requestId: id,
            expression: "Id==@0",
            includes: includes
                );

            if (request is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Request not found" });

            if (request.Status == RequestStatus.Approved.ToString() || request.Status == RequestStatus.Declined.ToString())
            {
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = $"You cannot delete this request after as it has been already {request.Status}" });
            }
            else if (request.RequestReviewers.Any(rr => rr.Status == RequestStatus.Approved.ToString()))
            {
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "You cannot delete the request after one of the reviewers took his action" });
            }

            request.FuelOilInvoiceRequest.ModifiedBy = user?.FullName;
            request.ModifiedBy = user?.FullName;
            _unitOfWork.Complete();

            _unitOfWork.Repository<Models.Request>().Delete(request);
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
        [HttpPost("FuelOilInvoice/Inbox")]
        [Authorize(Roles = "Basic")]
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
        [HttpPost("FuelOilInvoice/AssignedToMe")]
        [Authorize(Roles = "Store,Finance")]
        public async Task<ActionResult> GetReviewerFuelOilInvoiceRequestsFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetReviewerFuelOilInvoiceRequestsFiltered from {nameof(RequestController)} with filter: {JsonSerializer.Serialize(filterDto)}");
            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            string? userCondition = null;

            (int TotalCount, IEnumerable<FuelOilInvoiceRequest> PaginatedData) result;

            userCondition = "Request.RequestReviewers.Any(AssignedReviewerId == @0 && Request.CurrentStage >= StageNumber)";

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
                var reviewer = request.RequestReviewers?.OrderBy(r => r.StageNumber).LastOrDefault(y => y.AssignedReviewerId == User.FindFirstValue(ClaimTypes.NameIdentifier) && y.Status != RequestStatus.None);

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
        /// <param name="fuelOilInvoiceRequestCreateDto">Fuel Oil Invoice request Informarion</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [Consumes("multipart/form-data")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPost("FuelOilInvoice/Create")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> CreateFuelOilInvoiceRequest([FromForm] FuelOilInvoiceRequestCreateDto fuelOilInvoiceRequestCreateDto)
        {
            _logger.LogInformation($"Start CreateFuelOilInvoiceRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(fuelOilInvoiceRequestCreateDto)} ");
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

            _unitOfWork.Repository<Models.Request>().Add(request);

            var result = _unitOfWork.Complete();

            await _requestReviewerRepository.BeginRequestCycle(fuelOilInvoiceRequestCreateDto.DefinedRequestId, requestId, user.Id, true);

            if (result < 1)
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "Adding new request has been failed" });

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
        /// <param name="fuelOilInvoiceRequestUpdateDto">Fuel Oil Invoice request Informarion</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [Consumes("multipart/form-data")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("FuelOilInvoice/Update/{id}")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> UpdateFuelOilInvoiceRequest(long id, [FromForm] FuelOilInvoiceRequestUpdateDto fuelOilInvoiceRequestUpdateDto)
        {
            _logger.LogInformation($"Start UpdateFuelOilInvoiceRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(fuelOilInvoiceRequestUpdateDto)} ");

            var user = await _userManager.Users.Include(t => t.Department).FirstOrDefaultAsync(u => u.Id == User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == id);

            var request = await _unitOfWork.Repository<Request>().FindAsync(requestRxpression, new string[] { "FuelOilInvoiceRequest", "Attachments" });

            if (request == null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"Request not found" });

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

                request.Attachments = _fileService.UploadAttachments(request.Id, $@"FuelOilInvoiceRequest\{request.Id}", fuelOilInvoiceRequestUpdateDto.Attachments, createdBy: request.PoRequest.CreatedBy, modifiedBy: user.FullName, modifiedAt: DateTime.Now);
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
        [HttpPut("FuelOilInvoice/Approve")]
        [Authorize(Roles = "Store,Finance")]
        public async Task<ActionResult> ApproveFuelOilInvoiceRequest(ApproveRequestReviewerDto requestReviewerWriteDto)
        {
            _logger.LogInformation($"Start ApproveFuelOilInvoiceRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(requestReviewerWriteDto)} ");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var result = await _requestReviewerRepository.ApproveRequestAsync(requestReviewerWriteDto, user);

            if (!result.IsSucceded)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = result.Message });

            #region Send Emails

            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == requestReviewerWriteDto.RequestId);
            var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "FuelOilInvoiceRequest", "Creator", "Creator.Department", "Creator.Department.Manager" });
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
        [HttpPut("FuelOilInvoice/Decline")]
        [Authorize(Roles = "Store,Finance")]
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

        #endregion Fuel Oil Invoice Request

        #region New Item Request

        /// <summary>
        /// Get New Item Requests Details
        /// </summary>
        /// <param name="id">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>New Item Request</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<NewItemRequestReadDto>))]
        [HttpGet("NewItem/{id}")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> GetNewItemRequestById(long id)
        {
            _logger.LogInformation($"Start GetNewItemRequestById from {nameof(RequestController)} for request id = {id}");

            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments", "RequestedItems" };
            var newItemRequest = await _unitOfWork.Repository<NewItemRequest>().FindRequestAsync(
            requestId: id,
            expression: "Request.Id==@0",
            includes: includes
            );

            if (newItemRequest is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Request not found" });

            var result = _mapper.Map<NewItemRequestReadDto>(newItemRequest);

            return Ok(new ApiResponse<NewItemRequestReadDto> { StatusCode = (int)HttpStatusCode.OK, Details = result });
        }

        /// <summary>
        /// Delete New Item Requests By Id
        /// </summary>
        /// <param name="id">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpDelete("NewItem/{id}")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> DeleteNewItemRequest(long id)
        {
            _logger.LogInformation($"Start DeleteNewItemRequest from {nameof(RequestController)} for request id = {id}");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var includes = new string[] { "NewItemRequest", "Attachments", "RequestReviewers" };

            var request = await _unitOfWork.Repository<Models.Request>().FindRequestAsync(
            requestId: id,
            expression: "Id==@0",
            includes: includes
                );

            if (request is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Request not found" });

            if (request.Status == RequestStatus.Approved.ToString() || request.Status == RequestStatus.Declined.ToString())
            {
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = $"You cannot delete this request after as it has been already {request.Status}" });
            }
            else if (request.RequestReviewers.Any(rr => rr.Status == RequestStatus.Approved.ToString()))
            {
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "You cannot delete the request after one of the reviewers took his action" });
            }

            request.NewItemRequest.ModifiedBy = user?.FullName;
            request.ModifiedBy = user?.FullName;
            _unitOfWork.Complete();

            _unitOfWork.Repository<Models.Request>().Delete(request);
            _unitOfWork.Complete();

            _fileService.DeleteFolder($@"NewItemRequest\{id}");

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = "Request deleted successfully" });
        }

        /// <summary>
        /// Get All New Item Requests By Creator With Filter
        /// </summary>
        /// <param name="filterDto">filter information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of All Created New Item Requests</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FilterReadDto<NewItemRequestReadDto>>))]
        [HttpPost("NewItem/Inbox")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> GetCreatorNewItemRequestsFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetCreatorNewItemRequestsFiltered from {nameof(RequestController)} with filter: {JsonSerializer.Serialize(filterDto)}");
            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments", "RequestedItems" };
            string? userCondition = null;

            (int TotalCount, IEnumerable<NewItemRequest> PaginatedData) result;

            userCondition = "Request.CreatorId ==@0";

            if (!string.IsNullOrEmpty(filterDto?.FilterValue))
            {
                result = await _unitOfWork.Repository<NewItemRequest>().FindAllRequestsAsync(
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
                result = await _unitOfWork.Repository<NewItemRequest>().FindAllRequestsAsync(
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

            var requests = _mapper.Map<List<NewItemRequestReadDto>>(result.PaginatedData);

            var response = new FilterReadDto<NewItemRequestReadDto>
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = filterDto?.PageNo ?? 1,
                PageSize = requests.Count,
                PaginatedData = requests
            };
            return Ok(new ApiResponse<FilterReadDto<NewItemRequestReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = response });
        }

        /// <summary>
        /// Get All New Item Requests By Reviewer With Filter
        /// </summary>
        /// <param name="filterDto">filter information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of All Reviewer New Item Requests</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FilterReadDto<NewItemRequestReviewerReadDto>>))]
        [HttpPost("NewItem/AssignedToMe")]
        [Authorize(Roles = "Store")]
        public async Task<ActionResult> GetReviewerNewItemRequestsFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetReviewerNewItemRequestsFiltered from {nameof(RequestController)} with filter: {JsonSerializer.Serialize(filterDto)}");
            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments", "RequestedItems" };
            string? userCondition = null;

            (int TotalCount, IEnumerable<NewItemRequest> PaginatedData) result;

            userCondition = "Request.RequestReviewers.Any(AssignedReviewerId == @0 && Request.CurrentStage >= StageNumber)";

            if (!string.IsNullOrEmpty(filterDto?.FilterValue))
            {
                result = await _unitOfWork.Repository<NewItemRequest>().FindAllRequestsAsync(
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
                result = await _unitOfWork.Repository<NewItemRequest>().FindAllRequestsAsync(
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

            var requests = _mapper.Map<List<NewItemRequestReviewerReadDto>>(result.PaginatedData);

            foreach (var request in requests)
            {
                var reviewer = request.RequestReviewers?.OrderBy(r => r.StageNumber).LastOrDefault(y => y.AssignedReviewerId == User.FindFirstValue(ClaimTypes.NameIdentifier) && y.Status != RequestStatus.None);

                request.ReviewerStatus = reviewer?.Status;
                request.ReviewerStage = reviewer?.StageNumber;
            }

            var response = new FilterReadDto<NewItemRequestReviewerReadDto>
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = filterDto?.PageNo ?? 1,
                PageSize = requests.Count,
                PaginatedData = requests
            };
            return Ok(new ApiResponse<FilterReadDto<NewItemRequestReviewerReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = response });
        }

        /// <summary>
        /// Create New Item Request
        /// </summary>
        /// <param name="newItemRequestCreateDto">New Item request Information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [Consumes("multipart/form-data")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPost("NewItem/Create")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> CreateNewItemRequest([FromForm] NewItemRequestCreateDto newItemRequestCreateDto)
        {
            _logger.LogInformation($"Start CreateNewItemRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(newItemRequestCreateDto)} ");

            var user = await _userManager.Users.Include(t => t.Department).FirstOrDefaultAsync(u => u.Id == User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var requestId = long.Parse(DateTime.Now.ToString("yyyyMMddhhmmssff"));
            var requestNo = $"NewItem-{DateTime.Now.ToString("yyyyMMddhhmmss")}";

            var request = new Request { Id = requestId, DefinedRequestId = newItemRequestCreateDto.DefinedRequestId };
            request.Notes = newItemRequestCreateDto.Notes;
            request.NewItemRequest = _mapper.Map<NewItemRequest>(newItemRequestCreateDto);
            _mapper.Map(user, request.NewItemRequest);
            request.NewItemRequest.RequestNumber = requestNo;
            var sentItems = Request.Form["RequestedItems"].ToList();

            if (sentItems != null && sentItems.Count > 0)
            {
                foreach (var sentItem in sentItems)
                {
                    var item = JsonConvert.DeserializeObject<RequestedItem>(sentItem);
                    item.RequestNumber = requestNo;
                    item.CreatedAt = DateTime.Now;
                    item.CreatedBy = user?.FullName;
                    request.NewItemRequest.RequestedItems.Add(item);
                }
            }
            else
            {
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "RequestedItems field not found" });
            }

            if (newItemRequestCreateDto.Attachments != null && newItemRequestCreateDto.Attachments.Count > 0)
            {
                request.Attachments = _fileService.UploadAttachments(requestId, $@"NewItemRequest\{requestId}", newItemRequestCreateDto.Attachments, user.FullName);
            }

            request.CreatorId = user?.Id;
            request.NewItemRequest.CreatedBy = user?.FullName;
            request.CreatedBy = user?.FullName;

            _unitOfWork.Repository<Request>().Add(request);

            _unitOfWork.Complete();

            await _requestReviewerRepository.BeginRequestCycle(newItemRequestCreateDto.DefinedRequestId, requestId, user.Id, true);

            #region Send Emails

            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {user.FullName.Split(" ")[0]},
                    Kindly not that your New Item Request on eDocuement has been created successfully and it's under reviewing now.
                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with your request Status.

                    - eDocument Request Reference No.: {requestNo}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"New Item Request No. {requestNo} on eDocuement",
                To = user.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            var reviewersEmails = await _requestReviewerRepository.GetAllRequestReviewersEmailsByStageNumberAsync(requestId, request.CurrentStage);
            var reviewerMailContent = new MailContent
            {
                Body = $"""
                Dears,
                    Kindly note that {user.FullName} has created New Item Request for on eDocuement and need to be reviewed from your side.

                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                    - eDocument Request Reference No.: {requestNo}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                """,
                IsHTMLBody = false,
                Subject = $"New Item Request No. {requestNo} on eDocuement",
                To = reviewersEmails
            };

            _mailService.SendMailAsync(reviewerMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Request has been created successfully - Request No. {requestNo}" });
        }

        /// <summary>
        /// Update New Item Request
        /// </summary>
        /// <param name="id">New Item request Id</param>
        /// <param name="newItemRequestUpdateDto">New Item request Informarion</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [Consumes("multipart/form-data")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("NewItem/Update/{id}")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> UpdateNewItemRequest(long id, [FromForm] NewItemRequestUpdateDto newItemRequestUpdateDto)
        {
            _logger.LogInformation($"Start UpdateNewItemRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(newItemRequestUpdateDto)} ");

            var user = await _userManager.Users.Include(t => t.Department).FirstOrDefaultAsync(u => u.Id == User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == id);

            var request = await _unitOfWork.Repository<Request>().FindAsync(requestRxpression, new string[] { "NewItemRequest", "Attachments", "NewItemRequest.RequestedItems" });

            if (request == null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"Request not found" });

            var oldAttachments = request.Attachments;
            request.Notes = newItemRequestUpdateDto.Notes;
            _mapper.Map(newItemRequestUpdateDto, request.NewItemRequest);

            request.NewItemRequest.RequestId = id;
            var sentItems = Request.Form["RequestedItems"].ToList();


            if (sentItems != null && sentItems.Count > 0)
            {
                _unitOfWork.Repository<RequestedItem>().DeleteRange(request.NewItemRequest.RequestedItems);

                request.NewItemRequest.RequestedItems = new List<RequestedItem>();
                foreach (var sentItem in sentItems)
                {
                    var item = JsonConvert.DeserializeObject<RequestedItem>(sentItem);
                    item.RequestNumber = request.NewItemRequest.RequestNumber;
                    item.CreatedAt = request.CreatedAt;
                    item.CreatedBy = request.CreatedBy;
                    item.ModifiedAt = DateTime.Now;
                    item.ModifiedBy = user?.FullName;
                    request.NewItemRequest.RequestedItems.Add(item);
                }
            }
            else
            {
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "RequestedItems field not found" });
            }

            if (newItemRequestUpdateDto.Attachments == null || newItemRequestUpdateDto.Attachments.Count == 0)
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

                request.Attachments = _fileService.UploadAttachments(request.Id, $@"NewItemRequest\{request.Id}", newItemRequestUpdateDto.Attachments, createdBy: request.PoRequest.CreatedBy, modifiedBy: user.FullName, modifiedAt: DateTime.Now);
            }

            request.NewItemRequest.ModifiedAt = DateTime.Now;
            request.NewItemRequest.ModifiedBy = user?.FullName;
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
                    Kindly not that your New Item Request on eDocuement has been updated successfully and it's under reviewing now.
                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with your request Status.

                    - eDocument Request Reference No.: {request.NewItemRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"New Item Request No. {request.NewItemRequest.RequestNumber} on eDocuement",
                To = user.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            var reviewersEmails = await _requestReviewerRepository.GetAllRequestReviewersEmailsByStageNumberAsync(request.Id, request.CurrentStage);
            var reviewerMailContent = new MailContent
            {
                Body = $"""
                Dears,
                    Kindly note that {user.FullName} has updated New Item Request for on eDocuement and need to be reviewed from your side.

                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                    - eDocument Request Reference No.: {request.NewItemRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                """,
                IsHTMLBody = false,
                Subject = $"New Item Request No. {request.NewItemRequest.RequestNumber} on eDocuement",
                To = reviewersEmails
            };

            _mailService.SendMailAsync(reviewerMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Request has been updated successfully" });
        }

        /// <summary>
        /// Approve New Item Request
        /// </summary>
        /// <param name="approveNewItemRequest">Approve New Item Request Info</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("NewItem/Approve")]
        [Authorize(Roles = "Store")]
        public async Task<ActionResult> ApproveNewItemRequest(ApproveNewItemRequestDto approveNewItemRequest)
        {
            _logger.LogInformation($"Start ApproveNewItemRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(approveNewItemRequest)} ");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            foreach (var item in approveNewItemRequest.ApprovedItems)
            {
                var requestedItem = await _unitOfWork.Repository<RequestedItem>().GetByIdAsync(item.RequestedItemId);
                if (requestedItem != null)
                {
                    requestedItem.ItemNumber = item.ItemNumber;
                    requestedItem.ModifiedBy = user.FullName;
                }
                else
                {
                    return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"Requested Item Not found" });
                }
            }

            _unitOfWork.Complete();

            var result = await _requestReviewerRepository.ApproveRequestAsync(_mapper.Map<ApproveRequestReviewerDto>(approveNewItemRequest), user);

            if (!result.IsSucceded)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = result.Message });

            #region Send Emails

            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == approveNewItemRequest.RequestId);
            var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "NewItemRequest", "Creator" });
            var requestCreator = request.Creator;

            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {requestCreator.FullName.Split(" ")[0]},
                    Kindly not that your New Item Request {request.NewItemRequest.RequestNumber} on eDocuement has been approved successfully.
                    For more detail, please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}).

                    - eDocument Request Reference No.: {request.NewItemRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"New Item Request No. {request.NewItemRequest.RequestNumber} on eDocuement",
                To = requestCreator.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Your action has been recorded successfully" });
        }

        /// <summary>
        /// Decline New Item Request
        /// </summary>
        /// <param name="requestReviewerWriteDto">Decline New Item Request</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("NewItem/Decline")]
        [Authorize(Roles = "Store")]
        public async Task<ActionResult> DeclineNewItemRequest(DeclineRequestReviewerDto requestReviewerWriteDto)
        {
            _logger.LogInformation($"Start DeclineNewItemRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(requestReviewerWriteDto)} ");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var result = await _requestReviewerRepository.DeclineRequestAsync(requestReviewerWriteDto, user);
            if (!result.IsSucceded)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = result.Message });

            #region Send Emails

            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == requestReviewerWriteDto.RequestId);
            var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "NewItemRequest", "Creator" });

            var requestCreator = request.Creator;
            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {requestCreator.FullName.Split(" ")[0]},
                    Kindly not that your New Item Request No. {request.NewItemRequest.RequestNumber} on eDocuement has been declined by {user.FullName}.
                    For more detail, please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}).

                    - eDocument Request Reference No.: {request.NewItemRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"New Item Request No. {request.NewItemRequest.RequestNumber} on eDocuement",
                To = requestCreator.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Your action has been recorded successfully" });
        }

        #endregion New Item Request

        #region PR Request
        /// <summary>
        /// Get PR Requests Details
        /// </summary>
        /// <param name="id">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>PR Request</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<PRRequestReadDto>))]
        [HttpGet("PR/{id}")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> GetPRRequestById(long id)
        {
            _logger.LogInformation($"Start GetPRRequestById from {nameof(RequestController)} for request id = {id}");

            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments", "RequestedPRs" };
            var pRRequest = await _unitOfWork.Repository<PRRequest>().FindRequestAsync(
            requestId: id,
            expression: "Request.Id==@0",
            includes: includes
            );

            if (pRRequest is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Request not found" });

            var result = _mapper.Map<PRRequestReadDto>(pRRequest);

            return Ok(new ApiResponse<PRRequestReadDto> { StatusCode = (int)HttpStatusCode.OK, Details = result });
        }

        /// <summary>
        /// Delete PR Requests By Id
        /// </summary>
        /// <param name="id">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpDelete("PR/{id}")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> DeletePRRequest(long id)
        {
            _logger.LogInformation($"Start DeletePRRequest from {nameof(RequestController)} for request id = {id}");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var includes = new string[] { "PRRequest", "Attachments", "RequestReviewers" };

            var request = await _unitOfWork.Repository<Models.Request>().FindRequestAsync(
            requestId: id,
            expression: "Id==@0",
            includes: includes
                );

            if (request is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Request not found" });

            if (request.Status == RequestStatus.Approved.ToString() || request.Status == RequestStatus.Declined.ToString())
            {
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = $"You cannot delete this request after as it has been already {request.Status}" });
            }
            else if (request.RequestReviewers.Any(rr => rr.Status == RequestStatus.Approved.ToString()))
            {
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "You cannot delete the request after one of the reviewers took his action" });
            }

            request.PRRequest.ModifiedBy = user?.FullName;
            request.ModifiedBy = user?.FullName;
            _unitOfWork.Complete();

            _unitOfWork.Repository<Models.Request>().Delete(request);
            _unitOfWork.Complete();

            _fileService.DeleteFolder($@"PRRequest\{id}");

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = "Request deleted successfully" });
        }

        /// <summary>
        /// Get All PR Requests By Creator With Filter
        /// </summary>
        /// <param name="filterDto">filter information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of All Created PR Requests</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FilterReadDto<PRRequestReadDto>>))]
        [HttpPost("PR/Inbox")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> GetCreatorPRRequestsFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetCreatorPRRequestsFiltered from {nameof(RequestController)} with filter: {JsonSerializer.Serialize(filterDto)}");
            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments", "RequestedPRs" };
            string? userCondition = null;

            (int TotalCount, IEnumerable<PRRequest> PaginatedData) result;

            userCondition = "Request.CreatorId ==@0";

            if (!string.IsNullOrEmpty(filterDto?.FilterValue))
            {
                result = await _unitOfWork.Repository<PRRequest>().FindAllRequestsAsync(
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
                result = await _unitOfWork.Repository<PRRequest>().FindAllRequestsAsync(
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

            var requests = _mapper.Map<List<PRRequestReadDto>>(result.PaginatedData);

            var response = new FilterReadDto<PRRequestReadDto>
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = filterDto?.PageNo ?? 1,
                PageSize = requests.Count,
                PaginatedData = requests
            };
            return Ok(new ApiResponse<FilterReadDto<PRRequestReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = response });
        }

        /// <summary>
        /// Get All PR Requests By Reviewer With Filter
        /// </summary>
        /// <param name="filterDto">filter information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of All Reviewer PR Requests</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FilterReadDto<PRRequestReviewerReadDto>>))]
        [HttpPost("PR/AssignedToMe")]
        [Authorize(Roles = "Store")]
        public async Task<ActionResult> GetReviewerPRRequestsFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetReviewerPRRequestsFiltered from {nameof(RequestController)} with filter: {JsonSerializer.Serialize(filterDto)}");
            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments", "RequestedPRs" };
            string? userCondition = null;

            (int TotalCount, IEnumerable<PRRequest> PaginatedData) result;

            userCondition = "Request.RequestReviewers.Any(AssignedReviewerId == @0 && Request.CurrentStage >= StageNumber)";

            if (!string.IsNullOrEmpty(filterDto?.FilterValue))
            {
                result = await _unitOfWork.Repository<PRRequest>().FindAllRequestsAsync(
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
                result = await _unitOfWork.Repository<PRRequest>().FindAllRequestsAsync(
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

            var requests = _mapper.Map<List<PRRequestReviewerReadDto>>(result.PaginatedData);

            foreach (var request in requests)
            {
                var reviewer = request.RequestReviewers?.OrderBy(r => r.StageNumber).LastOrDefault(y => y.AssignedReviewerId == User.FindFirstValue(ClaimTypes.NameIdentifier) && y.Status != RequestStatus.None);

                request.ReviewerStatus = reviewer?.Status;
                request.ReviewerStage = reviewer?.StageNumber;
            }

            var response = new FilterReadDto<PRRequestReviewerReadDto>
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = filterDto?.PageNo ?? 1,
                PageSize = requests.Count,
                PaginatedData = requests
            };
            return Ok(new ApiResponse<FilterReadDto<PRRequestReviewerReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = response });
        }

        /// <summary>
        /// Create PR Request
        /// </summary>
        /// <param name="pRRequestCreateDto">PR request Information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [Consumes("multipart/form-data")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPost("PR/Create")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> CreatePRRequest([FromForm] PRRequestCreateDto pRRequestCreateDto)
        {
            _logger.LogInformation($"Start CreatePRRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(pRRequestCreateDto)} ");

            var user = await _userManager.Users.Include(t => t.Department).FirstOrDefaultAsync(u => u.Id == User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var requestId = long.Parse(DateTime.Now.ToString("yyyyMMddhhmmssff"));
            var requestNo = $"PR-{DateTime.Now.ToString("yyyyMMddhhmmss")}";

            var request = new Request { Id = requestId, DefinedRequestId = pRRequestCreateDto.DefinedRequestId };
            request.Notes = pRRequestCreateDto.Notes;
            request.PRRequest = _mapper.Map<PRRequest>(pRRequestCreateDto);
            _mapper.Map(user, request.PRRequest);
            request.PRRequest.RequestNumber = requestNo;
            var sentItems = Request.Form["RequestedPRs"].ToList();

            if (sentItems != null && sentItems.Count > 0)
            {
                foreach (var sentItem in sentItems)
                {
                    var item = JsonConvert.DeserializeObject<RequestedPR>(sentItem);
                    item.RequestNumber = requestNo;
                    item.CreatedAt = DateTime.Now;
                    item.CreatedBy = user?.FullName;
                    request.PRRequest.RequestedPRs.Add(item);
                }
            }
            else
            {
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "RequestedItems field not found" });
            }

            if (pRRequestCreateDto.Attachments != null && pRRequestCreateDto.Attachments.Count > 0)
            {
                request.Attachments = _fileService.UploadAttachments(requestId, $@"PRRequest\{requestId}", pRRequestCreateDto.Attachments, user.FullName);
            }

            request.CreatorId = user?.Id;
            request.PRRequest.CreatedBy = user?.FullName;
            request.CreatedBy = user?.FullName;

            _unitOfWork.Repository<Request>().Add(request);

            _unitOfWork.Complete();

            await _requestReviewerRepository.BeginRequestCycle(pRRequestCreateDto.DefinedRequestId, requestId, user.Id, true);

            #region Send Emails

            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {user.FullName.Split(" ")[0]},
                    Kindly not that your PR Request on eDocuement has been created successfully and it's under reviewing now.
                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with your request Status.

                    - eDocument Request Reference No.: {requestNo}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"PR Request No. {requestNo} on eDocuement",
                To = user.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            var reviewersEmails = await _requestReviewerRepository.GetAllRequestReviewersEmailsByStageNumberAsync(requestId, request.CurrentStage);
            var reviewerMailContent = new MailContent
            {
                Body = $"""
                Dears,
                    Kindly note that {user.FullName} has created PR Request for on eDocuement and need to be reviewed from your side.

                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                    - eDocument Request Reference No.: {requestNo}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                """,
                IsHTMLBody = false,
                Subject = $"PR Request No. {requestNo} on eDocuement",
                To = reviewersEmails
            };

            _mailService.SendMailAsync(reviewerMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Request has been created successfully - Request No. {requestNo}" });
        }

        /// <summary>
        /// Update PR Request
        /// </summary>
        /// <param name="id">PR request Id</param>
        /// <param name="pRRequestUpdateDto">PR request Informarion</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [Consumes("multipart/form-data")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("PR/Update/{id}")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> UpdatePRRequest(long id, [FromForm] PRRequestUpdateDto pRRequestUpdateDto)
        {
            _logger.LogInformation($"Start UpdatePRRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(pRRequestUpdateDto)} ");

            var user = await _userManager.Users.Include(t => t.Department).FirstOrDefaultAsync(u => u.Id == User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == id);

            var request = await _unitOfWork.Repository<Request>().FindAsync(requestRxpression, new string[] { "PRRequest", "Attachments", "PRRequest.RequestedPRs" });

            if (request == null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"Request not found" });

            var oldAttachments = request.Attachments;
            request.Notes = pRRequestUpdateDto.Notes;
            _mapper.Map(pRRequestUpdateDto, request.PRRequest);

            request.PRRequest.RequestId = id;
            var sentItems = Request.Form["RequestedPRs"].ToList();


            if (sentItems != null && sentItems.Count > 0)
            {
                _unitOfWork.Repository<RequestedPR>().DeleteRange(request.PRRequest.RequestedPRs);

                request.PRRequest.RequestedPRs = new List<RequestedPR>();
                foreach (var sentItem in sentItems)
                {
                    var item = JsonConvert.DeserializeObject<RequestedPR>(sentItem);
                    item.RequestNumber = request.PRRequest.RequestNumber;
                    item.CreatedAt = request.CreatedAt;
                    item.CreatedBy = request.CreatedBy;
                    item.ModifiedAt = DateTime.Now;
                    item.ModifiedBy = user?.FullName;
                    request.PRRequest.RequestedPRs.Add(item);
                }
            }
            else
            {
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "RequestedPRs field not found" });
            }

            if (pRRequestUpdateDto.Attachments == null || pRRequestUpdateDto.Attachments.Count == 0)
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

                request.Attachments = _fileService.UploadAttachments(request.Id, $@"PRRequest\{request.Id}", pRRequestUpdateDto.Attachments, createdBy: request.PoRequest.CreatedBy, modifiedBy: user.FullName, modifiedAt: DateTime.Now);
            }

            request.PRRequest.ModifiedAt = DateTime.Now;
            request.PRRequest.ModifiedBy = user?.FullName;
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
                    Kindly not that your PR Request on eDocuement has been updated successfully and it's under reviewing now.
                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with your request Status.

                    - eDocument Request Reference No.: {request.PRRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"PR Request No. {request.PRRequest.RequestNumber} on eDocuement",
                To = user.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            var reviewersEmails = await _requestReviewerRepository.GetAllRequestReviewersEmailsByStageNumberAsync(request.Id, request.CurrentStage);
            var reviewerMailContent = new MailContent
            {
                Body = $"""
                Dears,
                    Kindly note that {user.FullName} has updated PR Request for on eDocuement and need to be reviewed from your side.

                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                    - eDocument Request Reference No.: {request.PRRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                """,
                IsHTMLBody = false,
                Subject = $"PR Request No. {request.PRRequest.RequestNumber} on eDocuement",
                To = reviewersEmails
            };

            _mailService.SendMailAsync(reviewerMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Request has been updated successfully" });
        }

        /// <summary>
        /// Approve PR Request
        /// </summary>
        /// <param name="approvePRRequest">Approve PR Request Info</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("PR/Approve")]
        [Authorize(Roles = "Store")]
        public async Task<ActionResult> ApprovePRRequest(ApprovePRRequestDto approvePRRequest)
        {
            _logger.LogInformation($"Start ApprovePRRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(approvePRRequest)} ");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            foreach (var item in approvePRRequest.ApprovedPRs)
            {
                var requestedPR = await _unitOfWork.Repository<RequestedPR>().GetByIdAsync(item.RequestedPRId);
                if (requestedPR != null)
                {
                    requestedPR.PRNumber = item.PRNumber;
                    requestedPR.ModifiedBy = user.FullName;
                }
                else
                {
                    return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"Requested Item Not found" });
                }
            }

            _unitOfWork.Complete();

            var result = await _requestReviewerRepository.ApproveRequestAsync(_mapper.Map<ApproveRequestReviewerDto>(approvePRRequest), user);

            if (!result.IsSucceded)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = result.Message });

            #region Send Emails

            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == approvePRRequest.RequestId);
            var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "PRRequest", "Creator" });
            var requestCreator = request.Creator;

            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {requestCreator.FullName.Split(" ")[0]},
                    Kindly not that your PR Request {request.PRRequest.RequestNumber} on eDocuement has been approved successfully.
                    For more detail, please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}).

                    - eDocument Request Reference No.: {request.PRRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"PR Request No. {request.PRRequest.RequestNumber} on eDocuement",
                To = requestCreator.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Your action has been recorded successfully" });

        }

        /// <summary>
        /// Decline PR Request
        /// </summary>
        /// <param name="requestReviewerWriteDto">Decline PR Request</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("PR/Decline")]
        [Authorize(Roles = "Store")]
        public async Task<ActionResult> DeclinePRRequest(DeclineRequestReviewerDto requestReviewerWriteDto)
        {
            _logger.LogInformation($"Start DeclinePRRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(requestReviewerWriteDto)} ");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var result = await _requestReviewerRepository.DeclineRequestAsync(requestReviewerWriteDto, user);
            if (!result.IsSucceded)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = result.Message });

            #region Send Emails

            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == requestReviewerWriteDto.RequestId);
            var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "PRRequest", "Creator" });

            var requestCreator = request.Creator;
            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {requestCreator.FullName.Split(" ")[0]},
                    Kindly not that your PR Request No. {request.PRRequest.RequestNumber} on eDocuement has been declined by {user.FullName}.
                    For more detail, please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}).

                    - eDocument Request Reference No.: {request.PRRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"PR Request No. {request.PRRequest.RequestNumber} on eDocuement",
                To = requestCreator.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Your action has been recorded successfully" });
        }

        #endregion Store

        #endregion

        #region Operations - Cargo & Bulk

        #region Equipment Request - In Concession Area 

        /// <summary>
        /// Get Equipment Request (In Concession Area) Details
        /// </summary>
        /// <param name="id">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>Equipment Request (In Concession Area)</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<EquipmentInAreaRequestReadDto>))]
        [HttpGet("EquipmentRequestIn/{id}")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> GetEquipmentInRequestById(long id)
        {
            _logger.LogInformation($"Start GetEquipmentInRequestById from {nameof(RequestController)} for request id = {id}");

            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            var equipmentInRequest = await _unitOfWork.Repository<EquipmentRequestIn>().FindRequestAsync(
            requestId: id,
            expression: "Request.Id==@0",
            includes: includes
            );

            if (equipmentInRequest is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Request not found" });

            var result = _mapper.Map<EquipmentInAreaRequestReadDto>(equipmentInRequest);



            return Ok(new ApiResponse<EquipmentInAreaRequestReadDto> { StatusCode = (int)HttpStatusCode.OK, Details = result });
        }

        /// <summary>
        /// Delete Equipment Request (In Concession Area) By Id
        /// </summary>
        /// <param name="id">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpDelete("EquipmentRequestIn/{id}")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> DeleteEquipmentInRequest(long id)
        {
            _logger.LogInformation($"Start Delete EquipmentInAreaRequest from {nameof(RequestController)} for request id = {id}");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var includes = new string[] { "EquipmentRequestIn", "Attachments", "RequestReviewers" };

            var request = await _unitOfWork.Repository<Models.Request>().FindRequestAsync(
            requestId: id,
            expression: "Id==@0",
            includes: includes
                );

            if (request is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Request not found" });

            if (request.Status == RequestStatus.Approved.ToString() || request.Status == RequestStatus.Declined.ToString())
            {
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = $"You cannot delete this request after as it has been already {request.Status}" });

            }
            else if (request.RequestReviewers.Any(rr => rr.Status == RequestStatus.Approved.ToString()))
            {
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "You cannot delete the request after one of the reviewers took his action" });

            }

            request.EquipmentRequestIn.ModifiedBy = user?.FullName;
            request.ModifiedBy = user?.FullName;
            _unitOfWork.Complete();

            _unitOfWork.Repository<Models.Request>().Delete(request);
            _unitOfWork.Complete();

            _fileService.DeleteFolder($@"EquipmentRequestIn\{id}");

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = "Request deleted successfully" });
        }


        /// <summary>
        /// Get All Equipment Request (In Concession Area) By Creator With Filter
        /// </summary>
        /// <param name="filterDto">filter information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of All Created Equipment Request (In Concession Area)</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FilterReadDto<EquipmentInAreaRequestReadDto>>))]
        [HttpPost("EquipmentRequestIn/Inbox")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> GetCreatorEquipmentInRequestFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetCreatorEquipmentInRequestsFiltered from {nameof(RequestController)} with filter: {JsonSerializer.Serialize(filterDto)}");
            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            string? userCondition = null;

            (int TotalCount, IEnumerable<EquipmentRequestIn> PaginatedData) result;

            userCondition = "Request.CreatorId ==@0";

            if (!string.IsNullOrEmpty(filterDto?.FilterValue))
            {
                result = await _unitOfWork.Repository<EquipmentRequestIn>().FindAllRequestsAsync(
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
                result = await _unitOfWork.Repository<EquipmentRequestIn>().FindAllRequestsAsync(
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

            var requests = _mapper.Map<List<EquipmentInAreaRequestReadDto>>(result.PaginatedData);

            var response = new FilterReadDto<EquipmentInAreaRequestReadDto>
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = filterDto?.PageNo ?? 1,
                PageSize = requests.Count,
                PaginatedData = requests
            };
            return Ok(new ApiResponse<FilterReadDto<EquipmentInAreaRequestReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = response });
        }

        /// <summary>
        /// Get All Equipment Request (In Concession Area) By Reviewer With Filter
        /// </summary>
        /// <param name="filterDto">filter information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of All Reviewer Equipment Request (In Concession Area)</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FilterReadDto<EquipmentInAreaRequestReviewerReadDto>>))]
        [HttpPost("EquipmentRequestIn/AssignedToMe")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> GetReviewerEquipmentInRequestFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetReviewerEquipmentInRequestFiltered from {nameof(RequestController)} with filter: {JsonSerializer.Serialize(filterDto)}");
            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            string? userCondition = null;

            (int TotalCount, IEnumerable<EquipmentRequestIn> PaginatedData) result;

            userCondition = "Request.RequestReviewers.Any(AssignedReviewerId == @0 && Request.CurrentStage >= StageNumber)";



            if (!string.IsNullOrEmpty(filterDto?.FilterValue))
            {
                result = await _unitOfWork.Repository<EquipmentRequestIn>().FindAllRequestsAsync(
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
                result = await _unitOfWork.Repository<EquipmentRequestIn>().FindAllRequestsAsync(
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

            var requests = _mapper.Map<List<EquipmentInAreaRequestReviewerReadDto>>(result.PaginatedData);

            foreach (var request in requests)
            {
                var reviewer = request.RequestReviewers?.OrderBy(r => r.StageNumber).LastOrDefault(y => y.AssignedReviewerId == User.FindFirstValue(ClaimTypes.NameIdentifier) && y.Status != RequestStatus.None);

                request.ReviewerStatus = reviewer?.Status;
                request.ReviewerStage = reviewer?.StageNumber;
            }


            var response = new FilterReadDto<EquipmentInAreaRequestReviewerReadDto>
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = filterDto?.PageNo ?? 1,
                PageSize = requests.Count,
                PaginatedData = requests
            };
            return Ok(new ApiResponse<FilterReadDto<EquipmentInAreaRequestReviewerReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = response });
        }

        /// <summary>
        /// Create Equipment Request (In Concession Area)
        /// </summary>
        /// <param name="equipmentInAreaRequestCreateDto">Equipment Request (In Concession Area) Informarion</param>    
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPost("EquipmentRequestIn/Create")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> CreateEquipmentInRequest(EquipmentInAreaRequestCreateDto equipmentInAreaRequestCreateDto)
        {

            _logger.LogInformation($"Start CreateEquipmentInRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(equipmentInAreaRequestCreateDto)} ");
            var ConcernedEmployee = await _userManager.Users.Include(t => t.Department).FirstOrDefaultAsync(u => u.Id == equipmentInAreaRequestCreateDto.ConcernedEmployeeId);

            if (ConcernedEmployee is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $" user '{equipmentInAreaRequestCreateDto.ConcernedEmployeeId}' not found" });


            var requestId = long.Parse(DateTime.Now.ToString("yyyyMMddhhmmssff"));
            var requestNo = $"EquipmentRequestIn-{DateTime.Now.ToString("yyyyMMddhhmmss")}";
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            

            var request = new Models.Request { Id = requestId, DefinedRequestId = equipmentInAreaRequestCreateDto.DefinedRequestId };
    
            request.EquipmentRequestIn = _mapper.Map<EquipmentRequestIn>(equipmentInAreaRequestCreateDto);
            request.EquipmentRequestIn.RequestNumber = requestNo;
            request.CreatorId = user?.Id;
            request.EquipmentRequestIn.CreatedBy = user?.FullName;
            request.CreatedBy = user?.FullName;
            request.EquipmentRequestIn.CreatedBy = user?.FullName;

            _unitOfWork.Repository<Models.Request>().Add(request);

            var result = _unitOfWork.Complete();

            await _requestReviewerRepository.BeginRequestCycle(equipmentInAreaRequestCreateDto.DefinedRequestId, requestId, user.Id, true);

            if (result < 1)
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "Adding new request has been failed" });

            #region Send Emails

            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {user.FullName.Split(" ")[0]},
                    Kindly not that your Equipment Request (In Concession  Area) on eDocuement has been created successfully and it's under reviewing now.
                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with your request Status.

                    - eDocument Request Reference No.: {requestNo}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"Equipment Request (In Concession  Area) No. {requestNo} on eDocuement",
                To = user.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            var reviewersEmails = await _requestReviewerRepository.GetAllRequestReviewersEmailsByStageNumberAsync(requestId, request.CurrentStage);
            var reviewerMailContent = new MailContent
            {
                Body = $"""
                Dears,
                    Kindly note that {user.FullName} has created Equipment Request (In Concession  Area)  for on eDocuement and need to be reviewed from your side.

                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                    - eDocument Request Reference No.: {requestNo}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                """,
                IsHTMLBody = false,
                Subject = $"Equipment Request (In Concession  Area) No. {requestNo} on eDocuement",
                To = reviewersEmails
            };

            _mailService.SendMailAsync(reviewerMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Request has been created successfully - Request No. {requestNo}" });
        }

        /// <summary>
        /// Update Equipment Request (In Concession Area)
        /// </summary>
        /// <param name="id">Equipment Request (In Concession Area)  Id</param>
        /// <param name="equipmentInAreaRequestUpdateDto">Equipment Request (In Concession Area)  Informarion</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("EquipmentRequestIn/Update/{id}")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> UpdateEquipmentInRequest(long id, EquipmentInAreaRequestUpdateDto equipmentInAreaRequestUpdateDto)
        {
            _logger.LogInformation($"Start UpdateEquipmentInRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(equipmentInAreaRequestUpdateDto)} ");

            var ConcernedEmployee = await _userManager.Users.Include(t => t.Department).FirstOrDefaultAsync(u => u.Id == equipmentInAreaRequestUpdateDto.ConcernedEmployeeId);

            if (ConcernedEmployee is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $" user '{equipmentInAreaRequestUpdateDto.ConcernedEmployeeId}' not found" });

            var user = await _userManager.Users.Include(t => t.Department).FirstOrDefaultAsync(u => u.Id == User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == id);


            var request = await _unitOfWork.Repository<Request>().FindAsync(requestRxpression, new string[] { "EquipmentRequestIn", "Attachments" });

            if (request == null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"Request not found" });


            _mapper.Map(equipmentInAreaRequestUpdateDto, request);
            _mapper.Map(equipmentInAreaRequestUpdateDto, request.EquipmentRequestIn);
            request.EquipmentRequestIn.RequestId = id;
            request.EquipmentRequestIn.ModifiedAt = DateTime.Now;
            request.EquipmentRequestIn.ModifiedBy = user?.FullName;
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
                    Kindly not that your Equipment Request (In Concession Area)  on eDocuement has been updated successfully and it's under reviewing now.
                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with your request Status.

                    - eDocument Request Reference No.: {request.EquipmentRequestIn.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $" Equipment Request (In Concession Area)  No. {request.EquipmentRequestIn.RequestNumber} on eDocuement",
                To = user.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            var reviewersEmails = await _requestReviewerRepository.GetAllRequestReviewersEmailsByStageNumberAsync(request.Id, request.CurrentStage);
            var reviewerMailContent = new MailContent
            {
                Body = $"""
                Dears,
                    Kindly note that {user.FullName} has updated Equipment Request (In Concession Area)  for on eDocuement and need to be reviewed from your side.

                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                    - eDocument Request Reference No.: {request.EquipmentRequestIn.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                """,
                IsHTMLBody = false,
                Subject = $" Equipment Request (In Concession Area)  No. {request.EquipmentRequestIn.RequestNumber} on eDocuement",
                To = reviewersEmails
            };

            _mailService.SendMailAsync(reviewerMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Request has been updated successfully" });
        }


        /// <summary>
        /// Approve Equipment Request (In Concession Area)
        /// </summary>
        /// <param name="requestReviewerWriteDto">Approve Equipment Request (In Concession Area)</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("EquipmentRequestIn/Approve")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> ApproveEquipmentInRequest(ApproveRequestReviewerDto requestReviewerWriteDto)
        {
            _logger.LogInformation($"Start ApproveEquipment-InRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(requestReviewerWriteDto)} ");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var result = await _requestReviewerRepository.ApproveRequestAsync(requestReviewerWriteDto, user);

            if (!result.IsSucceded)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = result.Message });

            #region Send Emails

            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == requestReviewerWriteDto.RequestId);
            var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "EquipmentRequestIn", "Creator" });
            var requestCreator = request.Creator;

            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {requestCreator.FullName.Split(" ")[0]},
                    Kindly not that your Equipment Request (In Concession Area) {request.EquipmentRequestIn.RequestNumber} on eDocuement has been approved successfully.
                    For more detail, please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}).

                    - eDocument Request Reference No.: {request.EquipmentRequestIn.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"Equipment Request (In Concession Area) No. {request.EquipmentRequestIn.RequestNumber} on eDocuement",
                To = requestCreator.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Your action has been recorded successfully" });
        }

        /// <summary>
        /// Decline Equipment Request (In Concession Area)
        /// </summary>
        /// <param name="requestReviewerWriteDto">Decline Equipment Request (In Concession Area)</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("EquipmentRequestIn/Decline")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> DeclineEquipmentInRequest(DeclineRequestReviewerDto requestReviewerWriteDto)
        {
            _logger.LogInformation($"Start DeclineEquipmentInRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(requestReviewerWriteDto)} ");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);


            var result = await _requestReviewerRepository.DeclineRequestAsync(requestReviewerWriteDto, user);
            if (!result.IsSucceded)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = result.Message });

            #region Send Emails

            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == requestReviewerWriteDto.RequestId);
            var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "EquipmentRequestIn", "Creator" });

            var requestCreator = request.Creator;
            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {requestCreator.FullName.Split(" ")[0]},
                    Kindly not that your Equipment Request (In Concession Area) No. {request.EquipmentRequestIn.RequestNumber} on eDocuement has been declined by {user.FullName}.
                    For more detail, please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}).

                    - eDocument Request Reference No.: {request.EquipmentRequestIn.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"Equipment Request (In Concession Area) No. {request.EquipmentRequestIn.RequestNumber} on eDocuement",
                To = requestCreator.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Your action has been recorded successfully" });
        }

        #endregion 

        #region Equipment Request - Out Concession Area 

        /// <summary>
        /// Get Equipment Request (Out Concession Area) Details
        /// </summary>
        /// <param name="id">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>Equipment Request (Out Concession Area)</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<EquipmentOutAreaRequestReadDto>))]
        [HttpGet("EquipmentRequestOut/{id}")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> GetEquipmentOutRequestById(long id)
        {
            _logger.LogInformation($"Start GetEquipmentOutRequestById from {nameof(RequestController)} for request id = {id}");

            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            var equipmentOutRequest = await _unitOfWork.Repository<EquipmentRequestOut>().FindRequestAsync(
            requestId: id,
            expression: "Request.Id==@0",
            includes: includes
            );

            if (equipmentOutRequest is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Request not found" });

            var result = _mapper.Map<EquipmentOutAreaRequestReadDto>(equipmentOutRequest);



            return Ok(new ApiResponse<EquipmentOutAreaRequestReadDto> { StatusCode = (int)HttpStatusCode.OK, Details = result });
        }

        /// <summary>
        /// Delete Equipment Request (Out Concession Area) By Id
        /// </summary>
        /// <param name="id">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpDelete("EquipmentRequestOut/{id}")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> DeleteEquipmentOutRequest(long id)
        {
            _logger.LogInformation($"Start DeleteEquipmentOutRequest from {nameof(RequestController)} for request id = {id}");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var includes = new string[] { "EquipmentRequestOut", "Attachments", "RequestReviewers" };

            var request = await _unitOfWork.Repository<Models.Request>().FindRequestAsync(
            requestId: id,
            expression: "Id==@0",
            includes: includes
                );

            if (request is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Request not found" });

            if (request.Status == RequestStatus.Approved.ToString() || request.Status == RequestStatus.Declined.ToString())
            {
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = $"You cannot delete this request after as it has been already {request.Status}" });

            }
            else if (request.RequestReviewers.Any(rr => rr.Status == RequestStatus.Approved.ToString()))
            {
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "You cannot delete the request after one of the reviewers took his action" });

            }

            request.EquipmentRequestOut.ModifiedBy = user?.FullName;
            request.ModifiedBy = user?.FullName;
            _unitOfWork.Complete();

            _unitOfWork.Repository<Models.Request>().Delete(request);
            _unitOfWork.Complete();

            _fileService.DeleteFolder($@"EquipmentRequestOut\{id}");

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = "Request deleted successfully" });
        }


        /// <summary>
        /// Get All Equipment Request (Out Concession Area) By Creator With Filter
        /// </summary>
        /// <param name="filterDto">filter information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of All Created Equipment Request Out Concession Area Requests</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FilterReadDto<EquipmentOutAreaRequestReadDto>>))]
        [HttpPost("EquipmentRequestOut/Inbox")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> GetCreatorEquipmentOutRequestFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetCreatorEquipmentOutRequestFiltered from {nameof(RequestController)} with filter: {JsonSerializer.Serialize(filterDto)}");
            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            string? userCondition = null;

            (int TotalCount, IEnumerable<EquipmentRequestOut> PaginatedData) result;

            userCondition = "Request.CreatorId ==@0";

            if (!string.IsNullOrEmpty(filterDto?.FilterValue))
            {
                result = await _unitOfWork.Repository<EquipmentRequestOut>().FindAllRequestsAsync(
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
                result = await _unitOfWork.Repository<EquipmentRequestOut>().FindAllRequestsAsync(
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

            var requests = _mapper.Map<List<EquipmentOutAreaRequestReadDto>>(result.PaginatedData);

            var response = new FilterReadDto<EquipmentOutAreaRequestReadDto>
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = filterDto?.PageNo ?? 1,
                PageSize = requests.Count,
                PaginatedData = requests
            };
            return Ok(new ApiResponse<FilterReadDto<EquipmentOutAreaRequestReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = response });
        }

        /// <summary>
        /// Get All Equipment Request (Out Concession Area)  By Reviewer With Filter
        /// </summary>
        /// <param name="filterDto">filter information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of All Reviewer Equipment Request Out Concession Area Requests</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FilterReadDto<EquipmentOutAreaRequestReviewerReadDto>>))]
        [HttpPost("EquipmentRequestOut/AssignedToMe")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> GetReviewerEquipmentOutRequestFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetReviewerEquipmentOutRequestFiltered from {nameof(RequestController)} with filter: {JsonSerializer.Serialize(filterDto)}");
            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            string? userCondition = null;

            (int TotalCount, IEnumerable<EquipmentRequestOut> PaginatedData) result;

            userCondition = "Request.RequestReviewers.Any(AssignedReviewerId == @0 && Request.CurrentStage >= StageNumber)";



            if (!string.IsNullOrEmpty(filterDto?.FilterValue))
            {
                result = await _unitOfWork.Repository<EquipmentRequestOut>().FindAllRequestsAsync(
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
                result = await _unitOfWork.Repository<EquipmentRequestOut>().FindAllRequestsAsync(
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

            var requests = _mapper.Map<List<EquipmentOutAreaRequestReviewerReadDto>>(result.PaginatedData);

            foreach (var request in requests)
            {
                var reviewer = request.RequestReviewers?.OrderBy(r => r.StageNumber).LastOrDefault(y => y.AssignedReviewerId == User.FindFirstValue(ClaimTypes.NameIdentifier) && y.Status != RequestStatus.None);

                request.ReviewerStatus = reviewer?.Status;
                request.ReviewerStage = reviewer?.StageNumber;
            }


            var response = new FilterReadDto<EquipmentOutAreaRequestReviewerReadDto>
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = filterDto?.PageNo ?? 1,
                PageSize = requests.Count,
                PaginatedData = requests
            };
            return Ok(new ApiResponse<FilterReadDto<EquipmentOutAreaRequestReviewerReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = response });
        }

        /// <summary>
        /// Create Equipment Request (Out Concession Area) 
        /// </summary>
        /// <param name="equipmentOutAreaRequestCreateDto">equipmentInArea request Informarion</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPost("EquipmentRequestOut/Create")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> CreateEquipmentOutRequest(EquipmentOutAreaRequestCreateDto equipmentOutAreaRequestCreateDto)
        {

            _logger.LogInformation($"Start CreateEquipmentOutRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(equipmentOutAreaRequestCreateDto)} ");
            var ConcernedEmployee = await _userManager.Users.Include(t => t.Department).FirstOrDefaultAsync(u => u.Id == equipmentOutAreaRequestCreateDto.ConcernedEmployeeId);

            if (ConcernedEmployee is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $" user '{equipmentOutAreaRequestCreateDto.ConcernedEmployeeId}' not found" });


            var requestId = long.Parse(DateTime.Now.ToString("yyyyMMddhhmmssff"));
            var requestNo = $"EquipmentRequestOut-{DateTime.Now.ToString("yyyyMMddhhmmss")}";
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);


            var request = new Models.Request { Id = requestId, DefinedRequestId = equipmentOutAreaRequestCreateDto.DefinedRequestId };

            request.EquipmentRequestOut = _mapper.Map<EquipmentRequestOut>(equipmentOutAreaRequestCreateDto);
            request.EquipmentRequestOut.RequestNumber = requestNo;



            request.CreatorId = user?.Id;
            request.EquipmentRequestOut.CreatedBy = user?.FullName;
            request.CreatedBy = user?.FullName;
            request.EquipmentRequestOut.CreatedBy = user?.FullName;

            _unitOfWork.Repository<Models.Request>().Add(request);

            var result = _unitOfWork.Complete();

            await _requestReviewerRepository.BeginRequestCycle(equipmentOutAreaRequestCreateDto.DefinedRequestId, requestId, user.Id, true);

            if (result < 1)
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "Adding new request has been failed" });

            #region Send Emails

            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {user.FullName.Split(" ")[0]},
                    Kindly not that your Equipment Request (Out Concession  Area) on eDocuement has been created successfully and it's under reviewing now.
                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with your request Status.

                    - eDocument Request Reference No.: {requestNo}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"Equipment Request (Out Concession  Area) No. {requestNo} on eDocuement",
                To = user.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            var reviewersEmails = await _requestReviewerRepository.GetAllRequestReviewersEmailsByStageNumberAsync(requestId, request.CurrentStage);
            var reviewerMailContent = new MailContent
            {
                Body = $"""
                Dears,
                    Kindly note that {user.FullName} has created Equipment Request (Out Concession  Area)  for on eDocuement and need to be reviewed from your side.

                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                    - eDocument Request Reference No.: {requestNo}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                """,
                IsHTMLBody = false,
                Subject = $"Equipment Request (Out Concession  Area) No. {requestNo} on eDocuement",
                To = reviewersEmails
            };

            _mailService.SendMailAsync(reviewerMailContent);

            #endregion Send Emails


            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Request has been created successfully - Request No. {requestNo}" });
        }

        /// <summary>
        /// Update Equipment Request (Out Concession Area) 
        /// </summary>
        /// <param name="id">Equipment Request (Out Concession Area)  Id</param>
        /// <param name="equipmentOutAreaRequestUpdateDto">Equipment Request (Out Concession Area)  Informarion</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("EquipmentRequestOut/Update/{id}")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> UpdateEquipmentOutRequest(long id, EquipmentOutAreaRequestUpdateDto equipmentOutAreaRequestUpdateDto)
        {
            _logger.LogInformation($"Start UpdateEquipmentOutRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(equipmentOutAreaRequestUpdateDto)} ");

            var ConcernedEmployee = await _userManager.Users.Include(t => t.Department).FirstOrDefaultAsync(u => u.Id == equipmentOutAreaRequestUpdateDto.ConcernedEmployeeId);

            if (ConcernedEmployee is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $" user '{equipmentOutAreaRequestUpdateDto.ConcernedEmployeeId}' not found" });

            var user = await _userManager.Users.Include(t => t.Department).FirstOrDefaultAsync(u => u.Id == User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == id);


            var request = await _unitOfWork.Repository<Request>().FindAsync(requestRxpression, new string[] { "EquipmentRequestOut", "Attachments" });

            if (request == null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"Request not found" });


            _mapper.Map(equipmentOutAreaRequestUpdateDto, request);
            _mapper.Map(equipmentOutAreaRequestUpdateDto, request.EquipmentRequestOut);
            request.EquipmentRequestOut.RequestId = id;
            request.EquipmentRequestOut.ModifiedAt = DateTime.Now;
            request.EquipmentRequestOut.ModifiedBy = user?.FullName;
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
                    Kindly not that your Equipment Request (Out Concession Area)  on eDocuement has been updated successfully and it's under reviewing now.
                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with your request Status.

                    - eDocument Request Reference No.: {request.EquipmentRequestOut.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $" Equipment Request (Out Concession Area)  No. {request.EquipmentRequestOut.RequestNumber} on eDocuement",
                To = user.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            var reviewersEmails = await _requestReviewerRepository.GetAllRequestReviewersEmailsByStageNumberAsync(request.Id, request.CurrentStage);
            var reviewerMailContent = new MailContent
            {
                Body = $"""
                Dears,
                    Kindly note that {user.FullName} has updated Equipment Request (Out Concession Area)  for on eDocuement and need to be reviewed from your side.

                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                    - eDocument Request Reference No.: {request.EquipmentRequestOut.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                """,
                IsHTMLBody = false,
                Subject = $" Equipment Request (Out Concession Area)  No. {request.EquipmentRequestOut.RequestNumber} on eDocuement",
                To = reviewersEmails
            };

            _mailService.SendMailAsync(reviewerMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Request has been updated successfully" });
        }


        /// <summary>
        /// Approve Equipment Request (Out Concession Area) 
        /// </summary>
        /// <param name="requestReviewerWriteDto">Approve Equipment Request (Out Concession Area) </param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("EquipmentRequestOut/Approve")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> ApproveEquipmentOutRequest(ApproveRequestReviewerDto requestReviewerWriteDto)
        {
            _logger.LogInformation($"Start ApproveEquipmentOutRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(requestReviewerWriteDto)} ");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var result = await _requestReviewerRepository.ApproveRequestAsync(requestReviewerWriteDto, user);

            if (!result.IsSucceded)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = result.Message });

            #region Send Emails

            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == requestReviewerWriteDto.RequestId);
            var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "EquipmentRequestOut", "Creator" });
            var requestCreator = request.Creator;

            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {requestCreator.FullName.Split(" ")[0]},
                    Kindly not that your Equipment Request (Out Concession Area) {request.EquipmentRequestOut.RequestNumber} on eDocuement has been approved successfully.
                    For more detail, please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}).

                    - eDocument Request Reference No.: {request.EquipmentRequestOut.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"Equipment Request (Out Concession Area) No. {request.EquipmentRequestOut.RequestNumber} on eDocuement",
                To = requestCreator.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Your action has been recorded successfully" });
        }

        /// <summary>
        /// Decline Equipment Request (Out Concession Area) 
        /// </summary>
        /// <param name="requestReviewerWriteDto">Decline Equipment Request (Out Concession Area) </param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("EquipmentRequestOut/Decline")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> DeclineEquipmentOutRequest(DeclineRequestReviewerDto requestReviewerWriteDto)
        {
            _logger.LogInformation($"Start DeclineEquipmentOutRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(requestReviewerWriteDto)} ");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);


            var result = await _requestReviewerRepository.DeclineRequestAsync(requestReviewerWriteDto, user);
            if (!result.IsSucceded)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = result.Message });

            #region Send Emails

            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == requestReviewerWriteDto.RequestId);
            var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "EquipmentRequestOut", "Creator" });

            var requestCreator = request.Creator;
            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {requestCreator.FullName.Split(" ")[0]},
                    Kindly not that your Equipment Request (Out Concession Area) No. {request.EquipmentRequestOut.RequestNumber} on eDocuement has been declined by {user.FullName}.
                    For more detail, please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}).

                    - eDocument Request Reference No.: {request.EquipmentRequestOut.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"Equipment Request (Out Concession Area) No. {request.EquipmentRequestOut.RequestNumber} on eDocuement",
                To = requestCreator.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Your action has been recorded successfully" });
        }

        #endregion 

        #endregion 

    }

     
}