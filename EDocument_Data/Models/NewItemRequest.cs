#nullable disable
using EDocument_Data.Models.Shared;


namespace EDocument_Data.Models
{
    public class NewItemRequest:BaseRequest
    {
        public string ItemDescription { get; set; }
        public string EquipmentType { get; set; }
        public string PartNumber { get; set; }
        public string Manufacturing { get; set; }
    }
}
