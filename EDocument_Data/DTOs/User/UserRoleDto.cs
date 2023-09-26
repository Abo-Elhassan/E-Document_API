using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.User
{
    public class UserRoleDto
    {
        [Required]
        public required string UserId { get; init; }
        [Required]
        public required List<string> Roles { get; init; }
    }
}
