using EDocument_Data.Consts.Enums;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;


namespace EDocument_Data.DTOs.Requests.NewItemRequest
{
    public class NewItemRequestUpdateDto
    {
        [Required]
        public string ItemDescription { get; init; }

        [Required]
        public string EquipmentType { get; init; }


        public string? PartNumber { get; init; }


        public string? Manufacturing { get; init; }

        [Required]
        public List<RequestedItemSubmitDto> RequestedItems { get; init; }

        [FileValidation(100 * 1024 * 1024, true, ".pdf", ".docx", ".xlsx", ".xls", ".csv", ".rar", ".zip", ".png", ".jpg", ".jpeg")]
        public List<IFormFile>? Attachments { get; set; }

        public string? Notes { get; set; }

    }
}
