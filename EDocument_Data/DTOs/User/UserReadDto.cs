using EDocument_Data.DTOs.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.User
{
    public class UserReadDto
    {
        public required string Id { get; init; }
        public required string UserName { get; init; }
        public required string FullName { get; init; }
        public  string? Email { get; init; }
        public  string? PhoneNumber { get; init; }
        public  string? Position { get; init; }
        public  bool HasLDAP { get; init; }
        public  string? ManagerId { get; init; }
        public  long? DepartmentId { get; init; }
        public  string? DepartmentName { get; init; }
        public  long? SectionId { get; init; }
        public  string? SectionName { get; init; }
        public  string? Company { get; init; }
        public bool LockoutEnabled { get; init; }

        public  string? Roles { get; set; }
    }
}
