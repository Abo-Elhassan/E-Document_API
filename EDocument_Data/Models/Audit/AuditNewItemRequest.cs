#nullable disable

namespace EDocument_Data.Models.Audit
{
    public class AuditNewItemRequest:AuditBaseRequest
    {
        public string ItemDescription { get; set; }
        public string EquipmentType { get; set; }
        public string PartNumber { get; set; }
        public string Manufacturing { get; set; }
    }
}
