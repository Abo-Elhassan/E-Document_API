using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.User
{
    public  class SearchUserDto
    {
        public required string Id { get; init; }
        public required string FullName { get; init; }
    }
}
