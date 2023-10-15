#nullable disable
using EDocument_Data.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.Models.Audit
{
    public class AuditAttachment : AuditBaseEntity
    {
        public long Id { get; set; }
        public string FilePath { get; set; }
        public long RequestId { get; set; }

    }
}
