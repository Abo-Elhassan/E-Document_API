#nullable disable

namespace EDocument_Data.Models.Audit
{
    public class AuditRequestedPR : AuditBaseEntity
    {
        public long RequestedPRId { get; set; }
        public string PRNumber { get; set; }
        public long RequestId { get; set; }
        public string RequestType { get; set; }
        public string PRDescription { get; set; }
        public string BudgetType { get; set; }
        public int Quantity { get; set; }
      
    }
}
