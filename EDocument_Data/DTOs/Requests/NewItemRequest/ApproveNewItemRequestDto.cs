

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
        [Required]
        public long RequestedItemId { get; init; }
        [Required]
        [RegularExpression(@"^(R|T)?\d{6}$|^(PMK-\d{4})$")]
        public string ItemNumber { get; init; }

    }
}
