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
        public  string ColumnName { get; set; }
        public  DateTime? From { get; set; }
        public  DateTime? To { get; set; }

    }

}
