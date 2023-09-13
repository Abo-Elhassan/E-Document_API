using Azure;
using EDocument_API.Helpers;
using EDocument_Data.Consts;
using EDocument_Data.Consts.Enums;
using EDocument_Data.DTOs.User;
using EDocument_Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Text;

namespace EDocument_Services.Auth_Service
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<User> _userManager;
        private readonly IOptions<JwtSettings> _jwtSettings;
        private readonly ILogger<AuthService> _logger;

        public AuthService(UserManager<User> userManager, IOptions<JwtSettings> jwtSettings, ILogger<AuthService> logger)
        {
            _userManager = userManager;
            _jwtSettings = jwtSettings;
            _logger = logger;
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

        public async Task<(bool Succeeded, string Message, LoginReadDto? LoginReadDto)> AuthenticatUserAsync(LoginWriteDto loginWriteDto)
        {
            (bool Succeeded, string Message, LoginReadDto? LoginReadDto) response = (false, "", null);

            var user = await _userManager.FindByNameAsync(loginWriteDto.UserName);

            if (user is null)
            {
                response.Succeeded = false;
                response.Message = $"{loginWriteDto.UserName} Is Not Found as an eDocument User, Please Contact DPWS IT Team";
                return response;
            }

            bool isLockedOut = await _userManager.IsLockedOutAsync(user);

            if (isLockedOut)
            {
                response.Succeeded = false;
                response.Message = $"{loginWriteDto.UserName} is locked, Please Contact DPWS IT Team";
                return response;
            }

            var result = user.IsEmployee ? AuthenticatEmpolyeeAsync(loginWriteDto, user, isLockedOut).Result : AuthenticatGuestAsync(loginWriteDto, user, isLockedOut).Result;

            return result;
        }

        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(ApplicationConsts.SecretKey ?? ""));
        }

        private async Task<(bool Succeeded, string Message, LoginReadDto? LoginReadDto)> AuthenticatEmpolyeeAsync(LoginWriteDto loginWriteDto, User user, bool isLockedOut)
        {
            (bool Succeeded, string Message, LoginReadDto? LoginReadDto) response = (false, "", null);
            try
            {
                //Path to your LDAP directory server
                Authentication adAuth = new Authentication(ApplicationConsts.ADPath);
                if (!adAuth.IsAuthenticated(ApplicationConsts.ADDomain, loginWriteDto.UserName, loginWriteDto.Password))
                {
                    response.Succeeded = false;
                    response.Message = $"Usermame or Password is incorrect";
                    return response;
                }
                await _userManager.ResetAccessFailedCountAsync(user);

                var jwtSecurityToken = await CreateJwtToken(user);
                var userRoles = await _userManager.GetRolesAsync(user);

                if (userRoles is null)
                {
                    response.Succeeded = false;
                    response.Message = $"{loginWriteDto.UserName} roles not found";
                    return response;
                }
                response.Succeeded = true;
                response.Message = $"{loginWriteDto.UserName} has been logged in successfully";
                response.LoginReadDto = new LoginReadDto
                    (
                        UserId: user.Id,
                        UserName: user.NormalizedUserName,
                        Roles: userRoles.ToList(),
                        Token: new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken),
                        TokenExpiryDate: jwtSecurityToken.ValidTo
                );

                return response;
            }
            catch (COMException)
            {
                return await HandleWrongLoginAttempt(user, isLockedOut);
            }
        }

        private async Task<(bool Succeeded, string Message, LoginReadDto? LoginReadDto)> AuthenticatGuestAsync(LoginWriteDto loginWriteDto, User user, bool isLockedOut)
        {
            (bool Succeeded, string Message, LoginReadDto? LoginReadDto) response = (false, "", null);

           
            var correctPassword = await _userManager.CheckPasswordAsync(user,loginWriteDto.Password);

            if (!correctPassword)
            {
                return await HandleWrongLoginAttempt(user,isLockedOut);
            }



            await _userManager.ResetAccessFailedCountAsync(user);

            var jwtSecurityToken = await CreateJwtToken(user);
            var userRoles = await _userManager.GetRolesAsync(user);

            if (userRoles is null)
            {
                response.Succeeded = false;
                response.Message = $"{loginWriteDto.UserName} roles not found";
                return response;
            }
            response.Succeeded = true;
            response.Message = $"{loginWriteDto.UserName} has been logged in successfully";
            response.LoginReadDto = new LoginReadDto
                (
                    UserId: user.Id,
                    UserName: user.NormalizedUserName,
                   Roles: userRoles.ToList(),
                    Token: new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken),
                    TokenExpiryDate: jwtSecurityToken.ValidTo
            );

            return response;
        }

        private async Task<(bool Succeeded, string Message, LoginReadDto? LoginReadDto)> HandleWrongLoginAttempt( User user, bool isLockedOut)
        {
            (bool Succeeded, string Message, LoginReadDto? LoginReadDto) response = (false, "", null);

            var accessFailedCount = await _userManager.GetAccessFailedCountAsync(user);

            if (accessFailedCount == 2)
            {
                await _userManager.SetLockoutEnabledAsync(user, true);
            }

            if (!isLockedOut)
            {
                await _userManager.AccessFailedAsync(user);
            }

            response.Succeeded = false;
            response.Message = $"Usermame or Password is incorrect, you have another {3 - (accessFailedCount + 1)}  attempts";
            return response;
        }
    
        public async Task<(bool Succeeded, string Message)> AddRoleAsync(UserRoleDto userRole)
        {
            (bool Succeeded, string Message) response = (false, "");
            var user = await _userManager.FindByIdAsync(userRole.UserId);
            if (user is null)
            {
                response.Succeeded = false;
                response.Message = $"{userRole.UserId} Is Not Found as an eDocument User, Please Contact DPWS IT Team";
                return response;
            }

            var userClaims = await _userManager.GetClaimsAsync(user);
            if (userClaims.Contains(new Claim(nameof(ApplicationRole), userRole.Role.ToString())))
            {
                response.Succeeded = false;
                response.Message = $"{userRole.UserId} already has been granted {userRole.Role} role before";
                return response;
            }

            var addRoleResult = await _userManager.AddClaimAsync(user, new Claim(nameof(ApplicationRole), userRole.Role.ToString()));
            if (addRoleResult.Succeeded)
            {
                response.Succeeded = true;
                response.Message = $"{userRole.UserId} has been granted {userRole.Role} role successfully";
                return response;
            }
            else
            {
                response.Succeeded = false;
                response.Message = $"Granting {userRole.Role} role for {userRole.UserId} has been failed";
                return response;
            }
        }
    }
}