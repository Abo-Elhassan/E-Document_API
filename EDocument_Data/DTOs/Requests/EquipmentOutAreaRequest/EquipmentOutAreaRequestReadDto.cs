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

        public string CommunicationFacility { get; set; }
        public string OutConcessionArea { get; set; }
        public string Equipment { get; set; }

        public DateTime RequestedDateFrom { get; set; }
        public DateTime RequestedDateTo { get; set; }
        public string Additionaltools { get; set; }

        public string ConcernedEmployeeId { get; set; }

        public string ConcernedEmployeeName { get; set; }

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