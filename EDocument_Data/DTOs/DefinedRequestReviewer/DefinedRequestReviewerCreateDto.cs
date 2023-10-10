using EDocument_Data.Consts.Enums;
using System.ComponentModel.DataAnnotations;

namespace EDocument_Data.DTOs.DefinedRequestReviewer
{
    public class DefinedRequestReviewerCreateDto
    {
        public string? AssignedReviewerId { get; init; }

        [Required]
        public required string StageName { get; init; }

        [Required]
        public int StageNumber { get; init; }

        [Required]
        public ReviewerType ReviewerType { get; init; }


    }
}
