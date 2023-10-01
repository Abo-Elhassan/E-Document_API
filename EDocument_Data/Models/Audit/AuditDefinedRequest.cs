
#nullable disable


using EDocument_Data.Models.Shared;

namespace EDocument_Data.Models.Audit;

public  class AuditDefinedRequest : AuditBaseEntity
{
    public long Id { get; set; }

    public string RequestName { get; set; }

    public string RouteName { get; set; }

    public int ReviewersNumber { get; set; }

    public long DepartmentId { get; set; }


}