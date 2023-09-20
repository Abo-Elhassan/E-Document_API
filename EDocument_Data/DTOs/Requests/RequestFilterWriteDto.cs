using EDocument_Data.Consts.Enums;
using EDocument_Data.DTOs.Filter;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.Requests
{
    public class RequestFilterWriteDto : FilterWriteDto
    {

        [Required]
        public RequestPermission Permission { get; set; }


    }

    public class DynamicRequestFilterWriteDto : DynamicFilterWriteDto
    {

        [Required]
        [StringLength(50)]
        public required string CreatorId { get; init; }
    }
}
