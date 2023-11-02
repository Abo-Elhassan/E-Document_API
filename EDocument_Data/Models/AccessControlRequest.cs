#nullable disable
using EDocument_Data.Models.Shared;


namespace EDocument_Data.Models
{
    public class AccessControlRequest : BaseRequest
    {
        public string AccessedBlocks { get; set; }
        public string AccessMethod { get; set; }
        public string EmployeeSignaturePath { get; set; }
    }
}
