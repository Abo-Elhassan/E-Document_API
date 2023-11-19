#nullable disable

using EDocument_Data.Models.Shared;

namespace EDocument_Data.Models
{
    public class RequestedPr : BaseEntity
    {
        public long RequestedPrId { get; set; }
        public string PrNumber { get; set; }
        public long RequestId { get; set; }
        public string RequestType { get; set; }
        public string PrDescription { get; set; }
        public string BudgetType { get; set; }
        public int Quantity { get; set; }
        public string ItemNumber { get; set; }
        public virtual Request Request { get; set; }
    }
}
