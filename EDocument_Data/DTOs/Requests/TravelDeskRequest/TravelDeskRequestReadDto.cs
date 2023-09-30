using EDocument_Data.Consts.Enums;
using EDocument_Data.DTOs.Attachments;
using EDocument_Data.DTOs.Requests.RequestReviewer;
using EDocument_Data.Models;


namespace EDocument_Data.DTOs.Requests.TravelDeskRequest
{
    public class TravelDeskRequestReadDto
    {
 
        public long Id { get; init; }
        public long DefinedRequestId { get; init; }
        public int CurrentStage { get; init; }
        public RequestStatus Status { get; init; }
        public string Justification { get; init; }
        public string CreatorId { get; init; }
        public string RequestNumber { get; init; }
        public string BeneficiaryId { get; init; }
        public string BeneficiaryName { get; init; }
        public string BeneficiaryEmail { get; init; }
        public string BeneficiaryPosition { get; init; }
        public string BeneficiaryDepartment { get; init; }
        public string BeneficiaryPhoneNumber { get; init; }
        public string BeneficiaryExtention { get; init; }
        public string BeneficiaryNationality { get; init; }
        public List<TravelDeskRequisition> RequestType { get; init; }
        public float CostAllocation { get; init; }
        public Currency Currency { get; init; }
        public DateTime? CheckIn { get; init; }
        public DateTime? CheckOut { get; init; }
        public string MissionAddress { get; init; }
        public PaymentMethod? PaymentMethod { get; init; }
        public string FlightOrigin { get; init; }
        public string FlightDestination { get; init; }
        public DateTime? DepartureDate { get; init; }
        public DateTime? ReturnDate { get; init; }
        public string DestinationCountry { get; init; }
        public DateTime? ExpectedTravelTime { get; init; }
        public List<AttachmentReadDto> Attachments { get; set; }
        public string? CreatedBy { get; init; }
        public DateTime? CreatedAt { get; init; }
        public DateTime? ModifiedAt { get; init; }

    
    }

    public class TravelDeskRequestReviewerReadDto : TravelDeskRequestReadDto
    {
        public int? ReviewerStage { get; set; }
        public RequestStatus? ReviewerStatus { get; set; }
        public List<RequestReviewerReadDto>? RequestReviewers { get; set; }

    }
}
