using EDocument_Data.Consts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.Requests.RequestReviewer
{
    public class ReviewersDetails
    {
        public int StageNumber { get; set; }
        public string StageTitle { get; set; }
        public RequestStatus Status { get; set; }
        public string ReviewedBy { get; set; }
        public string ReviewerNotes { get; set; }
        public List<string> AssignedReviewers { get; set; }

    }

    public class ReviewersDetailsDto
    {
        public RequestStatus Status { get; set; }
        public int? CurrentStage { get; set; }
        public List<ReviewersDetails> ReviewersDetails { get; set; }

    }
}
