using EDocument_Data.Consts.Enums;
using EDocument_Data.DTOs.Attachments;
using EDocument_Data.DTOs.Requests.RequestReviewer;
using EDocument_Data.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Attachment = EDocument_Data.Models.Attachment;

namespace EDocument_Data.DTOs.Requests.VehicleRequest
{
    public class VehicleRequestReadDto
    {
 
        public long Id { get; init; }
        public long DefinedRequestId { get; init; }
        public int CurrentStage { get; init; }
        public RequestStatus Status { get; init; }
        public string Justification { get; init; }
        public string CreatorId { get; init; }

        public long RequestNumber { get; set; }

        public string BeneficiaryId { get; set; }

        public string BeneficiaryName { get; set; }

        public string BeneficiaryEmail { get; set; }

        public string BeneficiaryPosition { get; set; }

        public string BeneficiaryDepartment { get; set; }

        public string BeneficiaryPhoneNumber { get; set; }

        public string BeneficiaryExtention { get; set; }
        public string DepartureAddress { get; init; }
        public string DestinationAddress { get; init; }
        public DateTime DepartureDate { get; init; }
        public DateTime ReturnDate { get; init; }
        public string LuggageDescription { get; init; }
        public string VehicleType { get; set; }

        public List<AttachmentReadDto> Attachments { get; set; }

        public string CreatedBy { get; init; }
        public DateTime? CreatedAt { get; init; }
        public DateTime? ModifiedAt { get; init; }

    
    }

    public class VehicleRequestReviewerReadDto : VehicleRequestReadDto
    {
        public int? ReviewerStage { get; set; }
        public RequestStatus? ReviewerStatus { get; set; }
        public List<RequestReviewerReadDto>? RequestReviewers { get; set; }

    }
}
