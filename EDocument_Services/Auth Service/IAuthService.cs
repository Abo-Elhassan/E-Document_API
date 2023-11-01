using EDocument_Data.DTOs.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Services.Auth_Service
{
    public interface IAuthService
    {
        Task<ActionResult> AuthenticatUserAsync(LoginWriteDto loginWriteDto);
        
    }
}
