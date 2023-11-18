

using System.ComponentModel.DataAnnotations;

namespace EDocument_Data.DTOs.Requests.PrRequest
{
    public class ApprovePrRequestDto
    {
        [Required]
        public long RequestId { get; init; }
        [Required]
        public List<ApproveRequestedPrDto> ApprovedPrs { get; init; }
    }

    public class ApproveRequestedPrDto
    {
        [Required]
        public long RequestedPrId { get; init; }

        [Required]
        [RegularExpression(@"^[A-Z]{2}\d{2}-\d{4}$")]
        public string PrNumber { get; init; }

    }
}
