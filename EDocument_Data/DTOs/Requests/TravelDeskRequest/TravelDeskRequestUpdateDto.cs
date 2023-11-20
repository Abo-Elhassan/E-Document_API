using EDocument_Data.Consts.Enums;
using EDocument_Data.Custom_Attributes;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.Requests.TravelDeskRequest
{
    public class TravelDeskRequestUpdateDto
    {
        [Required]
        public  long requestId { get; init; }

        [Required]
        public string BeneficiaryId { get; init; }

        public int? BeneficiaryExtention { get; init; }
        [Required]
        public string BeneficiaryNationality { get; init; }
        [Required]
        public string RequestType { get; init; }

        [Required]
        public string CostAllocation { get; init; }
        [OldDateValidator]
        public DateTime? CheckIn { get; init; }
        [OldDateValidator]
        public DateTime? CheckOut { get; init; }
        public string? MissionAddress { get; init; }
        public PaymentMethod? PaymentMethod { get; init; }
        public string? FlightOrigin { get; init; }
        public string? FlightDestination { get; init; }
        [OldDateValidator]
        public DateTime? DepartureDate { get; init; }
        [OldDateValidator]
        public DateTime? ReturnDate { get; init; }
        public string? DestinationCountry { get; init; }
        [OldDateValidator]
        public DateTime? ExpectedTravelTime { get; init; }

        [FileValidation(100 * 1024 * 1024, true, ".pdf", ".docx", ".xlsx", ".xls", ".csv", ".jpeg", ".zip", ".png", ".jpg")]
        public List<IFormFile>? Attachments { get; set; }
        [Required]
        public string Justification { get; set; }

    }
}
