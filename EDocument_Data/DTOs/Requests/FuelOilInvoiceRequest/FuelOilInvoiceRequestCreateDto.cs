
using EDocument_Data.Custom_Attributes;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;


namespace EDocument_Data.DTOs.Requests.FuelOilInvoiceRequest
{
    public class FuelOilInvoiceRequestCreateDto
    {
        [Required]
        public string ProductType { get; init; }


        public string? InvoiceNumber { get; init; }


        public int? ReceiptNumber { get; init; }

        [Required]
        public DateTime RequestedDate { get; init; }

        [FileValidation(100 * 1024 * 1024, true, ".pdf", ".docx", ".xlsx", ".xls", ".csv", ".jpeg", ".zip", ".png", ".jpg")]
        public List<IFormFile>? Attachments { get; set; }

        public string? Notes { get; set; }


        [Required]
        public long DefinedRequestId { get; init; }

    }
}
