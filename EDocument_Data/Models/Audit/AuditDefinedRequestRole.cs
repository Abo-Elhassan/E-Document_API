
#nullable disable


using EDocument_Data.Consts.Enums;
using EDocument_Data.Models.Audit;


namespace EDocument_Data.Models.Audit;

public  class AuditDefinedRequestRole : AuditBaseEntity
{
    public string RoleId { get; set; }
    public long DefinedRequestId { get; set; }
    public string Permission { get; set; }

}