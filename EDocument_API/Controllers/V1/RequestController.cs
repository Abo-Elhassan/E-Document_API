using AutoMapper;
using EDocument_Data.Consts.Enums;
using EDocument_Data.DTOs.Requests;
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
            var request = await _unitOfWork.Repository<Request>().GetByIdAsync(id);
            if (request is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Request not found" });

            reviewerDetails.ReviewersDetails = await _requestReviewerRepository.GetAllRequestReviewersAsync(id);
            reviewerDetails.CurrentStage = request.CurrentStage;
            reviewerDetails.Status = (RequestStatus)Enum.Parse(typeof(RequestStatus), request.Status);

            return Ok(new ApiResponse<ReviewersDetailsDto> { StatusCode = (int)HttpStatusCode.OK, Details = reviewerDetails });
        }

        

        

           

    }


}