using AutoMapper;
using EDocument_Data.DTOs.Role;
using EDocument_Data.DTOs.User;
using EDocument_Data.Models;
using EDocument_Data.Models.Shared;
using EDocument_Services.Auth_Service;
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
        /// Get All Users
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of All Users</returns>

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<List<UserReadDto>>))]
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            _logger.LogInformation($"Start Get from {nameof(UserController)}");

            var users = await _userManager.Users.ToListAsync();
            var roles = await _roleManager.Roles.ToListAsync();

            var displayedUsers = _mapper.Map<List<UserReadDto>>(users);
            foreach (var user in displayedUsers)
            {
                var mappedUser = _mapper.Map<User>(user);
                user.Roles = roles.Select(role => new RoleReadDto
                {
                    RoleId = role.Id,
                    RoleName = role.Name!,
                    IsGranted = _userManager.IsInRoleAsync(mappedUser, role.Name!).Result
                }).ToList();
            }
            return Ok(new ApiResponse<List<UserReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = displayedUsers });
        }


        /// <summary>
        /// Get All Filtered Users
        /// </summary>
        /// <param name="filterValue"></param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of Filtered Users</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<List<UserReadDto>>))]
        [HttpGet("{filterValue}")]
        public async Task<ActionResult> GetFilterd(string filterValue)
        {
            _logger.LogInformation($"Start GetFilterd from {nameof(UserController)} for filterValue = {filterValue} ");

            var users = new List<User>();

            if (int.TryParse(filterValue, out int result)|| filterValue.Contains("Exp-"))
            {
                users = await _userManager.Users.Where(u => u.Id.Contains(filterValue)).ToListAsync();
            }
            else
            {
                users = await _userManager.Users.Where(u => u.FullName.Contains(filterValue)).ToListAsync();
            }
            
            var roles = await _roleManager.Roles.ToListAsync();

            var displayedUsers = _mapper.Map<List<UserReadDto>>(users);
            foreach (var user in displayedUsers)
            {
                var mappedUser = _mapper.Map<User>(user);
                user.Roles = roles.Select(role => new RoleReadDto
                {
                    RoleId = role.Id,
                    RoleName = role.Name!,
                    IsGranted = _userManager.IsInRoleAsync(mappedUser, role.Name!).Result
                }).ToList();
            }
            return Ok(new ApiResponse<List<UserReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = displayedUsers });
        }

        /// <summary>
        /// Add new user
        /// </summary>
        /// <param name="createUserDto">User Informarion</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult> Add(CreateUserDto createUserDto)
        {
            _logger.LogInformation($"Start Add user from {nameof(UserController)} for {JsonSerializer.Serialize(createUserDto.UserName)} ");

            var newUser = _mapper.Map<User>(createUserDto);
            newUser.CreatedAt = DateTime.Now;
            newUser.CreatedBy = User?.Identity?.Name;

            var createResult = await _userManager.CreateAsync(newUser, createUserDto.Password);
            if (!createResult.Succeeded)
            {
                return BadRequest(new ApiResponse<IEnumerable<dynamic>> { StatusCode = (int)HttpStatusCode.BadRequest, Details = createResult.Errors });
            }

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = "User has been created successfully" });
        }

        /// <summary>
        /// Edit user information
        /// </summary>
        ///<param name="id">User id</param>
        /// <param name="userWriteDto">User Informarion</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>message</returns>

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(string id, UserWriteDto userWriteDto)
        {
            _logger.LogInformation($"Start Update from {nameof(UserController)} for {JsonSerializer.Serialize(userWriteDto.UserName)} ");

            var user = _userManager.FindByIdAsync(id);

            if (user == null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"User '{id}' not found" });

            var newUser = _mapper.Map<User>(userWriteDto);
            newUser.ModifiedAt = DateTime.Now;
            newUser.ModifiedBy = User?.Identity?.Name;

            var updateResult = await _userManager.UpdateAsync(newUser);

            if (!updateResult.Succeeded)
                return BadRequest(new ApiResponse<IEnumerable<dynamic>> { StatusCode = (int)HttpStatusCode.BadRequest, Details = updateResult.Errors });

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = "User has been updated successfully" });
        }

        /// <summary>
        /// Add/Edit User Roles
        /// </summary>
        /// <param name="userRoleDto">User id with list of his roles</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>message</returns>

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPut("Role")]
        public async Task<ActionResult> ManageUserRoles(UserRoleDto userRoleDto)
        {
            _logger.LogInformation($"Start ManageUserRoles from {nameof(UserController)} for {JsonSerializer.Serialize(userRoleDto)} ");

            var user = await _userManager.FindByIdAsync(userRoleDto.UserId);

            if (user == null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"user: ({userRoleDto.UserId}) not found" });

            var userRoles = await _userManager.GetRolesAsync(user);

            var removeResult = await _userManager.RemoveFromRolesAsync(user, userRoles);
            if (removeResult.Succeeded)
            {
                var AddResult = await _userManager.AddToRolesAsync(user, userRoleDto.Roles);
                if (AddResult.Succeeded)
                {
                    return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = "User roles has been updated successfully" });
                }
                else
                {
                    return BadRequest(new ApiResponse<IEnumerable<dynamic>> { StatusCode = (int)HttpStatusCode.BadRequest, Details = AddResult.Errors });
                }
            }
            else
            {
                return BadRequest(new ApiResponse<IEnumerable<dynamic>> { StatusCode = (int)HttpStatusCode.BadRequest, Details = removeResult.Errors });
            }
        }

        /// <summary>
        /// User login
        /// </summary>
        /// <param name="loginWriteDto">Username and password</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPost("Login")]
        public async Task<ActionResult> Login(LoginWriteDto loginWriteDto)
        {
            _logger.LogInformation($"Start Login from {nameof(UserController)} for {loginWriteDto.UserName}");

            var result = await _authService.AuthenticatUserAsync(loginWriteDto);
            return result;
        }

        /// <summary>
        /// Get locked users
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of locked users</returns>

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<List<LockedUserDto>>))]
        [HttpGet("Unlock")]
        public async Task<ActionResult> GetLockedUsers()
        {
            _logger.LogInformation($"Start GetLockedUsers from {nameof(UserController)}");
            var lockedUsers = await _userManager.Users.Where(u => u.LockoutEnabled).Select(u => new LockedUserDto
            {
                Id = u.Id,
                UserName = u.UserName,
                FullName = u.FullName,
                Email = u.Email,
                PhoneNumber = u.PhoneNumber,
                Position = u.Position,
                Company = u.Company,
                IsEmployee = u.IsEmployee
            }).ToListAsync();

            return Ok(new ApiResponse<List<LockedUserDto>> { StatusCode = (int)HttpStatusCode.OK, Details = lockedUsers });
        }

        /// <summary>
        /// Unlock user
        /// </summary>
        /// <param name="id">user id</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPost("Unlock/{id}")]
        public async Task<ActionResult> UnlockUser(string id)
        {
            _logger.LogInformation($"Start UnlockUser from {nameof(UserController)} for '{id}'");
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"user: ({id}) not found" });
            }
            await _userManager.ResetAccessFailedCountAsync(user);
            await _userManager.SetLockoutEndDateAsync(user, null);

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"user: ({id}) has been unlocked successfully" });
        }
    }
}