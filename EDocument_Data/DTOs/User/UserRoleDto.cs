using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.User
{
    public class UserRoleDto
    {
        public required string UserId { get; init; }
        public required List<string> Roles { get; init; }
    }
}
