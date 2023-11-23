#nullable disable


namespace EDocument_Data.Models.Audit
{
    public class AuditEquipmentRequestIn: AuditBaseRequest
    {
        public string CommunicationFacility { get; set; }
        public string Area { get; set; }
        public string EquipmentType { get; set; }
        public DateTime RequestedDateFrom { get; set; }
        public DateTime RequestedDateTo { get; set; }
        public string Additionaltools { get; set; }
        public string SupervisorId { get; set; }
        public string SupervisorName { get; set; }
        public string SupervisorPhoneNumber { get; set; }

    }
}
