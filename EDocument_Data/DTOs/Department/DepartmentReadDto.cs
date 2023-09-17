using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.Department
{
    public record struct DepartmentReadDto
    {
        public required int DepartmentId { get; init; }

        public required string DepartmentName { get; init; }
    }
}
