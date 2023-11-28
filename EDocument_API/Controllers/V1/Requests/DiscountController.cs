using AutoMapper;
using EDocument_Data.Consts;
using EDocument_Data.Consts.Enums;
using EDocument_Data.DTOs.Attachments;
using EDocument_Data.DTOs.Filter;
using EDocument_Data.DTOs.Requests.DiscountRequest;
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
    public class DiscountController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private readonly ILogger<DiscountController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRequestReviewerRepository _requestReviewerRepository;
        private readonly IMailService _mailService;
        private readonly IFileService _fileService;

        public DiscountController(
            ILogger<DiscountController> logger,
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
        /// Get Discount Requests By for Edit Id
        /// </summary>
        /// <param name="id">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>Discount Request</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<DiscountRequestReadDto>))]
        [HttpGet("{id}")]
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
            result.HoSupportedDocument =  _mapper.Map<AttachmentReadDto>(discountRequest.HoSupportedDocumentPath);

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
        [HttpDelete("{id}")]
        [Authorize(Roles = "CustomerService,Commercial")]
        public async Task<ActionResult> DeleteDiscountRequest(long id)
        {
            _logger.LogInformation($"Start DeleteDiscountRequest from {nameof(RequestController)} for request id = {id}");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var includes = new string[] { "DiscountRequest", "Attachments", "RequestReviewers" };

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

            request.DiscountRequest.ModifiedBy = user?.FullName;
            request.ModifiedBy = user?.FullName;
            _unitOfWork.Complete();

            _unitOfWork.Repository<Request>().Delete(request);
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
        [HttpPost("Inbox")]
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
        [HttpPost("AssignedToMe")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> GetReviewerDiscountRequestsFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetReviewerDiscountRequestsFiltered from {nameof(RequestController)} with filter: {JsonSerializer.Serialize(filterDto)}");
            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            string? userCondition = null;

            (int TotalCount, IEnumerable<DiscountRequest> PaginatedData) result;

            userCondition = "Request.RequestReviewers.Any(AssignedReviewerId == @0 )";

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
                var reviewer = request.RequestReviewers?.OrderBy(r => r.StageNumber).FirstOrDefault(y => y.AssignedReviewerId == User.FindFirstValue(ClaimTypes.NameIdentifier));

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
        /// <param name="discountRequestCreateDto">Discount request Information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [Consumes("multipart/form-data")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPost("Create")]
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

            var request = new Request { Id = requestId, DefinedRequestId = discountRequestCreateDto.DefinedRequestId };
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

            _unitOfWork.Repository<Request>().Add(request);

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
        /// <param name="discountRequestUpdateDto">Discount request Information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [Consumes("multipart/form-data")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("Update/{id}")]
        [Authorize(Roles = "CustomerService,Commercial")]
        public async Task<ActionResult> UpdateDiscountRequest(long id, [FromForm] DiscountRequestUpdateDto discountRequestUpdateDto)
        {
            _logger.LogInformation($"Start UpdateDiscountRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(discountRequestUpdateDto)} ");

            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == id);

            var request = await _unitOfWork.Repository<Request>().FindAsync(requestRxpression, new string[] { "DiscountRequest", "RequestReviewers", "Attachments" });

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

                request.Attachments = _fileService.UploadAttachments(request.Id, $@"DiscountRequest\{request.Id}", discountRequestUpdateDto.Attachments, createdBy: request.CreatedBy, modifiedBy: user.FullName, modifiedAt: DateTime.Now);
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
        [HttpPut("Approve")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> ApproveDiscountRequest(ApproveDiscountRequestDto requestReviewerWriteDto)
        {
            _logger.LogInformation($"Start ApproveDiscountRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(requestReviewerWriteDto)} ");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == requestReviewerWriteDto.RequestId);
            var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "DiscountRequest", "Creator", "Creator.Department", "Creator.Department.Manager" });

            if (request != null)
            {
               if(request.CurrentStage == 2)
                {
                    if (request.DiscountRequest.DiscountAmount >= 3000 && requestReviewerWriteDto.HoSupportedDocument == null)
                    {
                        return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "Ho Supported Document Should Be Uploaded If Discount Amount >=3000" });

                    }
                    else if ( requestReviewerWriteDto.HoSupportedDocument != null) //Check if the current reviewer is Finance Team
                    {
                        request.DiscountRequest.HoSupportedDocumentPath = _fileService.UploadAttachment($@"DiscountRequest\{requestReviewerWriteDto.RequestId}", requestReviewerWriteDto.HoSupportedDocument);
                        request.DiscountRequest.ModifiedBy = user?.FullName;
                    }

                }
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
        [HttpPut("Decline")]
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


    }
}
