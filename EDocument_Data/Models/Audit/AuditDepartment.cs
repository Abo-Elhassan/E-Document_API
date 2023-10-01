
#nullable disable
using System;
using System.Collections.Generic;
using EDocument_Data.Models.Audit;


namespace EDocument_Data.Models.Audit;

public class AuditDepartment : AuditBaseEntity
{
    public long Id { get; set; }

    public string DepartmentName { get; set; }
    public string DepartmentIcon { get; set; }

    public string ManagerId { get; set; }


    

}