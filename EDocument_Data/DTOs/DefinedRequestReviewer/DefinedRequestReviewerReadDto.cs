

using EDocument_Data.Consts.Enums;
using System.ComponentModel.DataAnnotations;

namespace EDocument_Data.DTOs.DefinedRequest
{
    public class DefinedRequestReviewerReadDto
    {

        public long DefinedRequestId { get; init; }
        public string AssignedReviewerId { get; init; }

        public string StageName { get; init; }
  
        public int StageNumber { get; init; }
     
        public ReviewerType ReviewerType { get; init; }

    }
}
