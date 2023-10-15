using AutoMapper;
using EDocument_Data.DTOs.Department;
using EDocument_Data.DTOs.Role;
using EDocument_Data.DTOs.Section;
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
    public class SectionController : ControllerBase
    {
     
        private readonly ILogger<SectionController> _logger;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<User> _userManager;

        public SectionController( ILogger<SectionController> logger, IMapper mapper ,IUnitOfWork unitOfWork, UserManager<User> userManager)
        {
     
            _logger = logger;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }

        /// <summary>
        /// Get All Sections
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of Sections</returns>

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<List<SectionReadDto>>))]
        [HttpGet]
        [Authorize(Roles = "Basic")]
        public async Task<ActionResult> Get()
        {
            _logger.LogInformation($"Start Get from {nameof(SectionController)}");
            var sections = await _unitOfWork.Repository<Section>().GetAllAsync();
            var displayedSections = _mapper.Map<List<SectionReadDto>>(sections);

            return Ok(new ApiResponse<List<SectionReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = displayedSections });
        }

        /// <summary>
        /// Update section head
        /// </summary>
        /// <param name="id">section id</param>
        /// <param name="headId">section head id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>message</returns>

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("{id}/{headId}")]
        [Authorize(Roles = "SysAdmin")]
        public async Task<ActionResult> Update(long id, string headId)
        {
            _logger.LogInformation($"Start Update from {nameof(SectionController)}");
            var section = await _unitOfWork.Repository<Section>().GetByIdAsync(id);

            if (section == null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = "Section not found" });

            var head = await _userManager.FindByIdAsync(headId);

            if (head == null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = "Head Id not found" });

            section.HeadId = headId;
            section.ModifiedBy = _userManager.FindByNameAsync(User?.Identity?.Name)?.Result?.FullName;

            _unitOfWork.Complete();

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = "Section head has been updated successfully" });
        }
    }
}
