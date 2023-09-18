using EDocument_Data.Consts.Enums;
using EDocument_Data.DTOs.Requests.RequestReviewer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.Requests.PoRequest
{
    public class PoRequestReadDto
    {
 
        public long Id { get; init; }
        public int CurrentStage { get; init; }
        public RequestStatus Status { get; init; }
        public string? Justification { get; init; }
        public string? CreatorId { get; init; }
        public string? DeclinedBy { get; init; }
        public long DefinedRequestId { get; init; }
        public string? PoNumber { get; init; }
        public string? PoDescription { get; init; }
        public string? VendorName { get; init; }
        public string? VendorNumber { get; init; }
        public string? InvoiceNumber { get; init; }
        public string? PoAttachmentPath { get; init; }
        public string? InvoiceAttachmentPath { get; init; }

        public List<RequestReviewerReadDto>? RequestReviewers { get; set; }
    }
}
