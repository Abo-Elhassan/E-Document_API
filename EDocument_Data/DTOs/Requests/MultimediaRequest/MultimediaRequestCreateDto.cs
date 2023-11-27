
using EDocument_Data.Custom_Attributes;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;


namespace EDocument_Data.DTOs.Requests.MultimediaRequest
{
    public class MultimediaRequestCreateDto
    {
        [Required]
        public string RequestType { get; init; }

        [Required]
        public string ProjectDetails { get; init; }

        [Required]
        public DateTime DeliveryDate { get; init; }

        public TimeSpan? VideoDuration { get; init; }
        public string? AnnouncementType { get; init; }


        [FileValidation(100 * 1024 * 1024, true, ".pdf", ".docx", ".xlsx", ".xls", ".csv", ".jpeg", ".zip", ".png", ".jpg")]
        public List<IFormFile>? Attachments { get; set; }

        public string? Notes { get; set; }


        [Required]
        public long DefinedRequestId { get; init; }

    }
}
