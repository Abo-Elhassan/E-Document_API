using EDocument_Data.Consts.Enums;
using EDocument_Data.DTOs.Attachments;
using EDocument_Data.DTOs.Requests.RequestReviewer;
using EDocument_Data.Models;


namespace EDocument_Data.DTOs.Requests.NewItemRequest
{
    public class NewItemRequestReadDto
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
        public string BeneficiaryCompany { get; init; }
        public string ItemDescription { get; init; }
        public string EquipmentType { get; init; }
        public string PartNumber { get; init; }
        public string Manufacturing { get; init; }
        public List<RequestedItemReadDto> RequestedItems { get; set; }
        public List<AttachmentReadDto> Attachments { get; set; }
        public string? CreatedBy { get; init; }
        public DateTime? CreatedAt { get; init; }
        public DateTime? ModifiedAt { get; init; }

    
    }

    public class NewItemRequestReviewerReadDto : NewItemRequestReadDto
    {
        public int? ReviewerStage { get; set; }
        public RequestStatus? ReviewerStatus { get; set; }
        public List<RequestReviewerReadDto>? RequestReviewers { get; set; }

    }
    public class RequestedItemReadDto
    {
        public long RequestedItemId { get; init; }
        public string ItemNumber { get; init; }
        public string RequestNumber { get; init; }
        public string BudgetType { get; init; }
        public string CommodityCode { get; init; }
        public string StoreRoom { get; init; }
        public string Unit { get; init; }
    }


}
