using EDocument_Data.Consts.Enums;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;


namespace EDocument_Data.DTOs.Requests.PRRequest
{
    public class PRRequestUpdateDto
    {
        [Required]
        public string PRSubject { get; init; }

        public string? ItemNumber { get; init; }


        public string? AFENumber { get; init; }

        [Required]
        public List<RequestedPRSubmitDto> RequestedPRs { get; init; }

        [FileValidation(100 * 1024 * 1024, true, ".pdf", ".docx", ".xlsx", ".xls", ".csv", ".rar", ".zip", ".png", ".jpg", ".jpeg")]
        public List<IFormFile>? Attachments { get; set; }

        public string? Notes { get; set; }

    }
}
