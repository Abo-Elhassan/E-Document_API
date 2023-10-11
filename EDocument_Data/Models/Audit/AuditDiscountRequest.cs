
using EDocument_Data.Models.Audit;
using EDocument_Data.Models.Shared;

namespace EDocument_Data.Models.Audit
{
    public class AuditDiscountRequest : AuditBaseEntity
    {
        public string RequestNumber { get; set; }
        public long RequestId { get; set; }
        public Request Request { get; set; }
    }
}
