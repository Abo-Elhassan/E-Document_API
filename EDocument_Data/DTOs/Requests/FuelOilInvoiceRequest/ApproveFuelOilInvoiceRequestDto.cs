
using System.ComponentModel.DataAnnotations;


namespace EDocument_Data.DTOs.Requests.FuelOilInvoiceRequest
{
    public class ApproveFuelOilInvoiceRequestDto
    {
        [Required]
        public long RequestId { get; set; }
        [Required]
        public int SwiftNumber { get; set; }
        public string? ReviewedNotes { get; set; }
    }
}
