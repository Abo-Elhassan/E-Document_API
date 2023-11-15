

using EDocument_Data.Consts.Enums;

namespace EDocument_Data.DTOs.Requests.ManliftReservationRequest
{
    public class ReservedManliftReadDto
    {
        public RequestStatus Status { get; init; }
        public DateTime RequestedFrom { get; init; }
        public DateTime RequestedTo { get; init; }
    }
}
