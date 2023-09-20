﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable

using System;
using System.Collections.Generic;
using EDocument_Data.Consts.Enums;
using EDocument_Data.Models.Shared;

namespace EDocument_Data.Models;

public partial class Request : BaseEntity
{
    public long Id { get; set; }

    public int? CurrentStage { get; set; }

    public RequestStatus Status { get; set; }

    public string Justification { get; set; }

    public string CreatorId { get; set; }

    public string CreatorFullName { get; set; }

    public long DefinedRequestId { get; set; }

    public virtual ICollection<Attachment> Attachments { get; set; } = new HashSet<Attachment>();
    
    public virtual User Creator { get; set; }

    public virtual DefinedRequest DefinedRequest { get; set; }

    public virtual ICollection<RequestApplicationRole> RequestApplicationRoles { get; set; } = new HashSet<RequestApplicationRole>();
    public virtual ICollection<RequestReviewer> RequestReviewers { get; set; } = new HashSet<RequestReviewer>();
    public virtual ICollection<CarRequest> CarRequests { get; set; } = new HashSet<CarRequest>();
    public virtual ICollection<TravelDeskRequest> TravelDeskRequests { get; set; } = new HashSet<TravelDeskRequest>();
    public virtual ICollection<ApplicationUserRequest> ApplicationUserRequests { get; set; } = new HashSet<ApplicationUserRequest>();
    public virtual ICollection<DomainAccountRequest> DomainAccountRequests { get; set; } = new HashSet<DomainAccountRequest>();
    public virtual ICollection<VoucherRequest> VoucherRequests { get; set; } = new HashSet<VoucherRequest>();
    public virtual PoRequest PoRequest { get; set; } 
    //public virtual ICollection<JobPlanRequest> JobPlanRequests { get; set; } = new HashSet<JobPlanRequest>();

}