using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.Requests.VehicleRequest
{
    public class VehicleRequestUpdateDto
    {
        [Required]
        public  long requestId { get; init; }

        [Required]
        public string BeneficiaryId { get; init; }
        public int? BeneficiaryExtention { get; init; }
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

        [FileValidation(100 * 1024 * 1024, true, ".pdf", ".docx", ".xlsx", ".xls", ".csv", ".rar", ".zip",".png",".jpg",".jpeg")]
        public List<IFormFile>? Attachments { get; set; }
        [Required]
        public string Justification { get; set; }

    }
}
