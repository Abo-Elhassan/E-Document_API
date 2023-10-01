#nullable disable
using EDocument_Data.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.Models.Audit
{
    public class AuditDefinedApplication : AuditBaseEntity
    {
        public long Id { get; set; }
        public string ApplicationName { get; set; }
        public string ApplicationOwnerId { get; set; }



    }
}
