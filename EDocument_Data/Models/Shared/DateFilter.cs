using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.Models.Shared
{
    public record struct DateFilter
    {
        public required string ColumnName { get; set; }
        public required DateTime From { get; set; }
        public required DateTime To { get; set; }

    }

}
