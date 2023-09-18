using AutoMapper;
using EDocument_Data.DTOs.Filter;
using EDocument_Data.DTOs.Requests.PoRequest;
using EDocument_Data.DTOs.Role;
using Models = EDocument_Data.Models;
using EDocument_Data.Models;
using EDocument_Data.Models.Shared;
using EDocument_Services.Auth_Service;
using EDocument_UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mime;
using EDocument_Data.DTOs.User;

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
    public class PoRequestController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private readonly ILogger<PoRequestController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public PoRequestController(ILogger<PoRequestController> logger, UserManager<User> userManager,  IMapper mapper, IUnitOfWork unitOfWork)
        {
            _userManager = userManager;
            _mapper = mapper;
            _logger = logger;
            _unitOfWork = unitOfWork;
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
        [HttpPost("KeyFilter")]
        public async Task<ActionResult> GetFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetFiltered from {nameof(UserController)}");
            var includes = new string[] { nameof(Models.Request), "Request.RequestReviewers" };

            
            var paginatedData = await _unitOfWork.Repository<PoRequest>().FindAllAsync(
                filters: filterDto?.Filters,
                includes: includes,
                skip: filterDto?.PageNo - 1,
                take: filterDto?.PageSize,
                orderBy: filterDto?.orderBy,
                orderByDirection: filterDto?.orderByDirection
                );


            var totalCount = await _unitOfWork.Repository<PoRequest>().CountAsync();
            var totalPages = 1;
            if (filterDto?.PageSize is not null)
            {
                totalPages = (int)Math.Ceiling((decimal)totalCount / (int)filterDto.PageSize!);
            }

            var requests = _mapper.Map<List<PoRequestReadDto>>(paginatedData);

            var response = new FilterReadDto<PoRequestReadDto>
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = filterDto?.PageNo,
                PageSize = filterDto?.PageSize,
                PaginatedData = requests
            };
            return Ok(new ApiResponse<FilterReadDto<PoRequestReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = response });

        }



        ///// <summary>
        ///// Get All Users With Dynamic Filter
        ///// </summary>
        ///// <param name="DynamicfilterDto">filter information</param>
        ///// <remarks>
        /////
        ///// </remarks>
        ///// <returns>List of All Users</returns>

        //[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FilterReadDto<UserReadDto>>))]
        //[HttpPost("DynamicFilter")]
        //public async Task<ActionResult> GetFilterdDynamically(DynamicFilterWriteDto DynamicfilterDto)
        //{
        //    _logger.LogInformation($"Start GetFilterdDynamically from {nameof(UserController)}");
        //    var includes = new string[] { nameof(Department), nameof(Section) };

        //    var paginatedData = await _unitOfWork.Repository<User>().FindAllAsync(
        //        filterValue: DynamicfilterDto.filterValue,
        //        includes: includes,
        //        skip: DynamicfilterDto?.PageNo - 1,
        //        take: DynamicfilterDto?.PageSize,
        //        orderBy: DynamicfilterDto?.orderBy,
        //        orderByDirection: DynamicfilterDto?.orderByDirection
        //        );


        //    var totalCount = await _unitOfWork.Repository<User>().CountAsync();
        //    var totalPages = 1;
        //    if (DynamicfilterDto?.PageSize is not null)
        //    {
        //        totalPages = (int)Math.Ceiling((decimal)totalCount / (int)DynamicfilterDto.PageSize!);
        //    }

        //    var users = _mapper.Map<List<UserReadDto>>(paginatedData);
        //    var roles = await _roleManager.Roles.ToListAsync();

        //    foreach (var user in users)
        //    {
        //        var mappedUser = _mapper.Map<User>(user);
        //        user.Roles = roles.Select(role => new RoleReadDto
        //        {
        //            RoleId = role.Id,
        //            RoleName = role.Name!,
        //            IsGranted = _userManager.IsInRoleAsync(mappedUser, role.Name!).Result
        //        }).ToList();
        //    }

        //    var response = new FilterReadDto<UserReadDto>
        //    {
        //        TotalCount = totalCount,
        //        TotalPages = totalPages,
        //        CurrentPage = DynamicfilterDto?.PageNo,
        //        PageSize = DynamicfilterDto?.PageSize,
        //        PaginatedData = users
        //    };
        //    return Ok(new ApiResponse<FilterReadDto<UserReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = response });

        //}
    }
}
