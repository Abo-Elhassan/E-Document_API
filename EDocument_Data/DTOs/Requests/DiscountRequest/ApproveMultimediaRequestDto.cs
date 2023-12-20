
using EDocument_Data.Custom_Attributes;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;


namespace EDocument_Data.DTOs.Requests.DiscountRequest
{
    public class ApproveDiscountRequestDto
    {
        [Required]
        public long RequestId { get; init; }
        public double? DiscountAmount { get; init; }
        [FileValidation(100 * 1024 * 1024, true, ".pdf", ".docx", ".xlsx", ".xls", ".csv", ".zip", ".png", ".jpg", ".jpeg")]
        public IFormFile? HoSupportedDocument { get; init; }
        public string? ReviewedNotes { get; init; }
    }
}
