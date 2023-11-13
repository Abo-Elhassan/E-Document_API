
#nullable disable


using EDocument_Data.Models.Shared;

namespace EDocument_Data.Models
{
    public class EquipmentRequestOut: BaseEntity
    {
        public string Additionaltools { get; set; }
        public string CommunicationFacility { get; set; }
        public string OutConcessionArea { get; set; }
        public string Equipment { get; set; }
        public DateTime RequestedDateFrom { get; set; }
        public DateTime RequestedDateTo { get; set; }
        public string ConcernedEmployeeId { get; set; }
        public string ConcernedEmployeeName { get; set; }
        public string RequestNumber { get; set; }
        public long RequestId { get; set; }
        public Request Request { get; set; }

    }
}
