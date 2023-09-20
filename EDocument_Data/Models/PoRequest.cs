#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDocument_Data.Models.Shared;

namespace EDocument_Data.Models
{
    public class PoRequest : BaseEntity
    {
        public string PoNumber { get; set; }
        public string PoDescription { get; set; }
        public string VendorName { get; set; }
        public int VendorNumber { get; set; }
        public string InvoiceNumber { get; set; }
        public string PoAttachmentPath { get; set; }
        public string InvoiceAttachmentPath { get; set; }
        public long RequestId { get; set; }
        public string CreatorFullName { get; set; }
        public virtual Request Request { get; set; }
    }
}
