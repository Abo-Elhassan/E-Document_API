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
        public  RequestReadDto? RequestInfo { get; set; }
        public  List<RequestReviewerReadDto>? RequestReviewers { get; set; }
        public  string? PoNumber { get; set; }
        public  string? PoDescription { get; set; }
        public  string? VendorName { get; set; }
        public  string? VendorNumber { get; set; }
        public  string? InvoiceNumber { get; set; }
        public  string? PoAttachmentPath { get; set; }
        public  string? InvoiceAttachmentPath { get; set; }
    }
}
