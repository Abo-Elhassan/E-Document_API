
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;


namespace EDocument_Data.DTOs.Requests.DiscountRequest
{
    public class ApproveDiscountRequestDto
    {
        [Required]
        public long RequestId { get; init; }
        public float? DiscountAmount { get; init; }
        public IFormFile? HoSupportedDocument { get; init; }
        public string? ReviewedNotes { get; init; }
    }
}
