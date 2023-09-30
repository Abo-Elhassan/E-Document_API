using AutoMapper;
using Azure;
using EDocument_Data.DTOs;
using EDocument_Data.DTOs.Filter;
using EDocument_Data.DTOs.Requests;
using EDocument_Data.DTOs.Role;
using EDocument_Data.DTOs.User;
using EDocument_Data.Models;
using EDocument_Data.Models.Shared;
using EDocument_Services.Auth_Service;
using EDocument_Services.Helpers;
using EDocument_UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Printing;
using System.Net;
using System.Net.Mime;
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
    public class UserController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly IMapper _mapper;
        private readonly ILogger<UserController> _logger;
        private readonly IAuthService _authService;
        private readonly IUnitOfWork _unitOfWork;

        public UserController(ILogger<UserController> logger, UserManager<User> userManager, RoleManager<Role> roleManager, IMapper mapper, IAuthService authService, IUnitOfWork unitOfWork)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _mapper = mapper;
            _logger = logger;
            _authService = authService;
            _unitOfWork = unitOfWork;
        }


        /// <summary>
        /// Get User By user Id
        /// </summary>
        /// <param name="id">user information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>User Details</returns>

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<UserReadSearchDto>))]
        [HttpGet("{id}")]
        public async Task<ActionResult> GetUserById(string id)
        {
            _logger.LogInformation($"Start GetUserById from {nameof(UserController)} for userId = {id}");


            var userDetails = await _userManager.Users.Include(t => t.Department).Include(t => t.Section).Select(u => new UserReadSearchDto
            {
                Id = u.Id,
                FullName = u.FullName,
                Email = u.Email,
                PhoneNumber = u.PhoneNumber,
                Postion = u.Position,
                Department = u.Department.DepartmentName,
                Section = u.Section.SectionName
            }).FirstOrDefaultAsync(u => u.Id == id);

            if(userDetails == null) return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "User not found" });


            return Ok(new ApiResponse<UserReadSearchDto> { StatusCode = (int)HttpStatusCode.OK, Details = userDetails });
        }

           

      


        /// <summary>
        /// Get User Roles By user Id
        /// </summary>
        /// <param name="id">user roles information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of All User roles</returns>

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<UserRoleReadDto>))]
        [HttpGet("Role/{id}")]
        public async Task<ActionResult> GetUserRolesById(string id)
        {
            _logger.LogInformation($"Start GetUserRolesById from {nameof(UserController)}");

            var user = await _userManager.FindByIdAsync(id);

            if (user is null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "User Not found" });


            var roles = await _roleManager.Roles.ToListAsync();

            var userRoles = new UserRoleReadDto
            {
                UserId = id,
                Roles = roles.Select(role => new RoleReadDto
                {
                    RoleId = role.Id,
                    RoleName = role.Name!,
                    IsGranted = _userManager.IsInRoleAsync(user, role.Name!).Result
                }).ToList()
            };
         

            return Ok(new ApiResponse<UserRoleReadDto> { StatusCode = (int)HttpStatusCode.OK, Details = userRoles });

        }

        /// <summary>
        /// Get All Users With Filter
        /// </summary>
        /// <param name="filterDto">filter information</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of All Users</returns>

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FilterReadDto<UserReadDto>>))]
        [HttpPost("Filter")]
        public async Task<ActionResult> GetFiltered(FilterWriteDto? filterDto)
        {
            _logger.LogInformation($"Start GetFiltered from {nameof(UserController)}");
            var includes = new string[] { nameof(Department), nameof(Section) };

            (int TotalCount, IEnumerable<User> PaginatedData) result;


            if (filterDto?.Filters != null)
            {
                result = await _unitOfWork.Repository<User>().FindAllAsync(
                filters: filterDto?.Filters,
                includes: includes,
                skip: (filterDto?.PageNo - 1) * filterDto?.PageSize,
                take: filterDto?.PageSize,
                orderBy: filterDto?.orderBy,
                orderByDirection: filterDto?.orderByDirection,
                dateFilters: filterDto?.dateFilters
                );

            }
            else if (filterDto?.FilterValue != null)
            {
                result = await _unitOfWork.Repository<User>().FindAllAsync(
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
                result = await _unitOfWork.Repository<User>().FindAllAsync(
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

            var users = _mapper.Map<List<UserReadDto>>(result.PaginatedData);
            var roles = await _roleManager.Roles.ToListAsync();

            foreach (var user in users)
            {
                var mappedUser = _mapper.Map<User>(user);
                var userRoles = await _userManager.GetRolesAsync(mappedUser);
                user.Roles = string.Join(",", userRoles);
            }

            var response = new FilterReadDto<UserReadDto>
                {
                    TotalCount = totalCount,
                    TotalPages = totalPages,
                    CurrentPage = filterDto?.PageNo ?? 1,
                    PageSize = users.Count,
                    PaginatedData = users
                };
                         
            return Ok(new ApiResponse<FilterReadDto<UserReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = response });
        }



     


        /// <summary>
        /// Get All Filtered Users by Id/FullName
        /// </summary>
        /// <param name="searchValue"> user Id or full name</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>List of Filtered Users</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<List<UserReadSearchDto>>))]
        [HttpGet("Search/{searchValue}")]
        public async Task<ActionResult> Search(string? searchValue)
        {
            _logger.LogInformation($"Start Search from {nameof(UserController)} for searchValue = {searchValue} ");


            var users = new List<UserReadSearchDto>();
            if (string.IsNullOrEmpty(searchValue))
            {
                users = await _userManager.Users.Include(t => t.Department).Include(t => t.Section).Select(u => new UserReadSearchDto
                {
                    Id = u.Id,
                    FullName = u.FullName,
                    Email = u.Email,
                    PhoneNumber = u.PhoneNumber,
                    Postion = u.Position,
                    Department = u.Department.DepartmentName,
                    Section = u.Section.SectionName
                }).ToListAsync();

            }
            else if (int.TryParse(searchValue, out int result) || searchValue.Contains("Exp-"))
            {
                users = await _userManager.Users.Include(t => t.Department).Include(t => t.Section).Where(u => u.Id.Contains(searchValue)).Select(u => new UserReadSearchDto
                {
                    Id = u.Id,
                    FullName = u.FullName,
                    Email = u.Email,
                    PhoneNumber = u.PhoneNumber,
                    Postion = u.Position,
                    Department = u.Department.DepartmentName,
                    Section = u.Section.SectionName
                }).ToListAsync();

            }
            else
            {
                users = await _userManager.Users.Include(t => t.Department).Include(t => t.Section).Where(u => u.FullName.Contains(searchValue)).Select(u => new UserReadSearchDto
                {
                    Id = u.Id,
                    FullName = u.FullName,
                    Email = u.Email,
                    PhoneNumber = u.PhoneNumber,
                    Postion = u.Position,
                    Department = u.Department.DepartmentName,
                    Section = u.Section.SectionName
                }).ToListAsync();
            }
            return Ok(new ApiResponse<List<UserReadSearchDto>> { StatusCode = (int)HttpStatusCode.OK, Details = users });
        }


        /// <summary>
        /// Create new user
        /// </summary>
        /// <param name="createUserDto">User Informarion</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns> message</returns>

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<string>))]
        [HttpPost("Create")]
        public async Task<ActionResult> Create(CreateUserDto createUserDto)
        {
            _logger.LogInformation($"Start create user from {nameof(UserController)} for {JsonSerializer.Serialize(createUserDto.UserName)} ");

            
            var newUser = _mapper.Map<User>(createUserDto);
            newUser.LockoutEnabled = false;

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

            var user =await _userManager.FindByIdAsync(id);

            if (user == null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"User '{id}' not found" });

            var newUser = _mapper.Map<User>(userWriteDto);
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
        public async Task<ActionResult> ManageUserRoles(UserRoleWriteDto userRoleDto)
        {
            _logger.LogInformation($"Start ManageUserRoles from {nameof(UserController)} for {JsonSerializer.Serialize(userRoleDto)} ");

            var user = await _userManager.FindByIdAsync(userRoleDto.UserId);

            if (user == null)
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"user: ({userRoleDto.UserId}) not found" });

            foreach (var role in userRoleDto.Roles)
            {
                if (!_roleManager.RoleExistsAsync(role).Result)
                {
                    return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"Role: '{role}' not found" });
                }
            }


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

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<List<LockedUserReadDto>>))]
        [HttpGet("Locked")]
        public async Task<ActionResult> GetLockedUsers()
        {
            _logger.LogInformation($"Start GetLockedUsers from {nameof(UserController)}");
            var lockedUsers = await _userManager.Users.Where(u => u.LockoutEnabled).ToListAsync();

            var dispalyedLockedUsers = _mapper.Map<List<User>, List<LockedUserReadDto>>(lockedUsers);

            return Ok(new ApiResponse<List<LockedUserReadDto>> { StatusCode = (int)HttpStatusCode.OK, Details = dispalyedLockedUsers });
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
        [HttpPost("Locked/{id}")]
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
            await _userManager.SetLockoutEnabledAsync(user, false);

            return Ok(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.OK, Details = $"user: ({id}) has been unlocked successfully" });
        }
    }
}