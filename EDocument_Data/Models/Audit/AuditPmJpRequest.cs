#nullable disable

namespace EDocument_Data.Models.Audit
{
    public class AuditPmJpRequest :AuditBaseEntity
    {
        public string RequestNumber { get; set; }
        public string RequesterSection { get; set; }
        public string DescriptionOfChange { get; set; }
        public string ChangeReason { get; set; }
        public string ChangeType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string PmJpCode { get; set; }
        public string AssetType { get; set; }
        public string AssetCode { get; set; }
        public string CurrentInterval { get; set; }
        public string NewInterval { get; set; }
        public string AddedMaterials { get; set; }
        public string RemovedMaterials { get; set; }
        public string AddedLaborCraft { get; set; }
        public string RemovedLaborCraft { get; set; }
        public string AddedTask { get; set; }
        public string RemovedTask { get; set; }
        public string AddedMeter { get; set; }
        public string RemovedMeter { get; set; }
        public int? PmPriority { get; set; }
        public long RequestId { get; set; }
    }
}
