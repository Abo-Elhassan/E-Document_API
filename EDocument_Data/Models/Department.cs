﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using EDocument_Data.Models.Shared;

namespace EDocument_Data.Models;

public class Department :BaseEntity
{
    public long Id { get; set; }

    public string DepartmentName { get; set; }

    public string ManagerId { get; set; }

    public virtual ICollection<ApplicationUser> Employees { get; set; } = new HashSet<ApplicationUser>();

    public virtual ApplicationUser Manager { get; set; }

    public virtual ICollection<BiAccessRequest> BiAccessRequests { get; set; } = new HashSet<BiAccessRequest>();
    public virtual ICollection<CarRequest> CarRequests { get; set; } = new HashSet<CarRequest>();
    public virtual ICollection<DomainAccountRequest> DomainAccountRequests { get; set; } = new HashSet<DomainAccountRequest>();
    public virtual ICollection<MenaPayAccessRequest> MenaPayAccessRequests { get; set; } = new HashSet<MenaPayAccessRequest>();
    public virtual ICollection<OracleFusionAccessRequest> OracleFusionAccessRequests { get; set; } = new HashSet<OracleFusionAccessRequest>();
    public virtual ICollection<TosAccessRequest> TosAccessRequests { get; set; } = new HashSet<TosAccessRequest>();
    public virtual ICollection<TravelDeskRequest> TravelDeskRequests { get; set; } = new HashSet<TravelDeskRequest>();
    

}