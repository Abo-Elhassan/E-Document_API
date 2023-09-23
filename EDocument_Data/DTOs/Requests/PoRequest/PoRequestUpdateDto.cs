using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.Requests.PoRequest
{
    public class PoRequestUpdateDto
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
        [Required]
        [FileValidation(2 * 1024 * 1024, ".pdf", ".docx", ".xlsx", ".xls")]
        public IFormFile PoAttachment { get; init; }
        [Required]
        [FileValidation(2 * 1024 * 1024, ".pdf", ".docx", ".xlsx", ".xls")]
        public IFormFile InvoiceAttachment { get; init; }

        [FileValidation(2 * 1024 * 1024, true, ".pdf", ".docx", ".xlsx" ,".xls")]
        public List<IFormFile>? Attachments { get; set; }


    }
}
