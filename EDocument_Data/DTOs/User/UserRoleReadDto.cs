using EDocument_Data.DTOs.Role;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.User
{
    public class UserRoleReadDto
    {

        public  string UserId { get; set; }

        public  List<RoleReadDto> Roles { get; set; }
    }
}
