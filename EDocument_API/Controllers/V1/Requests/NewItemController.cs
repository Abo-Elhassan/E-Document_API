using AutoMapper;
using EDocument_Data.Consts;
using EDocument_Data.Consts.Enums;
using EDocument_Data.DTOs.Attachments;
using EDocument_Data.DTOs.Filter;
using EDocument_Data.DTOs.Requests.NewItemRequest;
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
using Newtonsoft.Json;
using System.Linq.Expressions;
using System.Net;
using System.Net.Mime;
using System.Security.Claims;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

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
    public class NewItemController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private readonly ILogger<NewItemController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRequestReviewerRepository _requestReviewerRepository;
        private readonly IMailService _mailService;
        private readonly IFileService _fileService;

        public NewItemController(
            ILogger<NewItemController> logger,
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
        /// Get New Item Requests Details
        /// </summary>
        /// <param name="id">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>New Item Request</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<NewItemRequestReadDto>))]
        [HttpGet("{id}")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> GetNewItemRequestById(long id)
        {
            _logger.LogInformation($"Start GetNewItemRequestById from {nameof(RequestController)} for request id = {id}");

            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments", "Request.RequestedItems" };
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
        /// Get Requested Items By Id 
        /// </summary>
        /// <param name="requestId">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>Requested PRs</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<List<RequestedItemReadDto>>))]
        [HttpGet("RequestedItem/{requestId}")]
        [Authorize(Roles = "Store")]
        public async Task<ActionResult> GetRequestedItemsByRequestNumber(long requestId)
        {
            _logger.LogInformation($"Start GetRequestedItemsByRequestNumber from {nameof(RequestController)} for request id = {requestId}");

            Expression<Func<RequestedItem, bool>> criteria = (r => r.RequestId == requestId);

            var requestedItems = await _unitOfWork.Repository<RequestedItem>().FindAllAsync(criteria, null);

            if (requestedItems is null || !requestedItems.Any())
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Requested Items not found" });

            var result = _mapper.Map<List<RequestedItemReadDto>>(requestedItems);

            return Ok(new ApiResponse<List<RequestedItemReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = result });
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
        [HttpDelete("{id}")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> DeleteNewItemRequest(long id)
        {
            _logger.LogInformation($"Start DeleteNewItemRequest from {nameof(RequestController)} for request id = {id}");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var includes = new string[] { "NewItemRequest", "Attachments", "RequestReviewers" };

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

            request.NewItemRequest.ModifiedBy = user?.FullName;
            request.ModifiedBy = user?.FullName;
            _unitOfWork.Complete();

            _unitOfWork.Repository<Request>().Delete(request);
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
        [HttpPost("Inbox")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> GetCreatorNewItemRequestsFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetCreatorNewItemRequestsFiltered from {nameof(RequestController)} with filter: {JsonSerializer.Serialize(filterDto)}");
            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments", "Request.RequestedItems" };
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
        [HttpPost("AssignedToMe")]
        [Authorize(Roles = "Store")]
        public async Task<ActionResult> GetReviewerNewItemRequestsFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetReviewerNewItemRequestsFiltered from {nameof(RequestController)} with filter: {JsonSerializer.Serialize(filterDto)}");
            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments", "Request.RequestedItems" };
            string? userCondition = null;

            (int TotalCount, IEnumerable<NewItemRequest> PaginatedData) result;

            userCondition = "Request.RequestReviewers.Any(AssignedReviewerId == @0 )";

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
                var reviewer = request.RequestReviewers?.OrderBy(r => r.StageNumber).FirstOrDefault(y => y.AssignedReviewerId == User.FindFirstValue(ClaimTypes.NameIdentifier));

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
        [HttpPost("Create")]
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
                    item.RequestId = requestId;
                    item.CreatedAt = DateTime.Now;
                    item.CreatedBy = user?.FullName;
                    request.RequestedItems.Add(item);
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
        /// <param name="newItemRequestUpdateDto">New Item request Information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [Consumes("multipart/form-data")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("Update/{id}")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> UpdateNewItemRequest(long id, [FromForm] NewItemRequestUpdateDto newItemRequestUpdateDto)
        {
            _logger.LogInformation($"Start UpdateNewItemRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(newItemRequestUpdateDto)} ");

            var user = await _userManager.Users.Include(t => t.Department).FirstOrDefaultAsync(u => u.Id == User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == id);

            var request = await _unitOfWork.Repository<Request>().FindAsync(requestRxpression, new string[] { "NewItemRequest", "RequestReviewers", "Attachments", "RequestedItems" });

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

            var oldAttachments = request.Attachments;
            request.Notes = newItemRequestUpdateDto.Notes;
            _mapper.Map(newItemRequestUpdateDto, request.NewItemRequest);

            request.NewItemRequest.RequestId = id;
            var sentItems = Request.Form["RequestedItems"].ToList();


            if (sentItems != null && sentItems.Count > 0)
            {
                _unitOfWork.Repository<RequestedItem>().DeleteRange(request.RequestedItems);

                request.RequestedItems = new List<RequestedItem>();
                foreach (var sentItem in sentItems)
                {
                    var item = JsonConvert.DeserializeObject<RequestedItem>(sentItem);
                    item.RequestId = id;
                    item.CreatedAt = request.CreatedAt;
                    item.CreatedBy = request.CreatedBy;
                    item.ModifiedAt = DateTime.Now;
                    item.ModifiedBy = user?.FullName;
                    request.RequestedItems.Add(item);
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

                request.Attachments = _fileService.UploadAttachments(request.Id, $@"NewItemRequest\{request.Id}", newItemRequestUpdateDto.Attachments, createdBy: request.CreatedBy, modifiedBy: user.FullName, modifiedAt: DateTime.Now);
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
        [HttpPut("Approve")]
        [Authorize(Roles = "Store")]
        public async Task<ActionResult> ApproveNewItemRequest(ApproveNewItemRequestDto approveNewItemRequest)
        {
            _logger.LogInformation($"Start ApproveNewItemRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(approveNewItemRequest)} ");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            if (approveNewItemRequest.ApprovedItems.DistinctBy(r=>r.ItemNumber).Count()!= approveNewItemRequest.ApprovedItems.Count)
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = $"The submitted list contains items with same item number" });


            foreach (var item in approveNewItemRequest.ApprovedItems)
            {
                Expression<Func<RequestedItem, bool>> criteria = (r => r.ItemNumber == item.ItemNumber);
                var exitingItem = await _unitOfWork.Repository<RequestedItem>().FindAsync(criteria);

                if (exitingItem != null)
                    return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = $"Item Number '{item.ItemNumber}' is already linked to another item" });


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
        [HttpPut("Decline")]
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

       
    }
}
