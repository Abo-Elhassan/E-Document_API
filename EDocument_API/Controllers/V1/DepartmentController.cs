using AutoMapper;
using EDocument_Data.DTOs.Department;
using EDocument_Data.DTOs.Role;
using EDocument_Data.Models;
using EDocument_Data.Models.Shared;
using EDocument_Reposatories.Generic_Reposatories;
using EDocument_UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mime;

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
    public class DepartmentController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<DepartmentController> _logger;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;

        public DepartmentController(IUnitOfWork unitOfWork, ILogger<DepartmentController> logger, IMapper mapper, UserManager<User> userManager)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
            _userManager = userManager;
        }


        /// <summary>
        /// Get All Departments
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of Departmens</returns>

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<List<DepartmentReadDto>>))]
        [HttpGet]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> Get()
        {
            _logger.LogInformation($"Start Get from {nameof(DepartmentController)}");
            var departments = await _unitOfWork.Repository<Department>().GetAllAsync();
            var displayedDepartments = _mapper.Map<List<DepartmentReadDto>>(departments); 

            return Ok(new ApiResponse<List<DepartmentReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = displayedDepartments });
        }

        /// <summary>
        /// Update Department manager
        /// </summary>
        /// <param name="id">department id</param>
        /// <param name="managerId">department manager id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>message</returns>

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("{id}/{managerId}")]
        [Authorize(Roles ="SysAdmin")]
        public async Task<ActionResult> Update(long id,string managerId)
        {
            _logger.LogInformation($"Start Update from {nameof(DepartmentController)}");
            var department = await _unitOfWork.Repository<Department>().GetByIdAsync(id);

            if (department == null) 
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Department not found" });

            var manager = await _userManager.FindByIdAsync(managerId);

            if (manager == null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "Manager Id not found" });

            if(manager.DepartmentId!=id)
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = "Assigned manager is not related to the selected department" });


            department.ManagerId = managerId;
            department.ModifiedBy = _userManager.FindByNameAsync(User?.Identity?.Name)?.Result?.FullName;

            _unitOfWork.Complete();

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = "Department manager has been updated successfully" });
        }
    }
}
