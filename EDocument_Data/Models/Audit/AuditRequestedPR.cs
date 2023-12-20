#nullable disable

namespace EDocument_Data.Models.Audit
{
    public class AuditRequestedPr : AuditBaseEntity
    {
        public long RequestedPrId { get; set; }
        public string PrNumber { get; set; }
        public long RequestId { get; set; }
        public string RequestType { get; set; }
        public string PrDescription { get; set; }

        public double Quantity { get; set; }
        public string ItemNumber { get; set; }


    }
}
