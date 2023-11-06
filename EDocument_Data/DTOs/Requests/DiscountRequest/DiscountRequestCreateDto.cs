using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.Requests.DiscountRequest
{
    public class DiscountRequestCreateDto
    {
        [Required]
        public required string CustomerType { get; set; }
        [Required]
        public required string CustomerName { get; set; }
        [Required]
        public bool HasCommercialAgreement { get; set; }

        public string? AgreementName { get; set; }
        public string? LineName { get; set; }
        public string? LineCode { get; set; }

        public int? TaxId { get; set; }

        [Required]
        public required string DocumentType { get; set; }

        [Required]
        public required string DocumentNumber { get; set; }

        public string? InvoiceNumber { get; set; }

        public string? RelatedContainers { get; set; }

        [Required]
        public required string DiscountType { get; set; }
        [Required]
        public required string DiscountReason { get; set; }

        [Required]
        public float DiscountAmount { get; set; }

        [FileValidation(50 * 1024 * 1024,true, ".pdf", ".docx", ".xlsx", ".xls",".csv",".rar",".zip",".png",".jpg")]
        public List<IFormFile>? Attachments { get; set; }

        public string? Notes { get; set; }

        [Required]
        public long DefinedRequestId { get; init; }
    }
}
