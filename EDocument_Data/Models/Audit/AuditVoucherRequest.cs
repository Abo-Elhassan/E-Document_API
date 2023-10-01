#nullable disable

using EDocument_Data.Consts.Enums;

namespace EDocument_Data.Models.Audit
{
    public class AuditVoucherRequest : AuditBaseEntity
    {
        public string VendorNumber { get; set; }
        public string VendorName { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string BeneficiaryName { get; set; }
        public string Description { get; set; }
        public float VoucherAmount { get; set; }
        public string VoucherCurrency{ get; set; }
        public string VoucherType{ get; set; }
        public  long RequestId { get; set; }
 
    }
}
