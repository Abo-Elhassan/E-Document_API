using AutoMapper;
using EDocument_Services.File_Service;
using EDocument_Data.Consts.Enums;
using EDocument_Data.DTOs.Filter;
using EDocument_Data.DTOs.Requests.PoRequest;
using EDocument_Data.DTOs.Requests.RequestReviewer;
using EDocument_Data.Models;
using EDocument_Data.Models.Shared;
using EDocument_EF;
using EDocument_Repositories.Application_Repositories.Request_Reviewer_Repository;
using EDocument_UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32;
using System.Linq.Expressions;
using System.Net;
using System.Net.Mime;
using System.Security.Claims;
using System.Text.Json;

using Models = EDocument_Data.Models;
using EDocument_Data.DTOs.Attachments;
using EDocument_Services.Mail_Service;
using EDocument_Data.Consts;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Microsoft.EntityFrameworkCore;

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
        /// Get Request Reviewers Details
        /// </summary>
        /// <param name="id">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>Request Reviewers Details</returns>

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<ReviewersDetailsDto>))]
        [HttpGet("Reviewers/{id}")]
        [Authorize]
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
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "You cannot delete this request after as it has been already approved" });

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
                var reviewer = request.RequestReviewers?.FirstOrDefault(y => y.AssignedReviewerId == User.FindFirstValue(ClaimTypes.NameIdentifier));

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
        public async Task<ActionResult> Create([FromForm] PoRequestCreateDto poRequestCreateDto)
        {
            
            _logger.LogInformation($"Start Create from {nameof(RequestController)} for {JsonSerializer.Serialize(poRequestCreateDto)} ");
            var requestId = long.Parse(DateTime.Now.ToString("yyyyMMddhhmmssff"));

            var requestNo = $"PO-{DateTime.Now.ToString("yyyyMMddhhmmss")}";
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var request = new Models.Request { Id = requestId, DefinedRequestId = poRequestCreateDto.DefinedRequestId };

            request.Justification = poRequestCreateDto.Remarks;
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
            request.CurrentStage = 1;
            request.CreatedBy = user?.FullName;
            request.PoRequest.CreatedBy = user?.FullName;

            _unitOfWork.Repository<Models.Request>().Add(request);

            var result = _unitOfWork.Complete();

            await _requestReviewerRepository.BeginRequestCycle(poRequestCreateDto.DefinedRequestId, requestId);
            if (result < 1) BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "Adding new request has been failed" });


            #region Send Emails
            //var creatorMailContent = new MailContent
            //{
            //    Body = $"""
            //    Dear {user.FullName.Split(" ")[0]},
            //        Kindly not that your Po Request  for PO Number {request.PoRequest.PoNumber} on eDocuement has been created successfully and it's under reviewing now.
            //        Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with you request Status. 

            //        - eDocument Request Reference No.: {requestNo}

            //    Thanks,

            //    “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

            //    """,
            //    IsHTMLBody = false,
            //    Subject = $"PO Request for {request.PoRequest.PoNumber} on eDocuement",
            //    To = user.Email
            //};

            //_mailService.SendMailAsync(creatorMailContent);



            //var reviewersEmails = await _requestReviewerRepository.GetAllRequestReviewersEmailsByStageNumberAsync(requestId,request.CurrentStage);
            //var reviewerMailContent =  new MailContent
            //{
            //    Body = $"""
            //    Dears,
            //        Kindly note that {user.FullName} has created Po Request for PO Number ({request.PoRequest.PoNumber}) on eDocuement and need to be reviewed from your side.

            //        Request Details:

            //        - PO Number:       {request.PoRequest.PoNumber}
            //        - Invoice Number:  {request.PoRequest.InvoiceNumber}
            //        - Vendor Name:     {request.PoRequest.VendorName}
            //        - Vendor Number:   {request.PoRequest.VendorNumber}
            //        Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details. 

            //        - eDocument Request Reference No.: {requestNo}

            //    Thanks,

            //    “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
            //    """,
            //    IsHTMLBody = false,
            //    Subject = $"PO Request for {request.PoRequest.PoNumber} on eDocuement",
            //    To = reviewersEmails
            //};

            //_mailService.SendMailAsync(reviewerMailContent);

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
        public async Task<ActionResult> Update(long id, [FromForm]PoRequestUpdateDto poRequestUpdateDto)
        {
            _logger.LogInformation($"Start Update from {nameof(RequestController)} for {JsonSerializer.Serialize(poRequestUpdateDto)} ");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            Expression<Func<Models.Request, bool>> requestRxpression = (r => r.Id == id);

 
            var request = await _unitOfWork.Repository<Models.Request>().FindAsync(requestRxpression, new string[] { "PoRequest" ,"Attachments"});

            if (request == null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"Request not found" });

            if (request.Status != RequestStatus.Declined.ToString())
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = $"You cannot update request information during reviewing proccess" });

            var oldPoAttachmentPath = request.PoRequest.PoAttachmentPath;
            var oldInvoiceAtachmentPath = request.PoRequest.InvoiceAttachmentPath;
            var oldAttachments = request.Attachments;

            request.Justification = poRequestUpdateDto.Remarks;
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

            await _requestReviewerRepository.BeginRequestCycle( request.DefinedRequestId,request.Id);

            if (result < 1) BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "Request update has been failed" });


            #region Send Emails
            //var creatorMailContent = new MailContent
            //{
            //    Body = $"""
            //    Dear {user.FullName.Split(" ")[0]},
            //        Kindly not that your Po Request  for PO Number {request.PoRequest.PoNumber} on eDocuement has been created successfully and it's under reviewing now.
            //        Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with you request Status. 

            //        - eDocument Request Reference No.: {request.PoRequest.RequestNumber}

            //    Thanks,

            //    “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

            //    """,
            //    IsHTMLBody = false,
            //    Subject = $"PO Request for {request.PoRequest.PoNumber} on eDocuement",
            //    To = user.Email
            //};

            //_mailService.SendMailAsync(creatorMailContent);


            //var reviewersEmails = await _requestReviewerRepository.GetAllRequestReviewersEmailsByStageNumberAsync(id, request.CurrentStage);
            //var reviewerMailContent = new MailContent
            //{
            //    Body = $"""
            //    Dears,
            //        Kindly note that {user.FullName} has created Po Request for PO Number ({request.PoRequest.PoNumber}) on eDocuement and need to be reviewed from your side.

            //        Request Details:

            //        - PO Number:       {request.PoRequest.PoNumber}
            //        - Invoice Number:  {request.PoRequest.InvoiceNumber}
            //        - Vendor Name:     {request.PoRequest.VendorName}
            //        - Vendor Number:   {request.PoRequest.VendorNumber}
            //        Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details. 

            //        - eDocument Request Reference No.: {request.PoRequest.RequestNumber}

            //    Thanks,

            //    “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
            //    """,
            //    IsHTMLBody = false,
            //    Subject = $"PO Request for {request.PoRequest.PoNumber} on eDocuement",
            //    To = reviewersEmails
            //};

            //_mailService.SendMailAsync(reviewerMailContent);

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
        public async Task<ActionResult> ApprovePoRequest(RequestReviewerWriteDto requestReviewerWriteDto)
        {
            _logger.LogInformation($"Start Approve from {nameof(RequestController)} for {JsonSerializer.Serialize(requestReviewerWriteDto)} ");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            await _requestReviewerRepository.ApproveRequestAsync(requestReviewerWriteDto, user!.FullName);

            #region Send Emails

         
            //Expression<Func<Request, bool>> requestRxpression = (r => r.Id == requestReviewerWriteDto.RequestId);
            //var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "PoRequest", "Creator", "Creator.Department", "Creator.Department.Manager" });


            //var requestCreator = request.Creator;
            //var requestCreatorDirectManager = request.Creator.Manager;
            //var requestCreatorDepartmentManager = request.Creator.Department.Manager;
            //var creatorMailContent = new MailContent
            //{
            //    Body = $"""
            //    Dear {requestCreator.FullName.Split(" ")[0]},
            //        Kindly not that your Po Request for PO Number {request.PoRequest.PoNumber} on eDocuement has been approved successfully by {user.FullName}.
            //        For more detail, please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}). 

            //        - eDocument Request Reference No.: {request.PoRequest.RequestNumber}

            //    Thanks,

            //    “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

            //    """,
            //    IsHTMLBody = false,
            //    Subject = $"PO Request for {request.PoRequest.PoNumber} on eDocuement",
            //    Cc = $"{requestCreatorDirectManager.Email};{requestCreatorDepartmentManager.Email}",
            //    To = requestCreator.Email
            //};

            //_mailService.SendMailAsync(creatorMailContent);
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
        public async Task<ActionResult> DeclinePoRequest(RequestReviewerWriteDto requestReviewerWriteDto)
        {
            _logger.LogInformation($"Start Decline from {nameof(RequestController)} for {JsonSerializer.Serialize(requestReviewerWriteDto)} ");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);


            await _requestReviewerRepository.DeclineRequestAsync(requestReviewerWriteDto, user!.FullName);

            #region Send Emails


            //Expression<Func<Request, bool>> requestRxpression = (r => r.Id == requestReviewerWriteDto.RequestId);
            //var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "PoRequest", "Creator", "Creator.Department", "Creator.Department.Manager" });


            //var requestCreator = request.Creator;
            //var requestCreatorDirectManager = request.Creator.Manager;
            //var requestCreatorDepartmentManager = request.Creator.Department.Manager;
            //var creatorMailContent = new MailContent
            //{
            //    Body = $"""
            //    Dear {requestCreator.FullName.Split(" ")[0]},
            //        Kindly not that your Po Request for PO Number {request.PoRequest.PoNumber} on eDocuement has been declined by {user.FullName}.
            //        For more detail, please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}). 

            //        - eDocument Request Reference No.: {request.PoRequest.RequestNumber}

            //    Thanks,

            //    “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

            //    """,
            //    IsHTMLBody = false,
            //    Subject = $"PO Request for {request.PoRequest.PoNumber} on eDocuement",
            //    Cc = $"{requestCreatorDirectManager.Email};{requestCreatorDepartmentManager.Email}",
            //    To = requestCreator.Email
            //};

            //_mailService.SendMailAsync(creatorMailContent);
            #endregion

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Your action has been recorded successfully" });
        }

        #endregion PO Request

        #endregion Procurement







    }



}