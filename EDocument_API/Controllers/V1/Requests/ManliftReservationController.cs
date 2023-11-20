using AutoMapper;
using EDocument_Data.Consts;
using EDocument_Data.Consts.Enums;
using EDocument_Data.DTOs.Attachments;
using EDocument_Data.DTOs.Filter;
using EDocument_Data.DTOs.Requests.ManliftReservationRequest;
using EDocument_Data.DTOs.Requests.RequestReviewer;
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
    public class ManliftReservationController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private readonly ILogger<ManliftReservationController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRequestReviewerRepository _requestReviewerRepository;
        private readonly IMailService _mailService;
        private readonly IFileService _fileService;

        public ManliftReservationController(
            ILogger<ManliftReservationController> logger,
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
        /// Get All Manlift Reservations By Manlift Number
        /// </summary>
        /// <param name="manliftNumber">Manlift Number</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>All Manlift Reservations</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<List<ReservedManliftReadDto>>))]
        [HttpGet("Reserved/{manliftNumber}")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> GetAllManliftReservationRequestByManliftNumber(string manliftNumber)
        {
            _logger.LogInformation($"Start GetManliftReservationRequestById from {nameof(RequestController)} for manlift number = {manliftNumber}");
            var includes = new string[] { "Request" };
            Expression<Func<ManliftReservationRequest, bool>> criteria = (r =>
                r.Request.Status == RequestStatus.Approved.ToString() &&
                r.ManliftNumber == manliftNumber &&
                r.RequestedTo > DateTime.Now
                );


            var manliftReservationRequests = await _unitOfWork.Repository<ManliftReservationRequest>().FindAllAsync(
                criteria: criteria,
                includes: includes
            );

            var result = _mapper.Map<List<ReservedManliftReadDto>>(manliftReservationRequests);

            return Ok(new ApiResponse<List<ReservedManliftReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = result });
        }

        /// <summary>
        /// Get Manlift Reservation Request By Id
        /// </summary>
        /// <param name="id">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>Manlift Reservation Request</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<ManliftReservationRequestReadDto>))]
        [HttpGet("{id}")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> GetManliftReservationRequestById(long id)
        {
            _logger.LogInformation($"Start GetManliftReservationRequestById from {nameof(RequestController)} for request id = {id}");

            var includes = new string[] { "Request" };
            var manliftReservationRequest = await _unitOfWork.Repository<ManliftReservationRequest>().FindRequestAsync(
            requestId: id,
            expression: "Request.Id==@0",
            includes: includes
            );

            if (manliftReservationRequest is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Request not found" });

            var result = _mapper.Map<ManliftReservationRequestReadDto>(manliftReservationRequest);

            return Ok(new ApiResponse<ManliftReservationRequestReadDto> { StatusCode = (int)HttpStatusCode.OK, Details = result });
        }

        /// <summary>
        /// Delete Manlift Reservation Request By Id
        /// </summary>
        /// <param name="id">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> DeleteManliftReservationRequest(long id)
        {
            _logger.LogInformation($"Start DeleteManliftReservationRequest from {nameof(RequestController)} for request id = {id}");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var includes = new string[] { "ManliftReservationRequest", "Attachments", "RequestReviewers" };

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

            request.ManliftReservationRequest.ModifiedBy = user?.FullName;
            request.ModifiedBy = user?.FullName;
            _unitOfWork.Complete();

            _unitOfWork.Repository<Request>().Delete(request);
            _unitOfWork.Complete();

            _fileService.DeleteFolder($@"ManliftReservationRequest\{id}");

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = "Request deleted successfully" });
        }

        /// <summary>
        /// Get All Manlift Reservation Requests By Creator With Filter
        /// </summary>
        /// <param name="filterDto">filter information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of All Created Manlift Reservation Requests</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FilterReadDto<ManliftReservationRequestReadDto>>))]
        [HttpPost("Inbox")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> GetCreatorManliftReservationRequestsFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetCreatorManliftReservationRequestsFiltered from {nameof(RequestController)} with filter: {JsonSerializer.Serialize(filterDto)}");
            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            string? userCondition = null;

            (int TotalCount, IEnumerable<ManliftReservationRequest> PaginatedData) result;

            userCondition = "Request.CreatorId ==@0";

            if (!string.IsNullOrEmpty(filterDto?.FilterValue))
            {
                result = await _unitOfWork.Repository<ManliftReservationRequest>().FindAllRequestsAsync(
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
                result = await _unitOfWork.Repository<ManliftReservationRequest>().FindAllRequestsAsync(
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

            var requests = _mapper.Map<List<ManliftReservationRequestReadDto>>(result.PaginatedData);

            var response = new FilterReadDto<ManliftReservationRequestReadDto>
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = filterDto?.PageNo ?? 1,
                PageSize = requests.Count,
                PaginatedData = requests
            };
            return Ok(new ApiResponse<FilterReadDto<ManliftReservationRequestReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = response });
        }

        /// <summary>
        /// Get All Manlift Reservation Requests By Reviewer With Filter
        /// </summary>
        /// <param name="filterDto">filter information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of All Reviewer Manlift Reservation Requests</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FilterReadDto<ManliftReservationRequestReviewerReadDto>>))]
        [HttpPost("AssignedToMe")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> GetReviewerManliftReservationRequestsFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetReviewerManliftReservationRequestsFiltered from {nameof(RequestController)} with filter: {JsonSerializer.Serialize(filterDto)}");
            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            string? userCondition = null;

            (int TotalCount, IEnumerable<ManliftReservationRequest> PaginatedData) result;

            userCondition = "Request.RequestReviewers.Any(AssignedReviewerId == @0 && Request.CurrentStage >= StageNumber)";

            if (!string.IsNullOrEmpty(filterDto?.FilterValue))
            {
                result = await _unitOfWork.Repository<ManliftReservationRequest>().FindAllRequestsAsync(
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
                result = await _unitOfWork.Repository<ManliftReservationRequest>().FindAllRequestsAsync(
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

            var requests = _mapper.Map<List<ManliftReservationRequestReviewerReadDto>>(result.PaginatedData);

            foreach (var request in requests)
            {
                var reviewer = request.RequestReviewers?.OrderBy(r => r.StageNumber).LastOrDefault(y => y.AssignedReviewerId == User.FindFirstValue(ClaimTypes.NameIdentifier) && y.Status != RequestStatus.None);

                request.ReviewerStatus = reviewer?.Status;
                request.ReviewerStage = reviewer?.StageNumber;
            }

            var response = new FilterReadDto<ManliftReservationRequestReviewerReadDto>
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = filterDto?.PageNo ?? 1,
                PageSize = requests.Count,
                PaginatedData = requests
            };
            return Ok(new ApiResponse<FilterReadDto<ManliftReservationRequestReviewerReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = response });
        }

        /// <summary>
        /// Create Manlift Reservation Request
        /// </summary>
        /// <param name="manliftReservationRequestCreateDto">Manlift Reservation request Information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPost("Create")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> CreateManliftReservationRequest(ManliftReservationRequestCreateDto manliftReservationRequestCreateDto)
        {
            _logger.LogInformation($"Start CreateManliftReservationRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(manliftReservationRequestCreateDto)} ");
            var user = await _userManager.Users.Include(t => t.Department).FirstOrDefaultAsync(u => u.Id == User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var beneficiaryUser = await _userManager.Users.Include(t => t.Department).FirstOrDefaultAsync(u => u.Id == manliftReservationRequestCreateDto.BeneficiaryId);

            if (beneficiaryUser is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"Requester Id '{manliftReservationRequestCreateDto.BeneficiaryId}' not found" });



            Expression<Func<ManliftReservationRequest, bool>> criteria = (r =>
                r.Request.Status == RequestStatus.Approved.ToString() &&
                r.ManliftNumber == manliftReservationRequestCreateDto.ManliftNumber && (
                (manliftReservationRequestCreateDto.RequestedFrom >= r.RequestedFrom && manliftReservationRequestCreateDto.RequestedFrom < r.RequestedTo) || //Check if the desired start date falls within an existing booking
                (manliftReservationRequestCreateDto.RequestedTo >= r.RequestedFrom && manliftReservationRequestCreateDto.RequestedTo < r.RequestedTo) || // Check if the desired end date falls within an existing booking
                (r.RequestedFrom >= manliftReservationRequestCreateDto.RequestedFrom && r.RequestedFrom < manliftReservationRequestCreateDto.RequestedTo) //Check if an existing booking falls within the desired dates
                ));
            var reservedDates = await _unitOfWork.Repository<ManliftReservationRequest>().FindAllAsync(criteria, new string[] { "Request" });



            if (reservedDates.Any())
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = $"Manlift number '{manliftReservationRequestCreateDto.ManliftNumber}' is already reserved at the requested time" });


            var requestId = long.Parse(DateTime.Now.ToString("yyyyMMddhhmmssff"));
            var requestNo = $"Manlift-{DateTime.Now.ToString("yyyyMMddhhmmss")}";

            var request = new Request { Id = requestId, DefinedRequestId = manliftReservationRequestCreateDto.DefinedRequestId };
            request.Notes = manliftReservationRequestCreateDto.Notes;
            request.ManliftReservationRequest = _mapper.Map<ManliftReservationRequest>(manliftReservationRequestCreateDto);
            _mapper.Map(beneficiaryUser, request.ManliftReservationRequest);
            request.ManliftReservationRequest.RequestNumber = requestNo;
            request.CreatorId = user?.Id;
            request.ManliftReservationRequest.CreatedBy = user?.FullName;
            request.CreatedBy = user?.FullName;
            request.ManliftReservationRequest.CreatedBy = user?.FullName;

            _unitOfWork.Repository<Request>().Add(request);

            _unitOfWork.Complete();

            await _requestReviewerRepository.BeginRequestCycle(manliftReservationRequestCreateDto.DefinedRequestId, requestId, user.Id, true);


            #region Send Emails

            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {user.FullName.Split(" ")[0]},
                    Kindly not that your Manlift Reservation Request on eDocuement has been created successfully and it's under reviewing now.
                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with your request Status.

                    - eDocument Request Reference No.: {requestNo}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"Manlift Reservation Request No. {requestNo} on eDocuement",
                To = user.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            var reviewersEmails = await _requestReviewerRepository.GetAllRequestReviewersEmailsByStageNumberAsync(requestId, request.CurrentStage);
            var reviewerMailContent = new MailContent
            {
                Body = $"""
                Dears,
                    Kindly note that {user.FullName} has created Manlift Reservation Request for on eDocuement and need to be reviewed from your side.

                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                    - eDocument Request Reference No.: {requestNo}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                """,
                IsHTMLBody = false,
                Subject = $"Manlift Reservation Request No. {requestNo} on eDocuement",
                To = reviewersEmails
            };

            _mailService.SendMailAsync(reviewerMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Request has been created successfully - Request No. {requestNo}" });
        }

        /// <summary>
        /// Update Manlift Reservation Request
        /// </summary>
        /// <param name="id">Manlift Reservation request Id</param>
        /// <param name="manliftReservationRequestUpdateDto">Manlift Reservation request Information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("Update/{id}")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> UpdateManliftReservationRequest(long id, ManliftReservationRequestUpdateDto manliftReservationRequestUpdateDto)
        {
            _logger.LogInformation($"Start UpdateManliftReservationRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(manliftReservationRequestUpdateDto)} ");

            var beneficiaryUser = await _userManager.Users.Include(t => t.Department).FirstOrDefaultAsync(u => u.Id == manliftReservationRequestUpdateDto.BeneficiaryId);

            if (beneficiaryUser is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"Requester Id '{manliftReservationRequestUpdateDto.BeneficiaryId}' not found" });



            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == id);

            var request = await _unitOfWork.Repository<Request>().FindAsync(requestRxpression, new string[] { "ManliftReservationRequest", "Attachments" });


            if (request == null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"Request not found" });

            if (request.Status == RequestStatus.Approved.ToString())
            {
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = $"You cannot update this request as it has been already approved" });
            }
            else if (request.RequestReviewers.Any(rr => rr.Status == RequestStatus.Approved.ToString()))
            {
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "You cannot update the request after one of the reviewers took his action" });
            }


            var user = await _userManager.Users.Include(t => t.Department).FirstOrDefaultAsync(u => u.Id == User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            Expression<Func<ManliftReservationRequest, bool>> criteria = (r =>
                r.Request.Status == RequestStatus.Approved.ToString() &&
                r.ManliftNumber == manliftReservationRequestUpdateDto.ManliftNumber &&
                manliftReservationRequestUpdateDto.RequestedFrom >= r.RequestedFrom &&
                manliftReservationRequestUpdateDto.RequestedFrom < r.RequestedTo);
            var reservedDates = await _unitOfWork.Repository<ManliftReservationRequest>().FindAllAsync(criteria, new string[] { "Request" });



            if (reservedDates.Any())
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = $"Manlift number '{manliftReservationRequestUpdateDto.ManliftNumber}' is already reserved at the requested time" });


            request.Notes = manliftReservationRequestUpdateDto.Notes;
            _mapper.Map(manliftReservationRequestUpdateDto, request);
            _mapper.Map(manliftReservationRequestUpdateDto, request.ManliftReservationRequest);
            _mapper.Map(beneficiaryUser, request.ManliftReservationRequest);
            request.ManliftReservationRequest.RequestId = id;
            request.ManliftReservationRequest.ModifiedAt = DateTime.Now;
            request.ManliftReservationRequest.ModifiedBy = user?.FullName;
            request.ModifiedBy = user?.FullName;

            _unitOfWork.Complete();

            await _requestReviewerRepository.BeginRequestCycle(request.DefinedRequestId, request.Id, user.Id, false);


            #region Send Emails

            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {user.FullName.Split(" ")[0]},
                    Kindly not that your Manlift Reservation Request on eDocuement has been created successfully and it's under reviewing now.
                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) to be updated with your request Status.

                    - eDocument Request Reference No.: {request.ManliftReservationRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"Manlift Reservation Request No. {request.ManliftReservationRequest.RequestNumber} on eDocuement",
                To = user.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            var reviewersEmails = await _requestReviewerRepository.GetAllRequestReviewersEmailsByStageNumberAsync(request.Id, request.CurrentStage);
            var reviewerMailContent = new MailContent
            {
                Body = $"""
                Dears,
                    Kindly note that {user.FullName} has updated Manlift Reservation Request for on eDocuement and need to be reviewed from your side.

                    Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                    - eDocument Request Reference No.: {request.ManliftReservationRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                """,
                IsHTMLBody = false,
                Subject = $"Manlift Reservation Request No. {request.ManliftReservationRequest.RequestNumber} on eDocuement",
                To = reviewersEmails
            };

            _mailService.SendMailAsync(reviewerMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Request has been updated successfully" });
        }

        /// <summary>
        /// Approve Manlift Reservation Request
        /// </summary>
        /// <param name="requestReviewerWriteDto">Approve Manlift Reservation Request</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("Approve")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> ApproveManliftReservationRequest(ApproveRequestReviewerDto requestReviewerWriteDto)
        {
            _logger.LogInformation($"Start ApproveManliftReservationRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(requestReviewerWriteDto)} ");
            var includes = new string[] { "Request" };
            var manliftReservationRequest = await _unitOfWork.Repository<ManliftReservationRequest>().FindRequestAsync(
            requestId: requestReviewerWriteDto.RequestId,
            expression: "Request.Id==@0",
            includes: includes
            );

            if (manliftReservationRequest.RequestedFrom < DateTime.Now)
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = $"You cannot approve this request as the requested date is in the past" });


            Expression<Func<ManliftReservationRequest, bool>> criteria = (r =>
                r.Request.Status == RequestStatus.Approved.ToString() &&
                r.ManliftNumber == manliftReservationRequest.ManliftNumber && (
                (manliftReservationRequest.RequestedFrom >= r.RequestedFrom && manliftReservationRequest.RequestedFrom < r.RequestedTo) || //Check if the desired start date falls within an existing booking
                (manliftReservationRequest.RequestedTo >= r.RequestedFrom && manliftReservationRequest.RequestedTo < r.RequestedTo) || // Check if the desired end date falls within an existing booking
                (r.RequestedFrom >= manliftReservationRequest.RequestedFrom && r.RequestedFrom < manliftReservationRequest.RequestedTo) //Check if an existing booking falls within the desired dates
                ));
            var reservedDates = await _unitOfWork.Repository<ManliftReservationRequest>().FindAllAsync(criteria, new string[] { "Request" });

            if (reservedDates.Any())
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = $"Manlift number '{manliftReservationRequest.ManliftNumber}' is already reserved at the requested time" });

            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var result = await _requestReviewerRepository.ApproveRequestAsync(requestReviewerWriteDto, user);

            if (!result.IsSucceded)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = result.Message });

            #region Send Emails

            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == requestReviewerWriteDto.RequestId);
            var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "ManliftReservationRequest", "Creator", });
            var requestCreator = request.Creator;
            if (request?.Status == RequestStatus.Approved.ToString())
            {
                var creatorMailContent = new MailContent
                {
                    Body = $"""
                Dear {requestCreator.FullName.Split(" ")[0]},
                    Kindly not that your Manlift Reservation Request {request.ManliftReservationRequest.RequestNumber} on eDocuement has been approved successfully.
                    For more detail, please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}).

                    - eDocument Request Reference No.: {request.ManliftReservationRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                    IsHTMLBody = false,
                    Subject = $"Manlift Reservation Request No. {request.ManliftReservationRequest.RequestNumber} on eDocuement",
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
                        Kindly note that {requestCreator.FullName} has created Manlift Reservation Request for on eDocuement and need to be reviewed from your side.

                        Please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}) for more details.

                        - eDocument Request Reference No.: {request.ManliftReservationRequest.RequestNumber}

                    Thanks,

                    “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”
                    """,
                    IsHTMLBody = false,
                    Subject = $"Manlift Reservation Request No. {request.ManliftReservationRequest.RequestNumber} on eDocuement",
                    To = reviewersEmails
                };

                _mailService.SendMailAsync(reviewerMailContent);
            }

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Your action has been recorded successfully" });
        }

        /// <summary>
        /// Decline Manlift Reservation Request
        /// </summary>
        /// <param name="requestReviewerWriteDto">Decline Manlift Reservation Request</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("Decline")]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> DeclineManliftReservationRequest(DeclineRequestReviewerDto requestReviewerWriteDto)
        {
            _logger.LogInformation($"Start DeclineManliftReservationRequest from {nameof(RequestController)} for {JsonSerializer.Serialize(requestReviewerWriteDto)} ");
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var result = await _requestReviewerRepository.DeclineRequestAsync(requestReviewerWriteDto, user);
            if (!result.IsSucceded)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = result.Message });

            #region Send Emails

            Expression<Func<Request, bool>> requestRxpression = (r => r.Id == requestReviewerWriteDto.RequestId);
            var request = _unitOfWork.Repository<Request>().Find(requestRxpression, new string[] { "ManliftReservationRequest", "Creator" });

            var requestCreator = request.Creator;
            var creatorMailContent = new MailContent
            {
                Body = $"""
                Dear {requestCreator.FullName.Split(" ")[0]},
                    Kindly not that your Manlift Reservation Request No. {request.ManliftReservationRequest.RequestNumber} on eDocuement has been declined by {user.FullName}.
                    For more detail, please check you inbox on eDocument ({ApplicationConsts.ClientOrigin}).

                    - eDocument Request Reference No.: {request.ManliftReservationRequest.RequestNumber}

                Thanks,

                “This is an auto generated email from DP World Sokhna Technology system. Please do not reply to this email”

                """,
                IsHTMLBody = false,
                Subject = $"Manlift Reservation Request No. {request.ManliftReservationRequest.RequestNumber} on eDocuement",
                To = requestCreator.Email
            };

            _mailService.SendMailAsync(creatorMailContent);

            #endregion Send Emails

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Your action has been recorded successfully" });
        }


    }
}
