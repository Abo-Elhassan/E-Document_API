using EDocument_Data.Custom_Attributes;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;


namespace EDocument_Data.DTOs.Requests.ReschedulePmWoRequest
{
    public class ReschedulePmWoRequestUpdateDto
    {
        [Required]
        public string DescriptionOfChange { get; init; }
        [Required]
        public string ReasonForRescheduling { get; init; }
        [Required]
        [OldDateValidator]
        public DateTime RescheduleFrom { get; init; }
        [Required]
        [OldDateValidator]
        [RescheduleToValidation]
        public DateTime RescheduleTo { get; init; }
        [Required]
        public string WoNumber { get; init; }

        [FileValidation(100 * 1024 * 1024, true, ".pdf", ".docx", ".xlsx", ".xls", ".csv", ".jpeg", ".zip", ".png", ".jpg")]
        public List<IFormFile>? Attachments { get; set; }

        public string? Notes { get; set; }


    }
}
