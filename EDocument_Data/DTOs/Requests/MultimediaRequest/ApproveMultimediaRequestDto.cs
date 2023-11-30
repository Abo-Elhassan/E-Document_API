
using EDocument_Data.Custom_Attributes;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;


namespace EDocument_Data.DTOs.Requests.MultimediaRequest
{
    public class ApproveMultimediaRequestDto
    {
        [Required]
        public long RequestId { get; init; }
        public DateTime? EstimatedDeliveryDate { get; init; }
        [FileValidation(100 * 1024 * 1024, true, ".pdf", ".docx", ".xlsx", ".xls", ".csv", ".zip", ".png", ".jpg", ".jpeg")]
        public IFormFile? PrTeamAttachment { get; init; }
        public string? ReviewedNotes { get; init; }
    }
}
