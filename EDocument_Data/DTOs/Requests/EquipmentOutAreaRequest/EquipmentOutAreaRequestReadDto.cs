using EDocument_Data.Consts.Enums;
using EDocument_Data.DTOs.Requests.EquipmentInAreaRequest;
using EDocument_Data.DTOs.Requests.RequestReviewer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.Requests.EquipmentOutAreaRequest
{
    public class EquipmentOutAreaRequestReadDto
    {
        public long Id { get; init; }
        public string RequestNumber { get; init; }
        public long DefinedRequestId { get; init; }
        public int CurrentStage { get; init; }
        public RequestStatus Status { get; init; }
        public string CreatorId { get; init; }
        public string BeneficiaryId { get; init; }
        public string BeneficiaryName { get; init; }
        public string BeneficiaryEmail { get; init; }
        public string BeneficiaryPosition { get; init; }
        public string BeneficiaryDepartment { get; init; }
        public string BeneficiaryPhoneNumber { get; init; }
        public string BeneficiaryCompany { get; init; }
        public string CommunicationFacility { get; init; }
        public string Area { get; init; }
        public string EquipmentType { get; init; }
        public DateTime RequestedDateFrom { get; init; }
        public DateTime RequestedDateTo { get; init; }
        public string Additionaltools { get; init; }
        public string SupervisorId { get; init; }
        public string SupervisorName { get; init; }
        public string SupervisorPhoneNumber { get; init; }

        public string CreatedBy { get; init; }
        public string ModifiedBy { get; init; }
        public DateTime? CreatedAt { get; init; }
        public DateTime? ModifiedAt { get; init; }
    }


    public class EquipmentOutAreaRequestReviewerReadDto : EquipmentOutAreaRequestReadDto
    {
        public int? ReviewerStage { get; set; }
        public RequestStatus? ReviewerStatus { get; set; }
        public List<RequestReviewerReadDto>? RequestReviewers { get; set; }

    }
}