#nullable disable
using EDocument_Data.Models.Shared;

namespace EDocument_Data.Models
{
    public class DiscountRequest:BaseEntity
    {
        public string RequestNumber { get; set; }
        public long RequestId { get; set; }
        public string CustomerName { get; set; }
        public bool HasCommercialAgreement { get; set; }
        public string AgreementName { get; set; }
        public int MyProperty { get; set; }
        public Request Request { get; set; }
    }
}
