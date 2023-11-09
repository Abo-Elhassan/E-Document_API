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
        public string RequestNumber { get; init; }

        public string BeneficiaryId { get; init; }

        public string BeneficiaryName { get; init; }

        public string BeneficiaryEmail { get; init; }

        public string BeneficiaryPosition { get; init; }

        public string BeneficiaryDepartment { get; init; }

        public string BeneficiaryPhoneNumber { get; init; }
        public string BeneficiaryComapny { get; init; }
        public int? BeneficiaryExtention { get; init; }
        public string DepartureAddress { get; init; }
        public string DestinationAddress { get; init; }
        public DateTime DepartureDate { get; init; }
        public DateTime ReturnDate { get; init; }
        public string? LuggageDescription { get; init; }
        public string? VehicleType { get; init; }

        public List<AttachmentReadDto> Attachments { get; set; }

        public string? CreatedBy { get; init; }
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
