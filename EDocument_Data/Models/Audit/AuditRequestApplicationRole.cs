#nullable disable
using EDocument_Data.Models.Audit;


namespace EDocument_Data.Models.Audit
{
    public class AuditRequestApplicationRole : AuditBaseEntity
    {
        public long RequestId { get; set; }
        public long ApplicationId { get; set; }
        public long RoleId { get; set; }

    }
}
