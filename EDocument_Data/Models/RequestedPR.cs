#nullable disable

using EDocument_Data.Models.Shared;

namespace EDocument_Data.Models
{
    public class RequestedPR : BaseEntity
    {
        public long RequestedPRId { get; set; }
        public string PRNumber { get; set; }
        public string RequestNumber { get; set; }
        public string RequestType { get; set; }
        public string PRDescription { get; set; }
        public string BudgetType { get; set; }
        public int Quantity { get; set; }
        public virtual PRRequest PRRequest { get; set; }
    }
}
