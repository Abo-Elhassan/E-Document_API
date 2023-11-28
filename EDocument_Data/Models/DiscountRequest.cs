#nullable disable
using EDocument_Data.Models.Shared;

namespace EDocument_Data.Models
{
    public class DiscountRequest:BaseEntity
    {
        public string RequestNumber { get; set; }
        public long RequestId { get; set; }
        public string CustomerType { get; set; }
        public string CustomerName { get; set; }
        public bool HasCommercialAgreement { get; set; }
        public string AgreementName { get; set; }
        public string LineName { get; set; }
        public string LineCode { get; set; }
        public int? TaxId { get; set; }
        public string DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public string InvoiceNumber { get; set; }
        public string RelatedContainers { get; set; }
        public string DiscountType { get; set; }
        public string DiscountReason { get; set; }
        public float DiscountAmount { get; set; }
        public string HoSupportedDocumentPath { get; set; }
        public Request Request { get; set; }
    }
}
