using EDocument_Data.DTOs.Role;
using EDocument_Data.DTOs.User;
using EDocument_Data.Models;
using EDocument_Data.Models.Shared;
using EDocument_EF;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Net.Mime;
using System.Text.Json;

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
    public class RoleController : ControllerBase
    {
        private readonly RoleManager<Role> _roleManager;
        private readonly ILogger<RoleController> _logger;
        private readonly ApplicationDbContext _context;

        public RoleController(RoleManager<Role> roleManager, ILogger<RoleController> logger,ApplicationDbContext context)
        {
            _roleManager = roleManager;
            _logger = logger;
            _context = context;
        }

        /// <summary>
        /// Get All E-Document Roles
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of E-Document Role</returns>

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<List<RoleWriteDto>>))]
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            _logger.LogInformation($"Start Get from {nameof(RoleController)}");
            var roles = await _roleManager.Roles.Select(r => new RoleWriteDto { Id = r.Id, Name = r.Name! }).ToListAsync();


            return Ok(new ApiResponse<List<RoleWriteDto>> { StatusCode = (int)HttpStatusCode.OK, Details = roles });
        }

        /// <summary>
        /// Add new E-Docuement role
        /// </summary>
        /// <param name="role">roleId and roleName</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>message</returns>

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<List<string>>))]

        [HttpPost]
        public async Task<ActionResult> Add(RoleWriteDto role)
        {
            _logger.LogInformation($"Start Add from {nameof(RoleController)} for {JsonSerializer.Serialize(role)}");

            if (_roleManager.RoleExistsAsync(role.Name).Result)
                return BadRequest(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = $"Role '{role.Name}' already exists" });


            var createResult = await _roleManager.CreateAsync(new Role { Id = role.Id, Name = role.Name });
            if (!createResult.Succeeded)
                return BadRequest(new ApiResponse<IEnumerable<dynamic>> { StatusCode = (int)HttpStatusCode.BadRequest, Details = createResult.Errors });


            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = "Role has been created successfully" });
        }


        /// <summary>
        /// Delete E-Docuement role
        /// </summary>
        /// <param name="role">roleId and roleName</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>message</returns>

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<List<string>>))]

        [HttpDelete]
        public async Task<ActionResult> Delete(RoleWriteDto role)
        {
            _logger.LogInformation($"Start Delete from {nameof(RoleController)} for role = {role.Name}");

            if (!_roleManager.RoleExistsAsync(role.Name).Result)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"Role '{role.Name}' not found" });



            var deleteResult = await _roleManager.DeleteAsync(new Role { Id = role.Id, Name=role.Name });
            if (!deleteResult.Succeeded)
             return BadRequest(new ApiResponse<IEnumerable<dynamic>> { StatusCode = (int)HttpStatusCode.BadRequest, Details = deleteResult.Errors });
            

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = "Role has been Deleted successfully" });
        } 
    }
}
