using EDocument_Data.Consts.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.Requests.CCTVAccessRequest
{
    public class CCTVAccessRequestCreateDto
    {
   
        public string? BeneficiaryExtention { get; init; }

        [Required]
        public List<string> RequestedRoles { get; init; }

        public string? Notes { get; set; }


        [Required]
        public long DefinedRequestId { get; init; }

    }
}
