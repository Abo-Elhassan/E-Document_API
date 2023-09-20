using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.Requests.PoRequest
{
    public class PoRequestWriteDto
    {
        [Required]
        [RegularExpression("^(SOK.PO.)[0-9]{2}-[0-9]+$")]
        public required string PoNumber { get; init; }

        public string PoDescription { get; init; }
        [Required]
        public required string VendorName { get; init; }
        [Required]
        public int VendorNumber { get; init; }
        [Required]
        public required string InvoiceNumber { get; init; }
        [Required]
        public required string PoAttachmentPath { get; init; }
        [Required]
        public required string InvoiceAttachmentPath { get; init; }

        //public List<Attachment> Attachments { get; set; }
        [Required]
        public long DefinedRequestId { get; init; }
    }
}
