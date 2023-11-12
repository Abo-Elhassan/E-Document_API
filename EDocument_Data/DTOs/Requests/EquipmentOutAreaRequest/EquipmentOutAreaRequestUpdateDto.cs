using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.Requests.EquipmentOutAreaRequest
{
    public class EquipmentOutAreaRequestUpdateDto
    {
        [Required]
        public string CommunicationFacility { get; set; }


        [Required]
        public string OutConcessionArea { get; set; }

        [Required]
        public string Equipment { get; set; }

        [Required]
        public DateTime RequestedDateFrom { get; set; }

        [Required]
        public DateTime RequestedDateTo { get; set; }


        public string? Additionaltools { get; set; }



        [Required]
        public string ConcernedEmployeeId { get; set; }
        [Required]
        public string ConcernedEmployeeName { get; set; }





    }
}
