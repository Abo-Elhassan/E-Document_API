using EDocument_Data.Consts.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.Filter
{
    public class RequestFilterWriteDto : FilterWriteDto
    {

        [Required]
        public RequestPermission Permission { get; set; }


    }


}
