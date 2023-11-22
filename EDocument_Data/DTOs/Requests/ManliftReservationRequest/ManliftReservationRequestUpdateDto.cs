using EDocument_Data.Consts.Enums;
using EDocument_Data.Custom_Attributes;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;


namespace EDocument_Data.DTOs.Requests.ManliftReservationRequest
{
    public class ManliftReservationRequestUpdateDto
    {

        [Required]
        public string ManliftNumber { get; init; }
        [Required]
        public string WorkingArea { get; init; }
        [Required]
        [OldDateValidator]
        public DateTime RequestedFrom { get; init; }
        [Required]
        [OldDateValidator]
        public DateTime RequestedTo { get; init; }
        [Required]
        public string BeneficiaryId { get; init; }


        public string? Notes { get; init; }

    }
}
