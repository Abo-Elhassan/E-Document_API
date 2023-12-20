
using EDocument_Data.Custom_Attributes;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;


namespace EDocument_Data.DTOs.Requests.PrRequest
{
    public class PrRequestCreateDto
    {
        [Required]
        public string PrSubject { get; init; }

        [Required]
        public string BudgetType { get; init; }
        public string? AfeNumber { get; init; }

        [Required]
        public List<RequestedPrSubmitDto> RequestedPrs { get; init; }

        [FileValidation(100 * 1024 * 1024, true, ".pdf", ".docx", ".xlsx", ".xls", ".csv", ".zip", ".png", ".jpg",".jpeg")]
        public List<IFormFile>? Attachments { get; set; }

        public string? Notes { get; set; }


        [Required]
        public long DefinedRequestId { get; init; }

    }

    public class RequestedPrSubmitDto
    {

        [Required]
        public string RequestType { get; init; }
        [Required]
        public string PrDescription { get; init; }
        [Required]
        public double Quantity { get; init; }

        [RegularExpression(@"^(R|T)?\d{6}$|^(PMK-\d{4})$")]
        public string? ItemNumber { get; init; }

    }
}
