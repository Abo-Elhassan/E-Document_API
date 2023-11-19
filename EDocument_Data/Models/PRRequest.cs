#nullable disable
using EDocument_Data.Models.Shared;


namespace EDocument_Data.Models
{
    public class PrRequest : BaseRequest
    {
        public string PrSubject { get; set; }
        public string AfeNumber { get; set; }

    }
}
