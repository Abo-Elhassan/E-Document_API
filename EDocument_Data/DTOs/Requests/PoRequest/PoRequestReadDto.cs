using EDocument_Data.Consts.Enums;
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
 
        public long RequestId { get; init; }
        public int CurrentStage { get; init; }
        public RequestStatus Status { get; init; }
        public int? ReviewerStage { get; set; }
        public RequestStatus? ReviewerStatus { get; set; }
        public string? Justification { get; init; }
        public string? CreatorId { get; init; }
        public string? CreatorFullName { get; init; }
        public long DefinedRequestId { get; init; }
        public string? PoNumber { get; init; }
        public string? PoDescription { get; init; }
        public string? VendorName { get; init; }
        public int VendorNumber { get; init; }
        public string? InvoiceNumber { get; init; }
        public string? PoAttachmentPath { get; init; }
        public string? InvoiceAttachmentPath { get; init; }

        public List<Attachment>? Attachments { get; set; }

        public DateTime CreatedAt { get; init; }
        public DateTime ModifiedAt { get; init; }

        public List<RequestReviewerReadDto>? RequestReviewers { get; set; }
    }
}
