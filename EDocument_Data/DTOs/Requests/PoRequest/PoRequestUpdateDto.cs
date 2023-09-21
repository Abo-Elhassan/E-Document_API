using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.Requests.PoRequest
{
    public class PoRequestUpdateDto
    {
        [Required]
        public  long requestId { get; init; }

        [Required]
        public string PoDescription { get; init; }
        [Required]
        public  string VendorName { get; init; }
        [Required]
        public int VendorNumber { get; init; }
        [Required]
        public  string InvoiceNumber { get; init; }
        [Required]
        public  string PoAttachmentPath { get; init; }
        [Required]
        public  string InvoiceAttachmentPath { get; init; }

        //public List<Attachment> Attachments { get; set; }



    }
}
