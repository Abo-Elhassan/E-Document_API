using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.Requests.RequestReviewer
{
    public class RequestReviewerWriteDto
    {
        [Required]
        public long RequestId { get; set; }
        public string? ReviewedNotes { get; set; }
    }
}
