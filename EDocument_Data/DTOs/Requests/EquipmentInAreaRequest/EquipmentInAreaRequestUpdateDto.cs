using EDocument_Data.Custom_Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.Requests.EquipmentInAreaRequest
{
    public  class EquipmentInAreaRequestUpdateDto
    {
        [Required]
        public string CommunicationFacility { get; init; }


        [Required]
        public string Area { get; init; }

        [Required]
        public string EquipmentType { get; init; }

        [Required]
        public DateTime RequestedDateFrom { get; init; }

        [Required]
        public DateTime RequestedDateTo { get; init; }

        public string? Additionaltools { get; init; }

        [Required]
        public string SupervisorId { get; init; }
        [Required]
        public string SupervisorName { get; init; }

        public string? SupervisorPhoneNumber { get; init; }




    }
}
