using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.User
{
    public  class UserReadSearchDto
    {
        public required string Id { get; init; }

        public required string FullName { get; init; }

        public  string? Email { get; init; }

        public required string Postion { get; init; }

        public required string Department { get; init; }

        public required string Section { get; init; }

        public  string? PhoneNumber { get; init; }

    }
}
