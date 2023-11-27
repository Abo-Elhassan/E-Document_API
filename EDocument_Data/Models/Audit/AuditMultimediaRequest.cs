#nullable disable

namespace EDocument_Data.Models.Audit
{
    public class AuditMultimediaRequest:AuditBaseRequest
    {
        public string RequestType { get; set; }
        public string ProjectDetails { get; set; }
        public DateTime DeliveryDate { get; set; }
        public TimeSpan? VideoDuration { get; set; }
        public string AnnouncementType { get; set; }
        public DateTime? EstimatedDeliveryDate { get; set; }
        public string PrTeamAttachmentPath { get; set; }
    }
}
