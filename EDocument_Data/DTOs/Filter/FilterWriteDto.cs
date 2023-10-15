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

    public class FilterWriteDto
    {

        [Range(1, int.MaxValue, ErrorMessage = "PageNo must be greater than 0.")]
        public int? PageNo { get; set; } = 1;

        [Range(1, 100, ErrorMessage = "PageSize must be greater than 0 and less than 100.")]
        public int? PageSize { get; set; } = 10;
        public string? orderBy { get; set; }
        public OrderBy? orderByDirection { get; set; }
        public DateFilter[]? dateFilters { get; set; }
        public Dictionary<string, string>? Filters { get; set; }
        public string? FilterValue { get; init; }

    }

 
}
