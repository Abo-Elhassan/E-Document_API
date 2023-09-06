using EDocument_Data.Consts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.User
{
    public record struct UserRoleDto(string UserId, ApplicationRole Role);

}
