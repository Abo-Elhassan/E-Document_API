

using System.ComponentModel.DataAnnotations;

namespace EDocument_Data.DTOs.Requests.NewItemRequest
{
    public class ApproveNewItemRequestDto
    {
        [Required]
        public long RequestId { get; init; }
        [Required]
        public List<ApproveRequestedItemDto> ApprovedItems { get; init; }
    }

    public class ApproveRequestedItemDto
    {
        public long RequestedItemId { get; init; }
        public string ItemNumber { get; init; }

    }
}
