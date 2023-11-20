using EDocument_Data.Consts.Enums;
using EDocument_Data.Custom_Attributes;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;


namespace EDocument_Data.DTOs.Requests.NewItemRequest
{
    public class NewItemRequestUpdateDto
    {
        [Required]
        public List<RequestedItemSubmitDto> RequestedItems { get; init; }

        [FileValidation(100 * 1024 * 1024, true, ".pdf", ".docx", ".xlsx", ".xls", ".csv", ".zip", ".png", ".jpg", ".jpeg")]
        public List<IFormFile>? Attachments { get; set; }

        public string? Notes { get; set; }

    }
}
