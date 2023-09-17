#nullable disable
using EDocument_Data.Models.Shared;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.User
{
    public class LoginReadDto
    {
        public required string UserId { get; init; }
        public required string UserName { get; init; }
        public required string FullName { get; init; }
        public required string PhoneNumber { get; init; }
        public string Position { get; init; }
        public string Department { get; init; }
        public string Section { get; init; }
        public string Company { get; init; }
        public bool IsEmployee { get; init; }
        public  List<string> Roles { get; init; }
        public  ICollection<MenuContent> MenuContents { get; init; } = new HashSet<MenuContent>();
        public  string Token { get; init; }
        public  DateTime TokenExpiryDate { get; init; }

     


    }
     
}





