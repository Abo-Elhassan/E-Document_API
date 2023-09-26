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
        [RegularExpression("^(SOK.PO.)[0-9]{2}-[0-9]+$")]
        public string PoNumber { get; init; }

        [Required]
        public string PoDescription { get; init; }
        [Required]
        public  string VendorName { get; init; }
        [Required]
        public int VendorNumber { get; init; }
        [Required]
        public  string InvoiceNumber { get; init; }

        [FileValidation(2 * 1024 * 1024, ".pdf", ".docx", ".xlsx", ".xls", ".csv", ".rar", ".zip")]
        public IFormFile? PoAttachment { get; init; }

        [FileValidation(2 * 1024 * 1024, ".pdf", ".docx", ".xlsx", ".xls", ".csv", ".rar", ".zip")]
        public IFormFile? InvoiceAttachment { get; init; }

        [FileValidation(2 * 1024 * 1024, true, ".pdf", ".docx", ".xlsx", ".xls", ".csv", ".rar", ".zip")]
        public List<IFormFile>? Attachments { get; set; }
        public string? Remarks { get; set; }


    }
}
