using EDocument_Data.Consts.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.Requests.TravelDeskRequest
{
    public class TravelDeskRequestCreateDto
    {
        [Required] 
        public  string BeneficiaryId { get; init; }
   
        public string? BeneficiaryExtention { get; init; }
        [Required]
        public string BeneficiaryNationality { get; init; }
        [Required]
        public string RequestType { get; init; }
        [Required]
        public string CostAllocation { get; init; }
        public DateTime? CheckIn { get; init; }
        public DateTime? CheckOut { get; init; }
        public string? MissionAddress { get; init; }
        public PaymentMethod? PaymentMethod { get; init; }
        public string? FlightOrigin { get; init; }
        public string? FlightDestination { get; init; }
        public DateTime? DepartureDate { get; init; }
        public DateTime? ReturnDate { get; init; }
        public string? DestinationCountry { get; init; }
        public DateTime? ExpectedTravelTime { get; init; }

        [FileValidation(10 * 1024 * 1024, true, ".pdf", ".docx", ".xlsx", ".xls", ".csv", ".rar", ".zip", ".png", ".jpg")]
        public List<IFormFile>? Attachments { get; set; }
        [Required]
        public string Justification { get; set; }

        [Required]
        public long DefinedRequestId { get; init; }
    }
}
