using EDocument_Data.Consts.Enums;
using EDocument_Data.Custom_Attributes;
using EDocument_Data.DTOs.Attachments;
using EDocument_Data.DTOs.Requests.RequestReviewer;
using System.ComponentModel.DataAnnotations;


namespace EDocument_Data.DTOs.Requests.PmJpRequest
{
    public class PmJpRequestReadDto
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
        public string ChangeReason { get; init; }
        public string ChangeType { get; init; }
        public DateTime StartDate { get; init; }
        public DateTime? EndDate { get; init; }
        public string PmJpCode { get; init; }
        public string AssetType { get; init; }
        public string AssetCode { get; init; }
        public string CurrentInterval { get; init; }
        public string NewInterval { get; init; }
        public string AddedMaterials { get; init; }
        public string RemovedMaterials { get; init; }
        public string AddedLaborCraft { get; init; }
        public string RemovedLaborCraft { get; init; }
        public string AddedTask { get; init; }
        public string RemovedTask { get; init; }
        public string AddedMeter { get; init; }
        public string RemovedMeter { get; init; }
        public int? PmPriority { get; init; }
        public List<AttachmentReadDto> Attachments { get; set; }

        public string CreatedBy { get; init; }
        public string ModifiedBy { get; init; }
        public DateTime? CreatedAt { get; init; }
        public DateTime? ModifiedAt { get; init; }

    
    }

    public class PmJpRequestReviewerReadDto : PmJpRequestReadDto
    {
        public int? ReviewerStage { get; set; }
        public RequestStatus? ReviewerStatus { get; set; }
        public List<RequestReviewerReadDto>? RequestReviewers { get; set; }

    }
}
