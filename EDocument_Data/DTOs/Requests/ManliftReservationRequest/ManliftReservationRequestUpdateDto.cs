using EDocument_Data.Consts.Enums;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;


namespace EDocument_Data.DTOs.Requests.ManliftReservationRequest
{
    public class ManliftReservationRequestUpdateDto
    {

        [Required]
        public string ManliftNumber { get; init; }
        [Required]
        public DateTime RequestedFrom { get; init; }
        [Required]
        public DateTime RequestedTo { get; init; }
        [Required]
        public string SupervisorId { get; init; }

        public string? Notes { get; init; }

    }
}
