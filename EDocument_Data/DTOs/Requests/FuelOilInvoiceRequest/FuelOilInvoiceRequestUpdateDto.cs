using EDocument_Data.Consts.Enums;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;


namespace EDocument_Data.DTOs.Requests.FuelOilInvoiceRequest
{
    public class FuelOilInvoiceRequestUpdateDto
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

    }
}
