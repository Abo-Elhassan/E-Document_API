using EDocument_Data.DTOs.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Services.Auth_Service
{
    public interface IAuthService
    {
        Task<(bool Succeeded, string Message, LoginReadDto? LoginReadDto)> AuthenticatUserAsync(LoginWriteDto loginWriteDto);
        Task<(bool Succeeded, string Message)> AddRoleAsync(UserRoleDto userRole);
    }
}
