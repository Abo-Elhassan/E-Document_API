using EDocument_Data.Consts.Enums;
using EDocument_Data.Custom_Attributes;
using EDocument_Data.DTOs.Attachments;
using EDocument_Data.DTOs.Requests.RequestReviewer;
using System.ComponentModel.DataAnnotations;


namespace EDocument_Data.DTOs.Requests.ReschedulePmWoRequest
{
    public class ReschedulePmWoRequestReadDto
    {
 
        public long Id { get; init; }
        public string RequestNumber { get; init; }
        public long DefinedRequestId { get; init; }
        public int CurrentStage { get; init; }
        public RequestStatus Status { get; init; }
        public string Notes { get; init; }
        public string CreatorId { get; init; }
        public string RequesterSection { get; init; }
        public string DescriptionOfChange { get; init; }
        public string ReasonForRescheduling { get; init; }
        public DateTime RescheduleFrom { get; init; }
        public DateTime RescheduleTo { get; init; }
        public string WoNumber { get; init; }
        public List<AttachmentReadDto> Attachments { get; set; }

        public string CreatedBy { get; init; }
        public string ModifiedBy { get; init; }
        public DateTime? CreatedAt { get; init; }
        public DateTime? ModifiedAt { get; init; }

    
    }

    public class ReschedulePmWoRequestReviewerReadDto : ReschedulePmWoRequestReadDto
    {
        public int? ReviewerStage { get; set; }
        public RequestStatus? ReviewerStatus { get; set; }
        public List<RequestReviewerReadDto>? RequestReviewers { get; set; }

    }
}
