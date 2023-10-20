﻿
#nullable disable
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace EDocument_Data.Models;

public partial class User:IdentityUser
{
    public override string UserName { get; set; }

    public override string NormalizedUserName { get; set; }

    public string FullName { get; set; }

    public string Position { get; set; }

    public long? DepartmentId { get; set; }

    public long? SectionId { get; set; }

    public string ManagerId { get; set; }

    public string Company { get; set; }

    public string Roles { get; set; }

    public bool HasLDAP { get; set; }

    public DateTime? LastLogin { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? ModifiedAt { get; set; }

    public string CreatedBy { get; set; }

    public string ModifiedBy { get; set; }

    public virtual ICollection<DefinedRequestReviewer> DefinedRequestReviewers { get; set; } = new HashSet<DefinedRequestReviewer>();

    public virtual Department Department{ get; set; }

    public virtual Section Section { get; set; }

    public virtual User Manager { get; set; }

    public virtual ICollection<Department> ManagedDepartments { get; set; } = new HashSet<Department>();

    public virtual Section MangedSection { get; set; }

    public virtual ICollection<User> ManagedEmployees { get; set; } = new HashSet<User>();

    public virtual ICollection<Request> CreatedRequests { get; set; } = new HashSet<Request>();

    public virtual ICollection<RequestReviewer> RequestReviewers { get; set; } = new HashSet<RequestReviewer>();

    public virtual ICollection<DefinedApplication> OwnedApplications { get; set; } = new HashSet<DefinedApplication>();

    public virtual ICollection<DefinedApplication> ManagedApplications { get; set; } = new HashSet<DefinedApplication>();



}