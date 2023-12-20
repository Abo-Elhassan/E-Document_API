using EDocument_Data.Custom_Attributes;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.Requests.VoucherRequest
{
    public class VoucherRequestCreateDto
    {
        [Required]
        public int VendorNumber { get; init; }

        [Required]
        public string VendorName { get; init; }

        [Required]
        public string InvoiceNumber { get; init; }

        [Required]
        public string Description {get; init; }

        [Required]
        public double Amount { get; init; }

        [Required]
        public string AmountInWords { get; init; }

        [Required]
        public string Currency { get; init; }

        [FileValidation(100 * 1024 * 1024, true, ".pdf", ".docx", ".xlsx", ".xls", ".csv", ".zip", ".png", ".jpg", ".jpeg")]
        public List<IFormFile>? Attachments { get; set; }


        public string? Notes { get; init; }



        [Required]
        public long DefinedRequestId { get; init; }
    }
}
