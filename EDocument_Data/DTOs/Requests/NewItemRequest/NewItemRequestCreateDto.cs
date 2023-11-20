
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;


namespace EDocument_Data.DTOs.Requests.NewItemRequest
{
    public class NewItemRequestCreateDto
    {


        [Required]
        public List<RequestedItemSubmitDto> RequestedItems { get; init; }

        [FileValidation(100 * 1024 * 1024, true, ".pdf", ".docx", ".xlsx", ".xls", ".csv",".zip", ".png", ".jpg",".jpeg")]
        public List<IFormFile>? Attachments { get; set; }

        public string? Notes { get; set; }


        [Required]
        public long DefinedRequestId { get; init; }

    }

    public class RequestedItemSubmitDto
    {
        [Required]
        public string ItemDescription { get; init; }
        [Required]
        public string EquipmentType { get; init; }
        [Required]
        public string BudgetType { get; init; }
        [Required]
        public string CommodityCode { get; init; }
        [Required]
        public string StoreRoom { get; init; }
        [Required]
        public string Unit { get; init; }
        public string? PartNumber { get; init; }
        public string? Manufacturing { get; init; }


    }
}
