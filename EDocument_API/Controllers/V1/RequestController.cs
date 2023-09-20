using AutoMapper;
using EDocument_Data.DTOs.Filter;
using EDocument_Data.DTOs.Requests.PoRequest;
using EDocument_Data.Models;
using EDocument_Data.Models.Shared;
using EDocument_UnitOfWork;
using Models = EDocument_Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mime;
using EDocument_Services.Helpers;
using EDocument_EF;
using EDocument_Data.DTOs.User;
using Microsoft.AspNetCore.Authorization;

using Microsoft.Build.Framework;
using EDocument_Reposatories.Generic_Reposatories;
using EDocument_Data.DTOs.Requests;
using System.Runtime.ConstrainedExecution;
using System.Security.Claims;
using EDocument_Data.Consts.Enums;
using System.Text.Json;
using EDocument_Repositories.Application_Repositories.Request_Reviewer_Repository;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace EDocument_API.Controllers.V1
{
    [Produces(MediaTypeNames.Application.Json, MediaTypeNames.Application.Xml)]
    [Consumes(MediaTypeNames.Application.Json, MediaTypeNames.Application.Xml)]
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

        public RequestController(ILogger<RequestController> logger, UserManager<User> userManager, IMapper mapper, IUnitOfWork unitOfWork, IRequestReviewerRepository RequestReviewerRepository)
        {
            _userManager = userManager;
            _mapper = mapper;
            _logger = logger;
            _unitOfWork = unitOfWork;
            _requestReviewerRepository = RequestReviewerRepository;
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

        public async Task<ActionResult> GetPoRequestById( long id)
        {
            _logger.LogInformation($"Start GetPoRequestById from {nameof(UserController)}");

            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            var poRequest = await _unitOfWork.Repository<PoRequest>().FindRequestAsync(
            requestId: id,
            expression: "Request.Id==@0",
            includes: includes
            );

            if (poRequest is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Request not found" });

            var result = _mapper.Map<PoRequestReadDto>(poRequest);

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
        [Authorize(Roles = "Finance,Procurement")]

        public async Task<ActionResult> DeletePoRequest( long id)
        {
            _logger.LogInformation($"Start DeletePoRequest from {nameof(UserController)}");
            var includes = new string[] { "PoRequest",  "Attachments", "RequestReviewers" };

            var poRequest = await _unitOfWork.Repository<Request>().FindRequestAsync(
            requestId: id,
            expression:"Id==@0",
            includes: includes
                );
          

            if( poRequest is null )
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Request not found" });

            poRequest.PoRequest.ModifiedBy = User?.Identity?.Name;
            poRequest.ModifiedBy = User?.Identity?.Name;
            _unitOfWork.Complete();

            _unitOfWork.Repository<Request>().Delete(poRequest);
             _unitOfWork.Complete();

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = "Request deleted successfully" });

        }

        /// <summary>
        /// Get All PO Requests With  Filter
        /// </summary>
        /// <param name="filterDto">filter information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of All PO Requests</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FilterReadDto<PoRequestReadDto>>))]
        [HttpPost("Po/Filter")]
        [Authorize(Roles = "Finance,Procurement")]
        public async Task<ActionResult> GetPoRequestsFiltered(FilterWriteDto filterDto)
        {
            _logger.LogInformation($"Start GetPoRequestsFiltered from {nameof(UserController)}");
            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            string? userCondition = null;
            RequestPermission permission;
            var userRole = User.FindFirstValue(ClaimTypes.Role);

            permission = userRole == ApplicationRole.Procurement.ToString() ? RequestPermission.Request : RequestPermission.Review;

            (int TotalCount, IEnumerable<PoRequest> PaginatedData) result;


            if (permission == RequestPermission.Request)
            {
                userCondition= "Request.CreatorId ==@0";
            }
            else
            {
                userCondition = "Request.RequestReviewers.Any(AssignedReviewerId == @0)";
            }



            if (!string.IsNullOrEmpty(filterDto?.FilterValue))
            {
                result = await _unitOfWork.Repository<PoRequest>().FindAllRequestsAsync(
                userId: User.FindFirstValue(ClaimTypes.NameIdentifier)!,
                userCondition: userCondition,
                filterValue: filterDto?.FilterValue,
                includes: includes,
                skip: ((filterDto?.PageNo ?? 1) - 1) * (filterDto?.PageSize ?? 10),
                take: filterDto?.PageSize,
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
                take: filterDto?.PageSize,
                orderBy: filterDto?.orderBy,
                orderByDirection: filterDto?.orderByDirection,
                dateFilters: filterDto?.dateFilters
                );
            }





            var totalCount = result.TotalCount;
            var totalPages = (int)Math.Ceiling((decimal)totalCount / (filterDto?.PageSize ?? 10));

        
            var requests = _mapper.Map<List<PoRequestReadDto>>(result.PaginatedData);


            if (permission == RequestPermission.Review)
            {
                foreach (var request in requests)
                {
                    var reviewer = request.RequestReviewers?.FirstOrDefault(y => y.AssignedReviewerId == User.FindFirstValue(ClaimTypes.NameIdentifier));

                    request.ReviewerStatus = reviewer?.Status;
                    request.ReviewerStage = reviewer?.StageNumber;

                }
            }

            


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
            _logger.LogInformation($"Start GetCreatorPoRequestsFiltered from {nameof(UserController)}");
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
                take: filterDto?.PageSize??10,
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
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FilterReadDto<PoRequestReadDto>>))]
        [HttpPost("Po/AssignedToMe")]
        [Authorize(Roles = "Finance")]
        public async Task<ActionResult> GetReviewerPoRequestsFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetReviewerPoRequestsFiltered from {nameof(UserController)}");
            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            string? userCondition = null;


            (int TotalCount, IEnumerable<PoRequest> PaginatedData) result;

                userCondition = "Request.RequestReviewers.Any(AssignedReviewerId == @0)";




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


                foreach (var request in requests)
                {
                    var reviewer = request.RequestReviewers?.FirstOrDefault(y => y.AssignedReviewerId == User.FindFirstValue(ClaimTypes.NameIdentifier));

                    request.ReviewerStatus = reviewer?.Status;
                    request.ReviewerStage = reviewer?.StageNumber;

                }
            requests = requests.Where(r => r.CurrentStage >= r.ReviewerStage).ToList();



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
        /// Create PO Request
        /// </summary>
        /// <param name="poRequestWriteDto">Po request Informarion</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPost("Po/Create")]
        [Authorize(Roles ="Procurement")]
        public async Task<ActionResult> Create(PoRequestWriteDto poRequestWriteDto)
        {
            _logger.LogInformation($"Start Create from {nameof(UserController)} for {JsonSerializer.Serialize(poRequestWriteDto)} ");
            var requestId = long.Parse(DateTime.Now.ToString("yyyyMMddhhmmssff"));
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var request = new Request {Id= requestId, DefinedRequestId = poRequestWriteDto.DefinedRequestId };
            var definedRequestReviewers = await _requestReviewerRepository.GetDefinedRequestReviewersAsync(poRequestWriteDto.DefinedRequestId);
            request.RequestReviewers = _mapper.Map<List<RequestReviewer>>(definedRequestReviewers);
            request.PoRequest =_mapper.Map<PoRequest>(poRequestWriteDto);
            request.CreatorId = user?.Id;
            request.PoRequest.CreatorFullName = user?.FullName;
            request.CurrentStage = 1;
            
            request.CreatedBy = user?.UserName;
            request.PoRequest.CreatedBy = user?.UserName;

            _unitOfWork.Repository<Request>().Add(request);

           var result =  _unitOfWork.Complete();
            if (result<1) BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "Adding new request has been failed" });

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Request has been created successfully - Request id = '{requestId}'" });
        }

        #endregion

        #endregion


    }
}
