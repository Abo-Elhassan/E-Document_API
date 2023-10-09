

using EDocument_Data.Consts.Enums;
using System.ComponentModel.DataAnnotations;

namespace EDocument_Data.DTOs.DefinedRequest
{
    public class DefinedRequestReviewerDto
    {
        [Required]
        public long DefinedRequestId { get; init; }
        public string AssignedReviewerId { get; init; }

        [Required]
        public string StageName { get; init; }
        [Required]

        public int StageNumber { get; init; }
        [Required]

        public ReviewerType ReviewerType { get; init; }

        public string? DelegatedReviewerId { get; init; }

        public DateTime? DelegatedUntil { get; init; }

    }
}
