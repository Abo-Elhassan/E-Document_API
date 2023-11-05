using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.Requests.RefundRequest
{
    public class RefundRequestUpdateDto
    {
        [Required]
        public  long requestId { get; init; }

        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerMobileNumber { get; set; }
        [Required]
        public string RefundSubject { get; set; }
        [Required]
        public string RefundDescription { get; set; }
        [Required]
        public string RefundType { get; set; }
        public string? ShipmentType { get; set; }
        [Required]
        public string DocumentNumber { get; set; }

        public string? RelatedContainers { get; set; }
        [Required]
        public string ConcernedEmployeeId { get; set; }
        [Required]
        public string ConcernedEmployeeName { get; set; }


        [FileValidation(30 * 1024 * 1024, true, ".pdf", ".docx", ".xlsx", ".xls", ".csv", ".rar", ".zip", ".png", ".jpg")]
        public List<IFormFile>? Attachments { get; set; }

        public string? Notes { get; set; }


    }
}
