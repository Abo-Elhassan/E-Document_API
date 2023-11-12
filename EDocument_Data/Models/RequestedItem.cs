#nullable disable
using EDocument_Data.Models.Shared;

namespace EDocument_Data.Models
{
    public class RequestedItem :BaseEntity
    {
        public long RequestedItemId { get; set; }
        public string ItemNumber { get; set; }
        public string RequestNumber { get; set; }
        public string BudgetType { get; set; }
        public string CommodityCode { get; set; }
        public string StoreRoom { get; set; }
        public string Unit { get; set; }
        public virtual NewItemRequest NewItemRequest { get; set; }
    }
}
