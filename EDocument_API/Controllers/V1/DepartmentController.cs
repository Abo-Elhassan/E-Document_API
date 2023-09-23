using AutoMapper;
using EDocument_Data.DTOs.Department;
using EDocument_Data.DTOs.Role;
using EDocument_Data.Models;
using EDocument_Data.Models.Shared;
using EDocument_Reposatories.Generic_Reposatories;
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
        private readonly IGenericRepository<Department> _repository;
        private readonly ILogger<DepartmentController> _logger;
        private readonly IMapper _mapper;

        public DepartmentController(IGenericRepository<Department> repository, ILogger<DepartmentController> logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
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
        public async Task<ActionResult> Get()
        {
            _logger.LogInformation($"Start Get from {nameof(DepartmentController)}");
            var departments = await _repository.GetAllAsync();
            var displayedDepartments = _mapper.Map<List<DepartmentReadDto>>(departments); 

            return Ok(new ApiResponse<List<DepartmentReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = displayedDepartments });
        }
    }
}
