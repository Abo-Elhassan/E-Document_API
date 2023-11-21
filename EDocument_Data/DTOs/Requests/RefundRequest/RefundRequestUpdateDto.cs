using EDocument_Data.Custom_Attributes;
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
        public string CustomerName { get; init; }
        [Required]
        public string CustomerMobileNumber { get; init; }
        [Required]
        public string RefundSubject { get; init; }
        [Required]
        public string RefundDescription { get; init; }
        [Required]
        public string RefundType { get; init; }
        public string? ShipmentType { get; init; }
        [Required]
        public string DocumentNumber { get; init; }

        public string? RelatedContainers { get; init; }
        [Required]
        public string ConcernedEmployeeId { get; init; }
        [Required]
        public string ConcernedEmployeeName { get; init; }
        [Required]
        public string ConcernedDepartment { get; init; }


        [FileValidation(100 * 1024 * 1024, true, ".pdf", ".docx", ".xlsx", ".xls", ".csv", ".jpeg", ".zip", ".png", ".jpg", ".msg")]
        public List<IFormFile>? Attachments { get; set; }

        public string? Notes { get; set; }


    }
}
