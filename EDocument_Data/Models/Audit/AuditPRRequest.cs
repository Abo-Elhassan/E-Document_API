#nullable disable

namespace EDocument_Data.Models.Audit
{
    public class AuditPRRequest : AuditBaseRequest
    {
        public string PRSubject { get; set; }
        public string ItemNumber { get; set; }
        public string AFENumber { get; set; }

    }
}
