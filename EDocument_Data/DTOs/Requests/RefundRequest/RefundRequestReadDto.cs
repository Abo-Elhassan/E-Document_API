using EDocument_Data.Consts.Enums;
using EDocument_Data.DTOs.Attachments;
using EDocument_Data.DTOs.Requests.RequestReviewer;
using EDocument_Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Attachment = EDocument_Data.Models.Attachment;

namespace EDocument_Data.DTOs.Requests.RefundRequest
{
    public class RefundRequestReadDto
    {
 
        public long Id { get; init; }
        public string RequestNumber { get; init; }
        public long DefinedRequestId { get; init; }
        public int CurrentStage { get; init; }
        public RequestStatus Status { get; init; }
  
        public string CreatorId { get; init; }
        public string CustomerName { get; set; }
        public string CustomerMobileNumber { get; set; }
        public string Notes { get; init; }
        public string RefundSubject { get; set; }
        public string RefundDescription { get; set; }
        public string RefundType { get; set; }
        public string ShipmentType { get; set; }
        public string DocumentNumber { get; set; }
        public string RelatedContainers { get; set; }
        public string ConcernedEmployeeId { get; set; }
        public string ConcernedEmployeeName { get; set; }
        public List<AttachmentReadDto> Attachments { get; set; }

        public string CreatedBy { get; init; }
        public string ModifiedBy { get; init; }
        public DateTime? CreatedAt { get; init; }
        public DateTime? ModifiedAt { get; init; }

    
    }

    public class RefundRequestReviewerReadDto : RefundRequestReadDto
    {
        public int? ReviewerStage { get; set; }
        public RequestStatus? ReviewerStatus { get; set; }
        public List<RequestReviewerReadDto>? RequestReviewers { get; set; }

    }
}
