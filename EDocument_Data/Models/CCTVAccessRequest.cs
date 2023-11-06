using EDocument_Data.Models.Shared;


namespace EDocument_Data.Models
{
    public class CCTVAccessRequest :BaseRequest
    {
        public string RequestedRoles { get; set; }
    }
}
