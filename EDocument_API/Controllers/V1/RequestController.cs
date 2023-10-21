using AutoMapper;
using EDocument_Services.File_Service;
using EDocument_Data.Consts.Enums;
using EDocument_Data.DTOs.Filter;
using EDocument_Data.DTOs.Requests.PoRequest;
using EDocument_Data.DTOs.Requests.RequestReviewer;
using EDocument_Data.Models;
using EDocument_Data.Models.Shared;
using EDocument_Repositories.Application_Repositories.Request_Reviewer_Repository;
using EDocument_UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using System.Net;
using System.Net.Mime;
using System.Security.Claims;
using System.Text.Json;
using Models = EDocument_Data.Models;
using EDocument_Data.DTOs.Attachments;
using EDocument_Services.Mail_Service;
using EDocument_Data.DTOs.Requests.VehicleRequest;
using EDocument_Data.DTOs.Requests.TravelDeskRequest;
using Microsoft.EntityFrameworkCore;
using EDocument_Data.DTOs.Requests.RefundRequest;
using EDocument_Data.Consts;
using EDocument_Data.DTOs.DefinedRequest;
using EDocument_Data.DTOs.Requests.DiscountRequest;
using EDocument_Data.DTOs.Requests;
using Humanizer;

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

           
            Expression<Func<Request, bool>> allRequestsExpression = (r => r.CreatorId==user.Id);
            var createdRequests = await _unitOfWork.Repository<Request>().FindAllAsync(allRequestsExpression, new string[] { "DefinedRequest" });

            var response = new RequestDashboardReadDto();

            response.CreatedRequests = createdRequests.Count();
            response.PendingRequests = createdRequests.Count(r=>r.Status==RequestStatus.Pending.ToString());
            response.ApprovedRequests = createdRequests.Count(r => r.Status == RequestStatus.Approved.ToString());
            response.DeclinedRequests = createdRequests.Count(r => r.Status == RequestStatus.Declined.ToString());
           var recentCreatedRequests= _mapper.Map<List<RecentRequestReadDto>>(createdRequests);

            foreach (var request in recentCreatedRequests)
            {
                request.UserRole = "Creator";
            }

            Expression<Func<Request, bool>> reviewingRequestsExpression = (r => r.RequestReviewers.Any(rr => rr.AssignedReviewerId == user.Id&&r.CurrentStage==rr.StageNumber));
            var reviewingRequests = await _unitOfWork.Repository<Request>().FindAllAsync(reviewingRequestsExpression, new string[] { "RequestReviewers" });

            var recentReviewingRequests = _mapper.Map<List<RecentRequestReadDto>>(reviewingRequests);

            foreach (var request in recentReviewingRequests)
            {
                request.UserRole = "Reviewer";
            }
            var recentRequests = new List<RecentRequestReadDto>();
            recentRequests.AddRange(recentCreatedRequests);
            recentRequests.AddRange(recentReviewingRequests);
            response.RecentRequests = recentRequests;
            response.RecentRequests=response.RecentRequests.OrderByDescending(r => r.CreatedAt).Take(10).ToList();

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
            result.InvoiceAttachment= _mapper.Map<AttachmentReadDto>(poRequest.InvoiceAttachmentPath);
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

            if (request.Status == RequestStatus.Approved.ToString()|| request.Status==RequestStatus.Declined.ToString())
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
                isCreator:false,
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

            await _requestReviewerRepository.BeginRequestCycle(poRequestCreateDto.DefinedRequestId, requestId, true);
            if (result < 1) BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "Adding new request has been failed" });


            #region Send Emails
            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {user.FullName.Split(" ")[0]},
                    Kindly not that your Po Request  for PO Number {request.PoRequest.PoNumber} on eDocuement has been created successfully and it's under reviewing now.
                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with you request Status. 

                    - eDocument Request Reference No.: {requestNo}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"PO Request for {request.PoRequest.PoNumber} on eDocuement",
                To = "mostafa.reyad@dpworld.com;alaa.muhammad@dpworld.com;"
                // To = user.Email
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
                To = "mostafa.reyad@dpworld.com;alaa.muhammad@dpworld.com;"
                // To = reviewersEmails
            };

            _mailService.SendMailAsync(reviewerMailContent);

            #endregion

 

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
        public async Task<ActionResult> UpdatePoRequest(long id, [FromForm]PoRequestUpdateDto poRequestUpdateDto)
        {
            _logger.LogInformation($"Start UpdatePoRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(poRequestUpdateDto)} ");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            Expression<Func<Models.Request, bool>> requestRxpression = (r => r.Id == id);

 
            var request = await _unitOfWork.Repository<Models.Request>().FindAsync(requestRxpression, new string[] { "PoRequest" ,"Attachments"});

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



            if (poRequestUpdateDto.Attachments==null || poRequestUpdateDto.Attachments.Count==0)
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

                request.Attachments = _fileService.UploadAttachments(request.Id, $@"PoRequest\{request.Id}", poRequestUpdateDto.Attachments, user.FullName);
            }



            request.PoRequest.ModifiedAt = DateTime.Now;
            request.PoRequest.ModifiedBy = user?.FullName;
            request.ModifiedBy = user?.FullName;

            var result = _unitOfWork.Complete();

            await _requestReviewerRepository.BeginRequestCycle( request.DefinedRequestId,request.Id, false);

            if (result < 1) BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "Request update has been failed" });


            #region Send Emails
            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {user.FullName.Split(" ")[0]},
                    Kindly not that your Po Request  for PO Number {request.PoRequest.PoNumber} on eDocuement has been created successfully and it's under reviewing now.
                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with you request Status. 

                    - eDocument Request Reference No.: {request.PoRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"PO Request for {request.PoRequest.PoNumber} on eDocuement",
                To = "mostafa.reyad@dpworld.com;alaa.muhammad@dpworld.com;"
                //To = user.Email
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
                To = "mostafa.reyad@dpworld.com;alaa.muhammad@dpworld.com;"
                //To = reviewersEmails
            };

            _mailService.SendMailAsync(reviewerMailContent);

            #endregion

          

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

            await _requestReviewerRepository.ApproveRequestAsync(requestReviewerWriteDto, user!.FullName);

            #region Send Emails


            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == requestReviewerWriteDto.RequestId);
            var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "PoRequest", "Creator", "Creator.Department", "Creator.Department.Manager" });


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
               // Cc = $"{requestCreatorDirectManager.Email};{requestCreatorDepartmentManager.Email}",
                //To = requestCreator.Email,
                Cc = "mostafa.reyad@dpworld.com;alaa.muhammad@dpworld.com;",
                To = "mostafa.reyad@dpworld.com;alaa.muhammad@dpworld.com;"
            };

            _mailService.SendMailAsync(creatorMailContent);
            #endregion



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


            await _requestReviewerRepository.DeclineRequestAsync(requestReviewerWriteDto, user!.FullName);

            #region Send Emails


            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == requestReviewerWriteDto.RequestId);
            var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "PoRequest", "Creator", "Creator.Department", "Creator.Department.Manager" });


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
               // Cc = $"{requestCreatorDirectManager.Email};{requestCreatorDepartmentManager.Email}",
                //To = requestCreator.Email
                Cc = "mostafa.reyad@dpworld.com;alaa.muhammad@dpworld.com;",
                To = "mostafa.reyad@dpworld.com;alaa.muhammad@dpworld.com;"
            };

            _mailService.SendMailAsync(creatorMailContent);
            #endregion


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
                isCreator:true,
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
                var reviewer = request.RequestReviewers?.OrderBy(r=>r.StageNumber).LastOrDefault(y => y.AssignedReviewerId == User.FindFirstValue(ClaimTypes.NameIdentifier) && y.Status != RequestStatus.None);

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

            await _requestReviewerRepository.BeginRequestCycle(vehicleRequestCreateDto.DefinedRequestId, requestId, true);
            if (result < 1) 
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "Adding new request has been failed" });


            #region Send Emails
            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {user.FullName.Split(" ")[0]},
                    Kindly not that your Vehicle Request on eDocuement has been created successfully and it's under reviewing now.
                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with you request Status. 

                    - eDocument Request Reference No.: {requestNo}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"Vehicle Request No. {requestNo} on eDocuement",
                //To = user.Email
                To = "mostafa.reyad@dpworld.com;alaa.muhammad@dpworld.com;"
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
                // To = reviewersEmails
                To = "mostafa.reyad@dpworld.com;alaa.muhammad@dpworld.com;"
            };

            _mailService.SendMailAsync(reviewerMailContent);

            #endregion



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

                request.Attachments = _fileService.UploadAttachments(request.Id, $@"VehicleRequest\{request.Id}", vehicleRequestUpdateDto.Attachments, user.FullName);
            }



            request.VehicleRequest.ModifiedAt = DateTime.Now;
            request.VehicleRequest.ModifiedBy = user?.FullName;
            request.ModifiedBy = user?.FullName;

            var result = _unitOfWork.Complete();

            await _requestReviewerRepository.BeginRequestCycle(request.DefinedRequestId, request.Id, false);

            if (result < 1) 
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "Request update has been failed" });


            #region Send Emails
            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {user.FullName.Split(" ")[0]},
                    Kindly not that your Vehicle Request on eDocuement has been created successfully and it's under reviewing now.
                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with you request Status. 

                    - eDocument Request Reference No.: {request.VehicleRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"Vehicle Request No. {request.VehicleRequest.RequestNumber} on eDocuement",
                // To = user.Email
                To = "mostafa.reyad@dpworld.com;alaa.muhammad@dpworld.com;"
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
                //To = reviewersEmails
                To = "mostafa.reyad@dpworld.com;alaa.muhammad@dpworld.com;"
            };

            _mailService.SendMailAsync(reviewerMailContent);

            #endregion

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

            await _requestReviewerRepository.ApproveRequestAsync(requestReviewerWriteDto, user!.FullName);

            #region Send Emails
            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == requestReviewerWriteDto.RequestId);
            var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "VehicleRequest", "Creator"});
            if (request?.Status == RequestStatus.Approved.ToString())
            {
                var requestCreator = request.Creator;
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
                    // To = requestCreator.Email
                    To = "mostafa.reyad@dpworld.com;alaa.muhammad@dpworld.com;"
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
                        Kindly note that {user.FullName} has created Vehicle Request for on eDocuement and need to be reviewed from your side.

                        Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details. 

                        - eDocument Request Reference No.: {request.VehicleRequest.RequestNumber}

                    Thanks,

                    “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                    """,
                    IsHTMLBody = false,
                    Subject = $"Vehicle Request No. {request.VehicleRequest.RequestNumber} on eDocuement",
                    // To = reviewersEmails
                    To = "mostafa.reyad@dpworld.com;alaa.muhammad@dpworld.com;"

                };

                _mailService.SendMailAsync(reviewerMailContent);
            }




            #endregion

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


            await _requestReviewerRepository.DeclineRequestAsync(requestReviewerWriteDto, user!.FullName);

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
                //To = requestCreator.Email
                To = "mostafa.reyad@dpworld.com;alaa.muhammad@dpworld.com;"
            };

            _mailService.SendMailAsync(creatorMailContent);
            #endregion

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
                isCreator:false,
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

            await _requestReviewerRepository.BeginRequestCycle(travelDeskRequestCreateDto.DefinedRequestId, requestId, true);

            if (result < 1) 
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "Adding new request has been failed" });


            #region Send Emails
            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {user.FullName.Split(" ")[0]},
                    Kindly not that your TravelDesk Request on eDocuement has been created successfully and it's under reviewing now.
                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with you request Status. 

                    - eDocument Request Reference No.: {requestNo}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"TravelDesk Request No. {requestNo} on eDocuement",
                //To = user.Email
                To = "mostafa.reyad@dpworld.com;alaa.muhammad@dpworld.com;"
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
                //  To = reviewersEmails
                To = "mostafa.reyad@dpworld.com;alaa.muhammad@dpworld.com;"
            };

            _mailService.SendMailAsync(reviewerMailContent);

            #endregion

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

                request.Attachments = _fileService.UploadAttachments(request.Id, $@"TravelDeskRequest\{request.Id}", travelDeskRequestUpdateDto.Attachments, user.FullName);
            }



            request.TravelDeskRequest.ModifiedAt = DateTime.Now;
            request.TravelDeskRequest.ModifiedBy = user?.FullName;
            request.ModifiedBy = user?.FullName;

            var result = _unitOfWork.Complete();

            await _requestReviewerRepository.BeginRequestCycle(request.DefinedRequestId, request.Id, false);

            if (result < 1) 
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "Request update has been failed" });


            #region Send Emails
            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {user.FullName.Split(" ")[0]},
                    Kindly not that your TravelDesk Request on eDocuement has been created successfully and it's under reviewing now.
                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with you request Status. 

                    - eDocument Request Reference No.: {request.TravelDeskRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"TravelDesk Request No. {request.TravelDeskRequest.RequestNumber} on eDocuement",
                //To = user.Email
                To = "mostafa.reyad@dpworld.com;alaa.muhammad@dpworld.com;"
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
                // To = reviewersEmails
                To = "mostafa.reyad@dpworld.com;alaa.muhammad@dpworld.com;"
            };

            _mailService.SendMailAsync(reviewerMailContent);

            #endregion

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

            await _requestReviewerRepository.ApproveRequestAsync(requestReviewerWriteDto, user!.FullName);

            #region Send Emails
            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == requestReviewerWriteDto.RequestId);
            var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "TravelDeskRequest", "Creator", "Creator.Department", "Creator.Department.Manager" });
            if (request?.Status == RequestStatus.Approved.ToString())
            {
                var requestCreator = request.Creator;
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
                   // To = requestCreator.Email
                    To = "mostafa.reyad@dpworld.com;alaa.muhammad@dpworld.com;"
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
                        Kindly note that {user.FullName} has created TravelDesk Request for on eDocuement and need to be reviewed from your side.

                        Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details. 

                        - eDocument Request Reference No.: {request.TravelDeskRequest.RequestNumber}

                    Thanks,

                    “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                    """,
                    IsHTMLBody = false,
                    Subject = $"TravelDesk Request No. {request.TravelDeskRequest.RequestNumber} on eDocuement",
                    // To = reviewersEmails
                    To = "mostafa.reyad@dpworld.com;alaa.muhammad@dpworld.com;"
                };

                _mailService.SendMailAsync(reviewerMailContent);
            }




            #endregion

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


            await _requestReviewerRepository.DeclineRequestAsync(requestReviewerWriteDto, user!.FullName);

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
                //To = requestCreator.Email
                To = "mostafa.reyad@dpworld.com;alaa.muhammad@dpworld.com;"
            };

            _mailService.SendMailAsync(creatorMailContent);
            #endregion

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
        [Authorize(Roles ="CustomerService")]
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
                isCreator:true,
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
                var reviewer = request.RequestReviewers?.FirstOrDefault(y => y.AssignedReviewerId == User.FindFirstValue(ClaimTypes.NameIdentifier) && y.Status == RequestStatus.Pending);

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

            await _requestReviewerRepository.BeginRequestCycle(refundRequestCreateDto.DefinedRequestId, requestId, true);

            await _requestReviewerRepository.NominateReviewer( requestId, refundRequestCreateDto.ConcernedEmployeeId, user?.FullName);

            if (result < 1)
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "Adding new request has been failed" });


            #region Send Emails
            //var creatorMailContent = new MailContent
            //{
            //    Body = $"""
            //    Dear {user.FullName.Split(" ")[0]},
            //        Kindly not that your Refund Request on eDocuement has been created successfully and it's under reviewing now.
            //        Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with you request Status. 

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

            #endregion

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

                request.Attachments = _fileService.UploadAttachments(request.Id, $@"RefundRequest\{request.Id}", refundRequestUpdateDto.Attachments, user.FullName);
            }



            request.RefundRequest.ModifiedAt = DateTime.Now;
            request.RefundRequest.ModifiedBy = user?.FullName;
            request.ModifiedBy = user?.FullName;

            var result = _unitOfWork.Complete();
            await _requestReviewerRepository.BeginRequestCycle(request.DefinedRequestId, request.Id, false);
            await _requestReviewerRepository.NominateReviewer(request.Id, refundRequestUpdateDto.ConcernedEmployeeId, user?.FullName);

            if (result < 1)
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "Request update has been failed" });


            #region Send Emails
            //var creatorMailContent = new MailContent
            //{
            //    Body = $"""
            //    Dear {user.FullName.Split(" ")[0]},
            //        Kindly not that your Refund Request on eDocuement has been created successfully and it's under reviewing now.
            //        Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with you request Status. 

            //        - eDocument Request Reference No.: {requestNo}

            //    Thanks,

            //    “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

            //    """,
            //    IsHTMLBody = false,
            //    Subject = $"Refund Request No. {requestNo} on eDocuement",
            //    To = $"{user.Email};DPWSokhna.CustomerService@dpworld.com;"
            //};

            //_mailService.SendMailAsync(creatorMailContent);



            //var reviewersEmails = await _requestReviewerRepository.GetAllRequestReviewersEmailsByStageNumberAsync(requestId,request.CurrentStage);
            //var reviewerMailContent =  new MailContent
            //{
            //    Body = $"""
            //    Dears,
            //        Kindly note that {user.FullName} has updated Refund Request for on eDocuement and need to be reviewed from your side.

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

            #endregion

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

            if (request!=null && request?.CurrentStage==2)
            {
                request.RefundRequest.CreditNote = approveRefundRequestDto.CreditNote;
                request.RefundRequest.Amount = approveRefundRequestDto.Amount;

                request.ModifiedBy = user?.FullName;
                request.RefundRequest.ModifiedBy = user?.FullName;
            }
            await _requestReviewerRepository.ApproveRequestAsync(_mapper.Map<ApproveRequestReviewerDto>(approveRefundRequestDto), user!.FullName);

            #region Send Emails

            //if (request?.Status==RequestStatus.Approved.ToString())
            //{
            //    var requestCreator = request.Creator;
            //    var requestCreatorDepartmentManager = request.Creator.Department.Manager;
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
            //            Kindly note that {user.FullName} has created Refund Request for on eDocuement and need to be reviewed from your side.

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

            #endregion

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


            await _requestReviewerRepository.DeclineRequestAsync(requestReviewerWriteDto, user!.FullName);

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
            #endregion

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
                isCreator:false,
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
                var reviewer = request.RequestReviewers?.FirstOrDefault(y => y.AssignedReviewerId == User.FindFirstValue(ClaimTypes.NameIdentifier) && y.Status == RequestStatus.Pending);

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
            else if (discountRequestCreateDto.InvoiceNumber!=null)
            {
                Expression<Func<DiscountRequest,bool>> invoiceNumberCriteria = (r=>r.InvoiceNumber==discountRequestCreateDto.InvoiceNumber);
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

            await _requestReviewerRepository.BeginRequestCycle(discountRequestCreateDto.DefinedRequestId, requestId, true);



            if (result < 1)
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "Adding new request has been failed" });


            #region Send Emails
            //var creatorMailContent = new MailContent
            //{
            //    Body = $"""
            //    Dear {user.FullName.Split(" ")[0]},
            //        Kindly not that your Discount Request on eDocuement has been created successfully and it's under reviewing now.
            //        Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with you request Status. 

            //        - eDocument Request Reference No.: {requestNo}

            //    Thanks,

            //    “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

            //    """,
            //    IsHTMLBody = false,
            //    Subject = $"Discount Request No. {requestNo} on eDocuement",
            //
            //    To = $"{user.Email};DPWSokhna.CustomerService@dpworld.com;DPWSokhna.Commercial@dpworld.com;"
            //};

            //_mailService.SendMailAsync(creatorMailContent);



            //var reviewersEmails = await _requestReviewerRepository.GetAllRequestReviewersEmailsByStageNumberAsync(requestId,request.CurrentStage);
            //var reviewerMailContent =  new MailContent
            //{
            //    Body = $"""
            //    Dears,
            //        Kindly note that {user.FullName} has created Discount Request for on eDocuement and need to be reviewed from your side.

            //        Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details. 

            //        - eDocument Request Reference No.: {requestNo}

            //    Thanks,

            //    “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
            //    """,
            //    IsHTMLBody = false,
            //    Subject = $"Discount Request No. {requestNo} on eDocuement",
            //    To = reviewersEmails
            //};

            //_mailService.SendMailAsync(reviewerMailContent);

            #endregion

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

                request.Attachments = _fileService.UploadAttachments(request.Id, $@"DiscountRequest\{request.Id}", discountRequestUpdateDto.Attachments, user.FullName);
            }



            request.DiscountRequest.ModifiedAt = DateTime.Now;
            request.DiscountRequest.ModifiedBy = user?.FullName;
            request.ModifiedBy = user?.FullName;

            var result = _unitOfWork.Complete();
            await _requestReviewerRepository.BeginRequestCycle(request.DefinedRequestId, request.Id, false);
           
            if (result < 1)
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "Request update has been failed" });


            #region Send Emails
            //var creatorMailContent = new MailContent
            //{
            //    Body = $"""
            //    Dear {user.FullName.Split(" ")[0]},
            //        Kindly not that your Discount Request on eDocuement has been created successfully and it's under reviewing now.
            //        Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with you request Status. 

            //        - eDocument Request Reference No.: {requestNo}

            //    Thanks,

            //    “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

            //    """,
            //    IsHTMLBody = false,
            //    Subject = $"Discount Request No. {requestNo} on eDocuement",
            //    To = $"{user.Email};DPWSokhna.CustomerService@dpworld.com;DPWSokhna.Commercial@dpworld.com;"
            //};

            //_mailService.SendMailAsync(creatorMailContent);



            //var reviewersEmails = await _requestReviewerRepository.GetAllRequestReviewersEmailsByStageNumberAsync(requestId,request.CurrentStage);
            //var reviewerMailContent =  new MailContent
            //{
            //    Body = $"""
            //    Dears,
            //        Kindly note that {user.FullName} has updated Discount Request for on eDocuement and need to be reviewed from your side.

            //        Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details. 

            //        - eDocument Request Reference No.: {requestNo}

            //    Thanks,

            //    “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
            //    """,
            //    IsHTMLBody = false,
            //    Subject = $"Discount Request No. {requestNo} on eDocuement",
            //    To = reviewersEmails
            //};

            //_mailService.SendMailAsync(reviewerMailContent);

            #endregion

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

           
            await _requestReviewerRepository.ApproveRequestAsync(requestReviewerWriteDto, user!.FullName);

            #region Send Emails

            //if (request?.Status==RequestStatus.Approved.ToString())
            //{
            //    var requestCreator = request.Creator;
            //    var requestCreatorDepartmentManager = request.Creator.Department.Manager;
            //    var creatorMailContent = new MailContent
            //    {
            //        Body = $"""
            //    Dear {requestCreator.FullName.Split(" ")[0]},
            //        Kindly not that your Discount Request {request.DiscountRequest.RequestNumber} on eDocuement has been approved successfully.
            //        For more detail, please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}). 

            //        - eDocument Request Reference No.: {request.DiscountRequest.RequestNumber}

            //    Thanks,

            //    “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

            //    """,
            //        IsHTMLBody = false,
            //        Subject = $"Discount Request No. {request.DiscountRequest.RequestNumber} on eDocuement",
            //        To = $"{requestCreator.Email};DPWSokhna.CustomerService@dpworld.com;DPWSokhna.Commercial@dpworld.com;"
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
            //            Kindly note that {user.FullName} has created Discount Request for on eDocuement and need to be reviewed from your side.

            //            Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details. 

            //            - eDocument Request Reference No.: {request.DiscountRequest.RequestNumber}

            //        Thanks,

            //        “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
            //        """,
            //        IsHTMLBody = false,
            //        Subject = $"Discount Request No. {request.DiscountRequest.RequestNumber} on eDocuement",
            //        To = reviewersEmails
            //    };

            //    _mailService.SendMailAsync(reviewerMailContent);
            //}

            #endregion

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


            await _requestReviewerRepository.DeclineRequestAsync(requestReviewerWriteDto, user!.FullName);

            #region Send Emails


            //Expression<Func<Request, bool>> requestRxpression = (r => r.Id == requestReviewerWriteDto.RequestId);
            //var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "DiscountRequest", "Creator", "Creator.Department", "Creator.Department.Manager" });


            //var requestCreator = request.Creator;
            //var requestCreatorDepartmentManager = request.Creator.Department.Manager;
            //var creatorMailContent = new MailContent
            //{
            //    Body = $"""
            //    Dear {requestCreator.FullName.Split(" ")[0]},
            //        Kindly not that your Discount Request No. {request.DiscountRequest.RequestNumber} on eDocuement has been declined by {user.FullName}.
            //        For more detail, please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}). 

            //        - eDocument Request Reference No.: {request.DiscountRequest.RequestNumber}

            //    Thanks,

            //    “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

            //    """,
            //    IsHTMLBody = false,
            //    Subject = $"Discount Request No. {request.DiscountRequest.RequestNumber} on eDocuement",
            //    Cc = requestCreatorDepartmentManager.Email,
            //    To = $"{requestCreator.Email};DPWSokhna.CustomerService@dpworld.com;DPWSokhna.Commercial@dpworld.com;"
            //};

            //_mailService.SendMailAsync(creatorMailContent);
            #endregion

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Your action has been recorded successfully" });
        }
        #endregion

        #endregion Commercial


    }



}