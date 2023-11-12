#nullable disable
using EDocument_Data.Models.Shared;


namespace EDocument_Data.Models
{
    public class PRRequest : BaseRequest
    {
        public string PRSubject { get; set; }
        public string ItemNumber { get; set; }
        public string AFENumber { get; set; }
        public virtual ICollection<RequestedPR> RequestedPRs { get; set; } = new HashSet<RequestedPR>();

    }
}
