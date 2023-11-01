using EDocument_Data.Consts;
using EDocument_Data.Consts.Enums;
using EDocument_Data.DTOs.User;
using EDocument_Data.Models;
using EDocument_Data.Models.Shared;
using EDocument_EF;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Text;

namespace EDocument_Services.Auth_Service
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<User> _userManager;
        private readonly IOptions<JwtSettings> _jwtSettings;
        private readonly ApplicationDbContext _context;

        public AuthService(UserManager<User> userManager, IOptions<JwtSettings> jwtSettings, ApplicationDbContext context)
        {
            _userManager = userManager;
            _jwtSettings = jwtSettings;
            _context = context;
        }

        #region Token Creation

        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(ApplicationConsts.SecretKey ?? ""));
        }

        private async Task<JwtSecurityToken> CreateJwtToken(User user)
        {
            var roles = await _userManager.GetRolesAsync(user);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.NameIdentifier, user.Id)
            };

            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var signingCredentials = new SigningCredentials(GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _jwtSettings.Value.Issuer,
                audience: _jwtSettings.Value.Audience,
                claims: claims,
                expires: DateTime.Now.AddDays(_jwtSettings.Value.DurationInDays),
                signingCredentials: signingCredentials);

            return jwtSecurityToken;
        }

        #endregion Token Creation

        #region Handle Authentication

        public async Task<ActionResult> AuthenticatUserAsync( LoginWriteDto loginWriteDto)
        {

         
            var user = await _context.Users
                            .Include(u => u.Department)
                            .Include(u => u.Section)
                            .FirstOrDefaultAsync(u => u.UserName == loginWriteDto.UserName);

            if (user is null)
            {
                return new NotFoundObjectResult(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "User not found" });
            }

            bool isLockedOut = await _userManager.IsLockedOutAsync(user);

            if (isLockedOut)
            {
                return new BadRequestObjectResult(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = $"User: ({loginWriteDto.UserName}) is locked, Please Contact DPWS IT Team" });
            }

            var result = user.HasLDAP ? AuthenticatEmpolyeeAsync(loginWriteDto, user).Result : AuthenticatGuestAsync(loginWriteDto, user, isLockedOut).Result;
            _context.SaveChangesAsync();

            return result;
        }

        private async Task<ActionResult> AuthenticatEmpolyeeAsync(LoginWriteDto loginWriteDto, User user)
        {

            try
            {
                //var result = Authentication.IsUserAuthenticated(ApplicationConsts.ADDomain, loginWriteDto.UserName, loginWriteDto.Password);
                //if (!result.IsAuthenticated)
                //{

                //    return new BadRequestObjectResult(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = result.Message });
                //}

                await _userManager.ResetAccessFailedCountAsync(user);

                var userRoles = await _userManager.GetRolesAsync(user);

                if (userRoles.Count == 0) return new NotFoundObjectResult(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"{loginWriteDto.UserName} roles not found" });

                var userDetails = await GetUserDetails(user);

                if (userDetails.MenuContents.Count == 0) return new NotFoundObjectResult(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "There are no available requests" });

                user.LastLogin = DateTime.Now;

                return new OkObjectResult(new ApiResponse<LoginReadDto> { StatusCode = (int)HttpStatusCode.OK, Details = userDetails });
            }
            catch (COMException)
            {

                return new BadRequestObjectResult(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = $"Usermame or Password is incorrect" });
            }
          
         
        }

        private async Task<ActionResult> AuthenticatGuestAsync(LoginWriteDto loginWriteDto, User user, bool isLockedOut)
        {
            var correctPassword = await _userManager.CheckPasswordAsync(user, loginWriteDto.Password);

            if (!correctPassword) return await HandleWrongLoginAttempt(user, isLockedOut);

            await _userManager.ResetAccessFailedCountAsync(user);

            var userRoles = await _userManager.GetRolesAsync(user);

            if (userRoles.Count == 0) return new NotFoundObjectResult(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = $"{loginWriteDto.UserName} roles not found" });

            var userDetails = await GetUserDetails(user);

            if (userDetails.MenuContents.Count == 0) return new NotFoundObjectResult(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "There are no available requests" });

            user.LastLogin = DateTime.Now;

            return new OkObjectResult(new ApiResponse<LoginReadDto> { StatusCode = (int)HttpStatusCode.OK, Details = userDetails });
        }

        private async Task<ActionResult> HandleWrongLoginAttempt(User user, bool isLockedOut)
        {
            var accessFailedCount = await _userManager.GetAccessFailedCountAsync(user);

            if (!isLockedOut)
            {
                await _userManager.AccessFailedAsync(user);
            }

            if (accessFailedCount == 2&& !user.HasLDAP)
            {
                await _userManager.SetLockoutEnabledAsync(user, true);

                return new BadRequestObjectResult(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = $"User: ({user.UserName}) is locked on E-Document, Please Contact DPWS IT Team" });
            }

            return new BadRequestObjectResult(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.BadRequest, Details = $"Usermame or Password is incorrect, you have another {3 - (accessFailedCount + 1)} attempts" });
        }

        private async Task<LoginReadDto> GetUserDetails(User user)
        {
            var jwtSecurityToken = await CreateJwtToken(user);
            var userRoles = _userManager.GetRolesAsync(user).Result.ToList();

            var userDetails = new LoginReadDto
            {
                UserId = user.Id,
                UserName = user.UserName,
                FullName = user.FullName,
                PhoneNumber = user?.PhoneNumber ?? "",
                Position = user?.Position ?? "",
                Department = user?.Department?.DepartmentName ?? "",
                Section = user?.Section?.SectionName ?? "",
                Company = user?.Company,
                HasLDAP = user?.HasLDAP ?? true,
                Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken),
                TokenExpiryDate = DateTime.Parse(DateTime.Now.AddDays(_jwtSettings.Value.DurationInDays).ToString("yyyy-MM-dd HH:mm:ss")),
                Roles = userRoles,
                MenuContents = GetMenuContents(user).Result
            };
            return userDetails;
        }

        private async Task<List<MenuContent>> GetMenuContents(User user)
        {
            var menuContents = new List<MenuContent>();

            var availableRequests = await _context.DefinedRequestRoles.Include(x => x.Role).Include(y => y.DefinedRequest).ToListAsync();
            var filteredRequests = availableRequests.Where(d => _userManager.IsInRoleAsync(user, d.Role.Name ?? "").Result)
                .Select(r => new { r.DefinedRequestId, r.DefinedRequest.RequestName, r.DefinedRequest.RouteName, r.DefinedRequest.DepartmentId, r.Permission }).ToList();

            var departments = _context.Departments.Select(d => new { d.Id, d.DepartmentName, d.DepartmentIcon }).ToList();

            foreach (var department in departments)
            {
                var menuContent = new MenuContent();
                var displayedRequests = new List<DisplayedRequest>();

                foreach (var request in filteredRequests)
                {
                    if (department.Id == request.DepartmentId)
                    {
                        menuContent.Department = department.DepartmentName;
                        menuContent.Icon = department.DepartmentIcon;

                        var displayedRequest = new DisplayedRequest();
                        var requestDdl = new List<RequestDdlContent>();

                        if (!displayedRequests.Any(r=>r.DefinedRequestId == request.DefinedRequestId))
                        {
                            displayedRequest.DefinedRequestId = request.DefinedRequestId;
                            displayedRequest.DefinedRequestName = request.RequestName;

                            if (request.Permission == RequestPermission.All)
                            {
                                requestDdl = new List<RequestDdlContent>
                                {
                                    new RequestDdlContent
                                    {
                                        DisplayName = "Inbox",
                                        RouteName = $"{request.RouteName}Inbox",
                                    },
                                     new RequestDdlContent
                                    {
                                        DisplayName = "Assigned To Me",
                                        RouteName = $"{request.RouteName}AssignedToMe",
                                    }
                                };
                            }
                            else if (request.Permission == RequestPermission.Request)
                            {
                                requestDdl = new List<RequestDdlContent>
                                {
                                    new RequestDdlContent
                                    {
                                        DisplayName = "Inbox",
                                        RouteName = $"{request.RouteName}Inbox",
                                    }
                                };
                            }
                            else
                            {
                                requestDdl = new List<RequestDdlContent>
                                {
                                     new RequestDdlContent
                                    {
                                        DisplayName = "Assigned To Me",
                                        RouteName = $"{request.RouteName}AssignedToMe",
                                    }
                                };
                            }
                        }
                        else
                        {
                            var commondisplayedRequest = displayedRequests.FirstOrDefault(r => r.DefinedRequestId == request.DefinedRequestId);
                            if (request.Permission == RequestPermission.Request)
                            {
                                commondisplayedRequest.RequestDdl.Add(new RequestDdlContent
                                {
                                    DisplayName = "Inbox",
                                    RouteName = $"{request.RouteName}Inbox",
                                });
                              
                            }
                            else
                            {

                                commondisplayedRequest.RequestDdl.Add(new RequestDdlContent
                                {
                                    DisplayName = "Assigned To Me",
                                    RouteName = $"{request.RouteName}AssignedToMe",
                                });
                               
                            }
                        }


                       

                        displayedRequest.RequestDdl = requestDdl;
                        if (displayedRequest.RequestDdl.Count>0 && displayedRequest.DefinedRequestName!=null)
                        {
                            displayedRequests.Add(displayedRequest);
                        }
                      

                        menuContent.DisplayedRequests = displayedRequests;
                    }
                }

                if (menuContent.Department is not null)
                    menuContents.Add(menuContent);
            }

            return menuContents;
        }

        #endregion Handle Authentication
    }
}