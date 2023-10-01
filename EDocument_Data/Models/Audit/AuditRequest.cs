
#nullable disable




namespace EDocument_Data.Models.Audit;

public partial class AuditRequest : AuditBaseEntity
{
    public long Id { get; set; }

    public int CurrentStage { get; set; }

    public string Status { get; set; }

    public string Justification { get; set; }

    public string CreatorId { get; set; }

    public long DefinedRequestId { get; set; }



}