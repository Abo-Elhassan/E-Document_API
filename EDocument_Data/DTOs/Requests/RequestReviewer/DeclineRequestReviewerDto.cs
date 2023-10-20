using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.Requests.RequestReviewer
{
    public class DeclineRequestReviewerDto
    {
        [Required]
        public long RequestId { get; set; }
        [Required]
        public string ReviewedNotes { get; set; }
    }
}
