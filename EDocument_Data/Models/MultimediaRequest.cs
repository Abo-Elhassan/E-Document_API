#nullable disable

using EDocument_Data.Models.Shared;

namespace EDocument_Data.Models
{
    public class MultimediaRequest:BaseRequest
    {
        public string RequestType { get; set; }
        public string ProjectDetails { get; set; }
        public DateTime DeliveryDate { get; set; }
        public TimeSpan? VideoDuration { get; set; }
        public string AnnouncementType { get; set; }
        public string ApprovalItem { get; set; }
        public DateTime? EstimatedDeliveryDate { get; set; }

    }
}
