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

namespace EDocument_Data.DTOs.Requests.PoRequest
{
    public class PoRequestReadDto
    {
 
        public long Id { get; init; }
        public string RequestNumber { get; init; }
        public long DefinedRequestId { get; init; }
        public int CurrentStage { get; init; }
        public RequestStatus Status { get; init; }
        public string? Justification { get; init; }
        public string? CreatorId { get; init; }
        public string? PoNumber { get; init; }
        public string? PoDescription { get; init; }
        public string? VendorName { get; init; }
        public int VendorNumber { get; init; }
        public string? InvoiceNumber { get; init; }
        public AttachmentReadDto? PoAttachment { get; set; }
        public AttachmentReadDto? InvoiceAttachment { get; set; }

        public List<AttachmentReadDto>? Attachments { get; set; }

        public string? CreatedBy { get; init; }
        public DateTime CreatedAt { get; init; }
        public DateTime ModifiedAt { get; init; }

    
    }

    public class PoRequestReviewerReadDto : PoRequestReadDto
    {
        public int? ReviewerStage { get; set; }
        public RequestStatus? ReviewerStatus { get; set; }
        public List<RequestReviewerReadDto>? RequestReviewers { get; set; }

    }
}
