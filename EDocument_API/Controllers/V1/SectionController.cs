using AutoMapper;
using EDocument_Data.DTOs.Department;
using EDocument_Data.DTOs.Role;
using EDocument_Data.DTOs.Section;
using EDocument_Data.Models;
using EDocument_Data.Models.Shared;
using EDocument_Reposatories.Generic_Reposatories;
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
        private readonly IGenericRepository<Section> _repository;
        private readonly ILogger<SectionController> _logger;
        private readonly IMapper _mapper;

        public SectionController(IGenericRepository<Section> repository, ILogger<SectionController> logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
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
        [Authorize]
        public async Task<ActionResult> Get()
        {
            _logger.LogInformation($"Start Get from {nameof(SectionController)}");
            var sections = await _repository.GetAllAsync();
            var displayedSections = _mapper.Map<List<SectionReadDto>>(sections);

            return Ok(new ApiResponse<List<SectionReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = displayedSections });
        }
    }
}
