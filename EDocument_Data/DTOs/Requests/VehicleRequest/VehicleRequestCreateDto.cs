using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.Requests.VehicleRequest
{
    public class VehicleRequestCreateDto
    {
        [Required] 
        public  string BeneficiaryId { get; init; }
        [Required]
        public  string BeneficiaryName { get; init; }

        public  string? BeneficiaryEmail { get; init; }
        [Required]
        public string BeneficiaryPosition { get; init; }
        [Required]
        public string BeneficiaryDepartment { get; init; }

        public string? BeneficiaryPhoneNumber { get; init; }

        public string? BeneficiaryExtention { get; init; }
        [Required]
        public string DepartureAddress { get; init; }
        [Required]
        public string DestinationAddress { get; init; }
        [Required]
        public DateTime DepartureDate { get; init; }
        [Required]
        public DateTime ReturnDate { get; init; }
        [Required]
        public string LuggageDescription { get; init; }
        [Required]
        public string VehicleType { get; init; }

        [FileValidation(10 * 1024 * 1024,true, ".pdf", ".docx", ".xlsx", ".xls",".csv",".rar",".zip")]
        public List<IFormFile>? Attachments { get; set; }
        [Required]
        public string Justification { get; set; }

        [Required]
        public long DefinedRequestId { get; init; }
    }
}
