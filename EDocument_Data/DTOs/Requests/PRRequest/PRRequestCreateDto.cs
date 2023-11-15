
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;


namespace EDocument_Data.DTOs.Requests.PRRequest
{
    public class PRRequestCreateDto
    {
        [Required]
        public string PrSubject { get; init; }
       
        public string? ItemNumber { get; init; }

       
        public string? AfeNumber { get; init; }

        [Required]
        public List<RequestedPRSubmitDto> RequestedPRs { get; init; }

        [FileValidation(100 * 1024 * 1024, true, ".pdf", ".docx", ".xlsx", ".xls", ".csv", ".rar", ".zip", ".png", ".jpg",".jpeg")]
        public List<IFormFile>? Attachments { get; set; }

        public string? Notes { get; set; }


        [Required]
        public long DefinedRequestId { get; init; }

    }

    public class RequestedPRSubmitDto
    {
        [Required]
        public string RequestType { get; init; }
        [Required]
        public string PRDescription { get; init; }
        [Required]
        public string BudgetType { get; init; }
        [Required]
        public int Quantity { get; init; }

    }
}
