

using System.ComponentModel.DataAnnotations;

namespace EDocument_Data.DTOs.Requests.PRRequest
{
    public class ApprovePRRequestDto
    {
        [Required]
        public long RequestId { get; init; }
        [Required]
        public List<ApproveRequestedPRDto> ApprovedPRs { get; init; }
    }

    public class ApproveRequestedPRDto
    {
        public long RequestedPRId { get; init; }
        public string PRNumber { get; init; }

    }
}
