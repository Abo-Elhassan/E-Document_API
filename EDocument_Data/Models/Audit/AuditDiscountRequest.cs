#nullable disable

namespace EDocument_Data.Models.Audit
{
    public class AuditDiscountRequest : AuditBaseEntity
    {
        public string RequestNumber { get; set; }
        public long RequestId { get; set; }
        public string CustomerType { get; set; }
        public string CustomerName { get; set; }
        public bool HasCommercialAgreement { get; set; }
        public string AgreementName { get; set; }
        public int? TaxId { get; set; }
        public string DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public string InvoiceNumber { get; set; }
        public string RelatedContainers { get; set; }
        public string DiscountType { get; set; }
        public string DiscountReason { get; set; }
        public float DiscountAmount { get; set; }
    }
}
