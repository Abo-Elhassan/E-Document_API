#nullable disable

using EDocument_Data.Consts.Enums;

namespace EDocument_Data.Models.Audit
{
    public class AuditVoucherRequest : AuditBaseRequest
    {
        public int VendorNumber { get; set; }
        public string VendorName { get; set; }
        public string InvoiceNumber { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public string AmountInWords { get; set; }
        public string Currency { get; set; }

    }
}
