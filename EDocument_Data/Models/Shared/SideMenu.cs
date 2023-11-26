#nullable disable

namespace EDocument_Data.Models.Shared
{

    public class MenuContent
    {
        public long DepartmentId { get; set; }
        public  string Department { get; set; }
        public  string Icon { get; set; }
        public  ICollection<DisplayedRequest> DisplayedRequests { get; set; } = new HashSet<DisplayedRequest>();

    }

    public class DisplayedRequest
    {
        public long DefinedRequestId { get; set; }
        public  string DefinedRequestName { get; set; }
        public  ICollection<RequestDdlContent> RequestDdl { get; set; } = new HashSet<RequestDdlContent>();
    }

    

    public class RequestDdlContent
    {
        public  string DisplayName { get; set; }
        public  string RouteName { get; set; }
    }
}
