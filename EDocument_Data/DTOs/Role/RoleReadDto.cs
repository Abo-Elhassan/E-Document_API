using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.Role
{
    public record class RoleReadDto
    {
        public required string RoleId { get; init; }
        public required string RoleName { get; init; }
        public required bool IsGranted { get; set; }
    }
}
