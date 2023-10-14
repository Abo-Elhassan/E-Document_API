

using EDocument_Data.Consts.Enums;

namespace EDocument_Data.DTOs.Requests
{
    public class RequestDashboardReadDto
    {
        public int CreatedRequests { get; set; }
        public int PendingRequests { get; set; }
        public int ApprovedRequests { get; set; }
        public int DeclinedRequests { get; set; }
        public List<RecentRequestReadDto> RecentRequests { get; set; }
    }


    public class RecentRequestReadDto
    {
        public string RequestName { get; set; }
        public int CurrentStage { get; set; }
        public int NumberOfStages { get; set; }
        public RequestStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string UserRole { get; set; }

    }
}
