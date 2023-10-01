
#nullable disable


using EDocument_Data.Consts.Enums;

namespace EDocument_Data.Models.Audit;

public  class AuditDefinedRequestReviewer : AuditBaseEntity
{
    public long DefinedRequestId { get; set; }

    public string AssignedReviewerId { get; set; }

    public string DelegatedReviewerId { get; set; }
    
    public string StageName { get; set; }

    public int StageNumber { get; set; }

    public string ReviewerType { get; set; }

    public DateTime? DelegatedUntil { get; set; }


}