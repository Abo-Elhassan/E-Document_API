using AutoMapper;
using EDocument_Data.DTOs.User;
using EDocument_Data.Models;
using EDocument_Data.Models.Shared;
using EDocument_Services.Auth_Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
    public class UserController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly IMapper _mapper;
        private readonly ILogger<UserController> _logger;
        private readonly IAuthService _authService;

        public UserController(ILogger<UserController> logger, UserManager<User> userManager, RoleManager<Role> roleManager, IMapper mapper, IAuthService authService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _mapper = mapper;
            _logger = logger;
            _authService = authService;
        }
        /// <summary>
        /// Add new user
        /// </summary>
        /// <param name="registerDto">User informarion</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>Nonw</returns>

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<UserReadDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiResponse<string>))]
        [ProducesResponseType(StatusCodes.Status404NotFound,Type=typeof(ApiResponse<string>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ApiResponse<string>))]
        //[Authorize]   
        [HttpPost("Register")]
        public async Task<ActionResult> Register(RegisterUserDto registerDto)
        {
            _logger.LogInformation($"Start register for {JsonSerializer.Serialize(registerDto.UserName)} ");

            var newUser = _mapper.Map<User>(registerDto);
            newUser.CreatedAt = DateTime.Now;
            newUser.CreatedBy = User?.Identity?.Name;

            var result = await _userManager.CreateAsync(newUser, registerDto.Password);
            if (!result.Succeeded)
            {
                return BadRequest(new ApiResponse<IEnumerable<dynamic>> { StatusCode = (int)HttpStatusCode.BadRequest, Details = result.Errors });
            }

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = "User has been created successfully" });
        }

        [HttpPost("Login")]
        public async Task<ActionResult> Login(UserWriteDto loginWriteDto)
        {
            _logger.LogInformation($"Login for {loginWriteDto.UserName}");

            var result = await _authService.AuthenticatUserAsync(loginWriteDto);
            return result;
        }

        [HttpPost("Unlock/{username}")]
        public async Task<ActionResult> UnlockUser(string username)
        {
            var user = await _userManager.FindByNameAsync(username);

            if (user == null)
            {
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"username: ({username}) not found" });
            }
            await _userManager.ResetAccessFailedCountAsync(user);
            await _userManager.SetLockoutEndDateAsync(user, null);

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"username: ({username}) has been unlocked successfully" });
        }
    }
}