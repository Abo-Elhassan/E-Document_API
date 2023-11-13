#nullable disable

namespace EDocument_Data.Models
{
    public class ManliftReservationRequest
    {
        public string ManliftNumber { get; set; }
        public DateTime RequestedFrom { get; set; }
        public DateTime RequestedTo { get; set; }
        public string SupervisorNumber { get; set; }
        public string SupervisorName { get; set; }
    }
}
