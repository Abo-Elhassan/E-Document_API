using EDocument_Data.Consts.Enums;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;


namespace EDocument_Data.DTOs.Requests.PrRequest
{
    public class PrRequestUpdateDto
    {
        [Required]
        public string PrSubject { get; init; }
        [Required]
        public string BudgetType { get; init; }

        public string? AfeNumber { get; init; }

        [Required]
        public List<RequestedPrSubmitDto> RequestedPrs { get; init; }

        [FileValidation(100 * 1024 * 1024, true, ".pdf", ".docx", ".xlsx", ".xls", ".csv", ".zip", ".png", ".jpg", ".jpeg")]
        public List<IFormFile>? Attachments { get; set; }

        public string? Notes { get; set; }

    }
}
