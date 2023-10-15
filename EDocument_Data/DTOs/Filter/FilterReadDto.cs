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
    public class FilterReadDto<T> where T : class
    {
        public int TotalCount { get; init; }
        public int TotalPages { get; init; }
        public int? CurrentPage { get; init; }
        public int? PageSize { get; init; }
        public required List<T> PaginatedData { get; init; }


    }

}
