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

        public RequestController(ILogger<RequestController> logger, UserManager<User> userManager, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _userManager = userManager;
            _mapper = mapper;
            _logger = logger;
            _unitOfWork = unitOfWork;
        }


        #region Procurement

        #region PO Request

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
        public async Task<ActionResult> GetPoRequestsFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetPoRequestsFiltered from {nameof(UserController)}");
            var includes = new string[] { nameof(Models.Request), "Request.RequestReviewers" };



            var result = await _unitOfWork.Repository<PoRequest>().FindAllAsync(
                filters: filterDto?.Filters,
                creatorId: filterDto?.CreatorId,
                includes: includes,
                skip: ((filterDto?.PageNo ?? 1) - 1)* filterDto?.PageSize??10,
                take: filterDto?.PageSize ?? 10,
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
        public async Task<ActionResult> GetPoRequestsFilterdDynamically(DynamicFilterWriteDto DynamicfilterDto)
        {
            _logger.LogInformation($"Start GetPoRequestsFilterdDynamically from {nameof(UserController)}");
            var includes = new string[] { nameof(Models.Request), "Request.RequestReviewers" };

            DynamicfilterDto.PageNo = DynamicfilterDto?.PageNo ?? 1;
            DynamicfilterDto!.PageSize = DynamicfilterDto?.PageSize ?? 10;

            var result = await _unitOfWork.Repository<PoRequest>().FindAllAsync(
                filterValue: DynamicfilterDto!.FilterValue,
                creatorId: DynamicfilterDto?.CreatorId,
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
