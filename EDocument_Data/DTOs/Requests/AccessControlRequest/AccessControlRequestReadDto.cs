using EDocument_Data.Consts.Enums;
using EDocument_Data.DTOs.Attachments;
using EDocument_Data.DTOs.Requests.RequestReviewer;
using EDocument_Data.Models;


namespace EDocument_Data.DTOs.Requests.AccessControlRequest
{
    public class AccessControlRequestReadDto
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
        public string BeneficiartCompany { get; init; }
        public string BeneficiaryPhoneNumber { get; init; }
        public string BeneficiaryExtention { get; init; }
        public AttachmentReadDto EmployeeSignature { get; init; }
        public string? CreatedBy { get; init; }
        public DateTime? CreatedAt { get; init; }
        public DateTime? ModifiedAt { get; init; }

    
    }

    public class AccessControlRequestReviewerReadDto : AccessControlRequestDetailsReadDto
    {
        public int? ReviewerStage { get; set; }
        public RequestStatus? ReviewerStatus { get; set; }
        public List<RequestReviewerReadDto>? RequestReviewers { get; set; }

 

    }
    public class AccessControlRequestEditReadDto : AccessControlRequestReadDto
    {
        public List<string> AccessedBlocks { get; init; }
        public List<string> AccessMethod { get; init; }
    }

    public class AccessControlRequestDetailsReadDto : AccessControlRequestReadDto
    {
        public string AccessedBlocks { get; init; }
        public string AccessMethod { get; init; }
    }

}
