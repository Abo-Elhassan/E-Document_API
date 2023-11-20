#nullable disable

using EDocument_Data.Models.Shared;

namespace EDocument_Data.Models
{
    public class ManliftReservationRequest:BaseRequest
    {
        public string ManliftNumber { get; set; }
        public DateTime RequestedFrom { get; set; }
        public DateTime RequestedTo { get; set; }

    }
}
