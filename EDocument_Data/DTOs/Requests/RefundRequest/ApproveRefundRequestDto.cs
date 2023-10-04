using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.Requests.RefundRequest
{
    public class ApproveRefundRequestDto
    {
        [Required]
        public long RequestId { get; set; }
        public string? CreditNote { get; set; }
        public string? Amount { get; set; }
        public string? ReviewedNotes { get; set; }
    }
}
