using EDocument_Data.Consts.Enums;
using EDocument_Data.DTOs.Attachments;
using EDocument_Data.DTOs.Requests.RequestReviewer;
using EDocument_Data.Models;


namespace EDocument_Data.DTOs.Requests.MultimediaRequest
{
    public class MultimediaRequestReadDto
    {
 
        public long Id { get; init; }
        public long DefinedRequestId { get; init; }
        public int CurrentStage { get; init; }
        public RequestStatus Status { get; init; }
        public string Notes { get; init; }
        public string CreatorId { get; init; }
        public string RequestNumber { get; init; }
        public string BeneficiaryId { get; init; }
        public string BeneficiaryName { get; init; }
        public string BeneficiaryEmail { get; init; }
        public string BeneficiaryPosition { get; init; }
        public string BeneficiaryDepartment { get; init; }
        public string BeneficiaryPhoneNumber { get; init; }
        public int? BeneficiaryExtention { get; init; }
        public string BeneficiaryCompany { get; init; }
        public string RequestType { get; init; }
        public string ProjectDetails { get; init; }
        public string DeliveryDate { get; init; }
        public TimeSpan? VideoDuration { get; init; }
        public string AnnouncementType { get; init; }
        public DateTime? EstimatedDeliveryDate { get; init; }

        public AttachmentReadDto PrTeamAttachment { get; set; }
        public List<AttachmentReadDto> Attachments { get; set; }
        public string? CreatedBy { get; init; }
        public DateTime? CreatedAt { get; init; }
        public DateTime? ModifiedAt { get; init; }

    
    }

    public class MultimediaRequestReviewerReadDto : MultimediaRequestReadDto
    {
        public int? ReviewerStage { get; set; }
        public RequestStatus? ReviewerStatus { get; set; }
        public List<RequestReviewerReadDto>? RequestReviewers { get; set; }

 

    }


}
