#nullable disable
using EDocument_Data.Consts;
using EDocument_Data.Consts.Enums;



namespace EDocument_Data.Models.Audit
{
    public class AuditJobPlanRequest : AuditBaseEntity
    {
        public string Description { get; set; }
        public string Action { get; set; }
        public long RequestId { get; set; }
    }
}
