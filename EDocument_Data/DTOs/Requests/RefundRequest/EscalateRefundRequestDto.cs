

using System.ComponentModel.DataAnnotations;

namespace EDocument_Data.DTOs.Requests.RefundRequest
{
    public class EscalateRefundRequestDto
    {
        [Required]
        public long RequestId { get; init; }
        [Required]
        public string CurrentReviewerId { get; init; }
    }
}
