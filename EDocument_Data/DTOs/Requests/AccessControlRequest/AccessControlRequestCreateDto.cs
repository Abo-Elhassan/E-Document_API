using EDocument_Data.Consts.Enums;
using EDocument_Data.Custom_Attributes;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.Requests.AccessControlRequest
{
    public class AccessControlRequestCreateDto
    {
        [Required] 
        public  string BeneficiaryId { get; init; }
   
        public int? BeneficiaryExtention { get; init; }
        [Required]
        public List<string> AccessedBlocks { get; init; }
        [Required]
        public List<string> AccessMethods { get; init; }
        [Required]
        [FileValidation(2 * 1024 * 1024, ".png", ".jpg", ".jpeg")]
        public IFormFile EmployeeSignature { get; init; }
        
        public string? Notes { get; init; }

        [Required]
        public long DefinedRequestId { get; init; }
    }
}
