using EDocument_Data.Consts.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.Requests.ManliftReservationRequest
{
    public class ManliftReservationRequestCreateDto
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


        [Required]
        public long DefinedRequestId { get; init; }

    }
}
