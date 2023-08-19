using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.User
{
    public record struct LoginReadDto( string UserId, string UserName, string Role, string Token, DateTime TokenExpiryDate);

}
