using EDocument_Data.Consts.Enums;
using EDocument_Data.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.Filter
{

    public class FilterDto
    {
        public int? PageNo { get; set; } = 1;
        public int? PageSize { get; set; } = 10;
        public string? orderBy { get; set; }
        public OrderBy? orderByDirection { get; set; }
        public DateFilter[]? dateFilters { get; set; }

    }
    public class FilterWriteDto:FilterDto
    {
        public Dictionary<string, string>? Filters { get; set; }

    }

    public class DynamicFilterWriteDto : FilterDto
    {
        [Required]
        public required string filterValue { get; init; }

    }

 
}
