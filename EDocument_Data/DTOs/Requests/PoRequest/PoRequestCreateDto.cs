using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.Requests.PoRequest
{
    public class PoRequestCreateDto
    {
        [Required]
        [RegularExpression("^(SOK.PO.)[0-9]{2}-[0-9]+$")]
        public  string PoNumber { get; init; }

        public string PoDescription { get; init; }
        [Required]
        public  string VendorName { get; init; }
        [Required]
        public int VendorNumber { get; init; }
        [Required]
        public  string InvoiceNumber { get; init; }
        [Required]
        [FileValidation(2 * 1024 * 1024, ".pdf", ".docx", ".xlsx")]
        public  IFormFile PoAttachment { get; init; }
        [Required]
        [FileValidation(2 * 1024 * 1024, ".pdf", ".docx", ".xlsx")]
        public IFormFile InvoiceAttachment { get; init; }

        [FileValidation(2 * 1024 * 1024,true, ".pdf", ".docx", ".xlsx")]
        public List<IFormFile> Attachments { get; set; }

        [Required]
        public long DefinedRequestId { get; init; }
    }
}
