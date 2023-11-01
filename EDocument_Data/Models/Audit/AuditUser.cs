
#nullable disable
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDocument_Data.Models.Audit;

public partial class AuditUser:IdentityUser
{
    [Key]
    [Column(TypeName = "numeric(18,0)")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal AuditId { get; set; }

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

    public string TransactionType { get; set; }
    public string DataStatus { get; set; }

    public DateTime TimeStamp { get; set; }



}