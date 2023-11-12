#nullable disable

namespace EDocument_Data.Models.Audit
{
    public class AuditRequestedItem :AuditBaseEntity
    {
        public long RequestedItemId { get; set; }
        public string ItemNumber { get; set; }
        public string RequestNumber { get; set; }
        public string BudgetType { get; set; }
        public string CommodityCode { get; set; }
        public string StoreRoom { get; set; }
        public string Unit { get; set; }
    }
}
