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
        /// <param name="id">request id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>PO Request</returns>

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<PoRequestReadDto>))]
        [HttpGet("Po/{id}")]
        [Authorize(Roles = "Finance,Procurement")]

        public async Task<ActionResult> GetPoRequestByIds( long id)
        {
            _logger.LogInformation($"Start GetPoRequestByIds from {nameof(UserController)}");

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
        public async Task<ActionResult> GetPoRequestsFiltered(RequestFilterWriteDto filterDto)
        {
            _logger.LogInformation($"Start GetPoRequestsFiltered from {nameof(UserController)}");
            var includes = new string[] { "Request", "Request.Creator", "Request.RequestReviewers", "Request.Attachments" };
            string? reviewingExpression = null;
            (int TotalCount, IEnumerable<PoRequest> PaginatedData) result;

            if (filterDto.Permission==RequestPermission.Review)
            {
                reviewingExpression = "Request.RequestReviewers.Any(AssignedReviewerId == @0)";
            }

            if (filterDto?.Filters != null)
            {
                result = await _unitOfWork.Repository<PoRequest>().FindAllRequestsAsync(
                userId: User.FindFirstValue(ClaimTypes.NameIdentifier)!,
                permission: filterDto.Permission,
                reviewingExpression: reviewingExpression,
                filters: filterDto?.Filters,
                includes: includes,
                skip: ((filterDto?.PageNo) - 1) * filterDto?.PageSize,
                take: filterDto?.PageSize,
                orderBy: filterDto?.orderBy,
                orderByDirection: filterDto?.orderByDirection,
                dateFilters: filterDto?.dateFilters
                );
            }
            else if (!string.IsNullOrEmpty(filterDto?.FilterValue))
            {
                result = await _unitOfWork.Repository<PoRequest>().FindAllRequestsAsync(
                userId: User.FindFirstValue(ClaimTypes.NameIdentifier)!,
                permission: filterDto.Permission,
                reviewingExpression: reviewingExpression,
                filterValue: filterDto?.FilterValue,
                includes: includes,
                skip: ((filterDto?.PageNo) - 1) * filterDto?.PageSize,
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
                                permission: filterDto.Permission,
                                reviewingExpression: reviewingExpression,
                                filters: filterDto?.Filters,
                                includes: includes,
                                skip: ((filterDto?.PageNo) - 1) * filterDto?.PageSize,
                                take: filterDto?.PageSize,
                                orderBy: filterDto?.orderBy,
                                orderByDirection: filterDto?.orderByDirection,
                                dateFilters: filterDto?.dateFilters
                                );
            }




            var totalCount = result.TotalCount;
            var totalPages = (int)Math.Ceiling((decimal)totalCount / (filterDto?.PageSize ?? 10));

        
            var requests = _mapper.Map<List<PoRequestReadDto>>(result.PaginatedData);


            if (filterDto?.Permission == RequestPermission.Review)
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





        #endregion

        #endregion


    }
}
