﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.Department
{
    public record class DepartmentReadDto
    {
        public required long Id { get; init; }

        public required string DepartmentName { get; init; }
    }
}
