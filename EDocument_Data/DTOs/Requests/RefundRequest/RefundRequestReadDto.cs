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
        public string CustomerName { get; init; }
        public string CustomerMobileNumber { get; init; }
        public string Notes { get; init; }
        public string RefundSubject { get; init; }
        public string RefundDescription { get; init; }
        public string RefundType { get; init; }
        public string ShipmentType { get; init; }
        public string DocumentNumber { get; init; }
        public string RelatedContainers { get; init; }
        public string ConcernedEmployeeId { get; init; }
        public string ConcernedEmployeeName { get; init; }
        public string ConcernedDepartment { get; init; }
        public List<AttachmentReadDto> Attachments { get; set; }
        public long? CreditNote { get; init; }
        public string Amount { get; init; }
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
