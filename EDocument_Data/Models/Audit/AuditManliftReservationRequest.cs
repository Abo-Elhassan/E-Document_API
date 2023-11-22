#nullable disable

namespace EDocument_Data.Models.Audit
{
    public class AuditManliftReservationRequest:AuditBaseRequest
    {
        public string ManliftNumber { get; set; }
        public string WorkingArea { get; set; }
        public DateTime RequestedFrom { get; set; }
        public DateTime RequestedTo { get; set; }
    }
}
