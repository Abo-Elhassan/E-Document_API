#nullable disable

namespace EDocument_Data.Models.Audit
{
    public class AuditPrRequest : AuditBaseRequest
    {
        public string PrSubject { get; set; }
        public string AfeNumber { get; set; }

    }
}
