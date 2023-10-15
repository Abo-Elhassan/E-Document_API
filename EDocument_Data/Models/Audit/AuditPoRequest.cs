#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDocument_Data.Models.Shared;

namespace EDocument_Data.Models.Audit
{
    public class AuditPoRequest : AuditBaseEntity
    {
        public string RequestNumber { get; set; }
        public string PoNumber { get; set; }
        public string PoDescription { get; set; }
        public string VendorName { get; set; }
        public int VendorNumber { get; set; }
        public string InvoiceNumber { get; set; }
        public string PoAttachmentPath { get; set; }
        public string InvoiceAttachmentPath { get; set; }
        public long RequestId { get; set; }

    }
}
