﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable

using System;
using System.Collections.Generic;
using EDocument_Data.Consts.Enums;
using EDocument_Data.Models.Shared;

namespace EDocument_Data.Models;

public  class DefinedRequestReviewer : BaseEntity
{
    public long Key { get; set; }
    public long DefinedRequestId { get; set; }

    public string AssignedReviewerId { get; set; }

    public string StageName { get; set; }

    public int StageNumber { get; set; }

    public ReviewerType ReviewerType { get; set; }

    public virtual DefinedRequest DefinedRequest { get; set; }

    public virtual User Reviewer { get; set; }

}