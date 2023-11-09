
using System.ComponentModel.DataAnnotations;


namespace EDocument_Data.DTOs.Requests.FuelOilInvoiceRequest
{
    public class FuelOilInvoiceRequestCreateDto
    {
        [Required]
        public string ProductType { get; init; }

        [Required]
        public string InvoiceNumber { get; init; }

        [Required]
        public int ReceiptNumber { get; init; }

        [Required]
        public DateTime RequestedDate { get; init; }

        public string? Notes { get; set; }


        [Required]
        public long DefinedRequestId { get; init; }

    }
}
