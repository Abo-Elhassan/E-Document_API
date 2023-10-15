

using EDocument_Data.Consts.Enums;
using System.ComponentModel.DataAnnotations;

namespace EDocument_Data.DTOs.DefinedRequest
{
    public class DefinedRequestReviewerUpdateDto
    {
        [Required]
        public long DefinedRequestId { get; init; }

        public string? AssignedReviewerId { get; init; }

        [Required]
        public required string StageName { get; init; }

        [Required]
        public int StageNumber { get; init; }

        [Required]
        public ReviewerType ReviewerType { get; init; }

        public string? DelegatedReviewerId { get; init; }

        public DateTime? DelegatedUntil { get; init; }

    }
}
