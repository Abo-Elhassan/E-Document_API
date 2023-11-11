﻿
#nullable disable


using EDocument_Data.Consts.Enums;

namespace EDocument_Data.Models.Audit;

public  class AuditDefinedRequestReviewer : AuditBaseEntity
{
    public long Key { get; set; }
    public long DefinedRequestId { get; set; }

    public string AssignedReviewerId { get; set; }
    
    public string StageName { get; set; }

    public int StageNumber { get; set; }

    public string ReviewerType { get; set; }


}