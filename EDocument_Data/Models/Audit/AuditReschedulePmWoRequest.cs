#nullable disable
using EDocument_Data.Consts;
using EDocument_Data.Consts.Enums;



namespace EDocument_Data.Models.Audit
{
    public class AuditReschedulePmWoRequest : AuditBaseEntity
    {
        public string RequestNumber { get; set; }
        public string RequesterSection { get; set; }
        public string DescriptionOfChange { get; set; }
        public string ReasonForRescheduling { get; set; }
        public DateTime RescheduleFrom { get; set; }
        public DateTime RescheduleTo { get; set; }
        public string WoNumber { get; set; }
        public long RequestId { get; set; }
    }
}
