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
using EDocument_Repositories.Application_Repositories.Request_Repository;
using Microsoft.Build.Framework;
using EDocument_Reposatories.Generic_Reposatories;
using EDocument_Data.DTOs.Requests;
using System.Runtime.ConstrainedExecution;
using System.Security.Claims;
using EDocument_Data.Consts.Enums;

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


        public RequestController(ILogger<RequestController> logger, UserManager<User> userManager, IMapper mapper, IUnitOfWork unitOfWork )
        {
            _userManager = userManager;
            _mapper = mapper;
            _logger = logger;
            _unitOfWork = unitOfWork;

        }


        #region Procurement

        #region PO Request
        /// <summary>
        /// Get PO Requests By Id
        /// </summary>
        /// <param name="definedRequestId">request type id</param>
        /// <param name="requestId">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>PO Request</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<PoRequestReadDto>))]
        [HttpGet("Po/{definedRequestId}/{requestId}")]
        public async Task<ActionResult> GetPoRequestByIds(long definedRequestId, long requestId)
        {
            _logger.LogInformation($"Start GetPoRequestByIds from {nameof(UserController)}");

            var poRequest = await _unitOfWork.Repository<PoRequest>().FindRequestById(
            definedRequestId: definedRequestId,
            requestId: requestId
                );
            var result = _mapper.Map<PoRequestReadDto>(poRequest);

            return Ok(new ApiResponse<PoRequestReadDto> { StatusCode = (int)HttpStatusCode.OK, Details = result });

        }

        /// <summary>
        /// Get All PO Requests With Key/Value Pair Filter
        /// </summary>
        /// <param name="filterDto">filter information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of All PO Requests</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FilterReadDto<PoRequestReadDto>>))]
        [HttpPost("Po/KeyFilter")]
        [Authorize(Roles = "Finance,Procurement")]
        public async Task<ActionResult> GetPoRequestsFiltered(RequestFilterWriteDto filterDto)
        {
            _logger.LogInformation($"Start GetPoRequestsFiltered from {nameof(UserController)}");
            var includes = new string[] { nameof(Models.Request), "Request.Creator", "Request.RequestReviewers"};

            var result = await _unitOfWork.Repository<PoRequest>().FindAllRequestsAsync(
            definedRequestId: filterDto.DefinedRequestId,
                userId: User.FindFirstValue(ClaimTypes.NameIdentifier)!,
                permission: filterDto.Permission,
                filters: filterDto?.Filters,
               // includes: includes,
                skip: ((filterDto?.PageNo) - 1)* filterDto?.PageSize,
                take: filterDto?.PageSize,
                orderBy: filterDto?.orderBy,
                orderByDirection: filterDto?.orderByDirection,
                dateFilters: filterDto?.dateFilters
                );


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
        /// Get All PO Requests With Dynamic Filter
        /// </summary>
        /// <param name="DynamicfilterDto">filter information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of All PO Requests </returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FilterReadDto<PoRequestReadDto>>))]
        [HttpPost("Po/DynamicFilter")]
        [Authorize(Roles = "Finance,Procurement")]
        public async Task<ActionResult> GetPoRequestsFilterdDynamically(DynamicFilterWriteDto DynamicfilterDto)
        {
            _logger.LogInformation($"Start GetPoRequestsFilterdDynamically from {nameof(UserController)}");
            var includes = new string[] { nameof(Models.Request),"Request.User", "Request.RequestReviewers" };

            DynamicfilterDto.PageNo = DynamicfilterDto?.PageNo ?? 1;
            DynamicfilterDto!.PageSize = DynamicfilterDto?.PageSize ?? 10;

            var result = await _unitOfWork.Repository<PoRequest>().FindAllAsync(
                filterValue: DynamicfilterDto!.FilterValue,
                createdBy: User?.Identity?.Name,
                includes: includes,
                skip: ((DynamicfilterDto?.PageNo ?? 1) - 1) * DynamicfilterDto?.PageSize ?? 10,
                take: DynamicfilterDto?.PageSize,
                orderBy: DynamicfilterDto?.orderBy,
                orderByDirection: DynamicfilterDto?.orderByDirection,
                dateFilters: DynamicfilterDto?.dateFilters
                );


            var totalCount = result.TotalCount;
            var  totalPages = (int)Math.Ceiling((decimal)totalCount / (int)DynamicfilterDto!.PageSize);
           

            var requests = _mapper.Map<List<PoRequestReadDto>>(result.PaginatedData);

            var response = new FilterReadDto<PoRequestReadDto>
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = DynamicfilterDto.PageNo,
                PageSize = requests.Count,
                PaginatedData = requests
            };
            return Ok(new ApiResponse<FilterReadDto<PoRequestReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = response });

        }




        #endregion

        #endregion


    }
}
