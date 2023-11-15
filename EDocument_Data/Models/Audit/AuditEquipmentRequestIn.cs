#nullable disable


namespace EDocument_Data.Models.Audit
{
    public class AuditEquipmentRequestIn: AuditBaseEntity
    {
        public string CommunicationFacility { get; set; }
        public string InConcessionArea { get; set; }
        public string Equipment { get; set; }
        public string Additionaltools { get; set; }
        public DateTime RequestedDateFrom { get; set; }
        public DateTime RequestedDateTo { get; set; }

        public string ConcernedEmployeeId { get; set; }
        public string ConcernedEmployeeName { get; set; }
        public string RequestNumber { get; set; }
        public long RequestId { get; set; }
        public Request Request { get; set; }

    }
}
