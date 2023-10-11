using AutoMapper;
using EDocument_Data.DTOs.DefinedRequest;
using EDocument_Data.DTOs.Filter;
using EDocument_Data.DTOs.Requests.PoRequest;
using EDocument_Data.Models;
using EDocument_Data.Models.Shared;
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
    public class DefinedRequestController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private readonly ILogger<RequestController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly RoleManager<Role> _roleManager;

        public DefinedRequestController(
            ILogger<RequestController> logger,
            UserManager<User> userManager,
            IMapper mapper,
            IUnitOfWork unitOfWork,
            RoleManager<Role> roleManager)
        {
            _userManager = userManager;
            _mapper = mapper;
            _logger = logger;
            _unitOfWork = unitOfWork;
            _roleManager = roleManager;
        }

        /// <summary>
        /// Get All Defined Requests
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of Defined Requests</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FilterReadDto<DefinedRequestReadDto>>))]
        [HttpPost]
        [Authorize(Roles ="SysAdmin")]
        public async Task<ActionResult> GetAll(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetAll from {nameof(DefinedRequestController)}");
            var includes = new string[] { "DefinedRequestReviewers", "DefinedRequestRoles", "Department" };
          

            (int TotalCount, IEnumerable<DefinedRequest> PaginatedData) result;

            if (!string.IsNullOrEmpty(filterDto?.FilterValue))
            {
                result = await _unitOfWork.Repository<DefinedRequest>().FindAllAsync(
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
                result = await _unitOfWork.Repository<DefinedRequest>().FindAllRequestsAsync(
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

            var requests = _mapper.Map<List<DefinedRequestReadDto>>(result.PaginatedData);
            foreach (var request in requests)
            {
                foreach (var requestDto in request.DefinedRequestRoles)
                {
                    requestDto.RoleName = _roleManager.FindByIdAsync(requestDto.RoleId)?.Result?.Name?.ToString();
                }
               
            }
            var response = new FilterReadDto<DefinedRequestReadDto>
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = filterDto?.PageNo ?? 1,
                PageSize = requests.Count,
                PaginatedData = requests
            };

            return Ok(new ApiResponse<FilterReadDto<DefinedRequestReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = response });
        }

        /// <summary>
        /// Get Defined Request Details
        /// </summary>
        /// <param name="id">defined request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>Defined Request Details</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<DefinedRequestReadDto>))]
        [HttpGet("{id}")]
        [Authorize(Roles = "SysAdmin")]
        public async Task<ActionResult> GetById(long id)
        {
            _logger.LogInformation($"Start GetById from {nameof(DefinedRequestController)}");
            var includes = new string[] { "DefinedRequestReviewers", "DefinedRequestRoles", "Department" };
           Expression<Func<DefinedRequest, bool>> expression = (r => r.Id == id);
            var definedRequest = await _unitOfWork.Repository<DefinedRequest>().FindAsync(expression, includes);
            if (definedRequest == null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Defined request not found" });
            var mappedRequest = _mapper.Map<DefinedRequestReadDto>(definedRequest);
            foreach (var request in mappedRequest.DefinedRequestRoles)
            {
                request.RoleName = _roleManager.FindByIdAsync(request.RoleId)?.Result?.Name?.ToString();
            }
            return Ok(new ApiResponse<DefinedRequestReadDto> { StatusCode = (int)HttpStatusCode.OK, Details = _mapper.Map<DefinedRequestReadDto>(mappedRequest) });
        }

        /// <summary>
        /// Delete Defined Request 
        /// </summary>
        /// <param name="id">defined request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<DefinedRequestReadDto>))]
        [HttpDelete("{id}")]
        [Authorize(Roles = "SysAdmin")]
        public async Task<ActionResult> Delete(long id)
        {
            _logger.LogInformation($"Start Delete from {nameof(DefinedRequestController)}");
            var includes = new string[] { "DefinedRequestReviewers", "DefinedRequestRoles"};
            Expression<Func<DefinedRequest, bool>> expression = (r => r.Id == id);
            var definedRequest = await _unitOfWork.Repository<DefinedRequest>().FindAsync(expression, includes);
            if (definedRequest == null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Defined request not found" });


            _unitOfWork.Repository<DefinedRequest>().Delete(definedRequest);
            _unitOfWork.Complete();

            return Ok(new ApiResponse<DefinedRequestReadDto> { StatusCode = (int)HttpStatusCode.OK, Details = _mapper.Map<DefinedRequestReadDto>(definedRequest) });
        }

        /// <summary>
        /// Create Defined Request
        /// </summary>
        /// <param name="definedRequestCreateDto">Defined request Information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPost("Create")]
        [Authorize(Roles = "SysAdmin")]
        public async Task<ActionResult> Create(DefinedRequestCreateDto definedRequestCreateDto)
        {

            _logger.LogInformation($"Start Create from {nameof(DefinedRequestController)} for {JsonSerializer.Serialize(definedRequestCreateDto)} ");

            foreach (var item in definedRequestCreateDto.DefinedRequestReviewers)
            {
                if (item?.AssignedReviewerId!=null)
                {
                    var requestReviewer = await _userManager.FindByIdAsync(item?.AssignedReviewerId);
                    if(requestReviewer==null)
                        return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"Reviewer Id: '{item?.AssignedReviewerId}' not found as user" });
                }
               
            }

            var definedRequestId = long.Parse(DateTime.Now.ToString("yyyyMMddhhmmssff"));
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var newDefinedRequest = _mapper.Map<DefinedRequest>(definedRequestCreateDto);


            newDefinedRequest.Id = definedRequestId;
            foreach (var item in newDefinedRequest.DefinedRequestReviewers)
            {
                item.DefinedRequestId = definedRequestId;
            }

            foreach (var item in newDefinedRequest.DefinedRequestRoles)
            {
                item.DefinedRequestId = definedRequestId;
            }


            newDefinedRequest.CreatedBy = user?.FullName;

            foreach (var item in newDefinedRequest.DefinedRequestReviewers)
            {
                item.CreatedBy = user?.FullName;
            }

            foreach (var item in newDefinedRequest.DefinedRequestRoles)
            {
                item.CreatedBy = user?.FullName;
            } 

            _unitOfWork.Repository<DefinedRequest>().Add(newDefinedRequest);

            var result = _unitOfWork.Complete(); 
            
            if (result < 1)
                BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "Adding new request has been failed" });

   

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Request has been created successfully" });
        }


        /// <summary>
        /// Update Defined Request
        /// </summary>
        /// <param name="id">Defined request id</param>
        /// <param name="definedRequestUpdateDto">Defined request Information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("Update/{id}")]
        [Authorize(Roles = "SysAdmin")]
        public async Task<ActionResult> Update(long id, DefinedRequestUpdateDto definedRequestUpdateDto)
        {

            _logger.LogInformation($"Start Update from {nameof(DefinedRequestController)} for {JsonSerializer.Serialize(definedRequestUpdateDto)} ");

            foreach (var item in definedRequestUpdateDto.DefinedRequestReviewers)
            {
                if (item?.AssignedReviewerId != null)
                {
                    var requestReviewer = await _userManager.FindByIdAsync(item?.AssignedReviewerId);
                    if (requestReviewer == null)
                        return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"Reviewer Id: '{item?.AssignedReviewerId}' not found as user" });
                }

            }
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            Expression<Func<DefinedRequest, bool>> expression = (r => r.Id == id);
            var includes = new string[] { "DefinedRequestReviewers", "DefinedRequestRoles" };

            var definedRequest = await _unitOfWork.Repository<DefinedRequest>().FindAsync(expression, includes);


            if (definedRequest == null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"Defined request not found" });

            _mapper.Map(definedRequestUpdateDto, definedRequest);
            _mapper.Map(definedRequestUpdateDto.DefinedRequestReviewers, definedRequest.DefinedRequestReviewers);
            _mapper.Map(definedRequestUpdateDto.DefinedRequestRoles, definedRequest.DefinedRequestRoles);


            definedRequest.ModifiedBy = user?.FullName;

            foreach (var item in definedRequest.DefinedRequestReviewers)
            {
                item.ModifiedBy = user?.FullName;
                item.ModifiedAt = DateTime.Now;
            }

            foreach (var item in definedRequest.DefinedRequestRoles)
            {
                item.ModifiedBy = user?.FullName;
                item.ModifiedAt = DateTime.Now;
            }

            _unitOfWork.Repository<DefinedRequest>().Update(definedRequest);

            var result = _unitOfWork.Complete();

            if (result < 1)
                BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "Updating request has been failed" });



            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"Request has been updated successfully" });
        }

    }
}