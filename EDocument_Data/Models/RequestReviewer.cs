#nullable disable
using EDocument_Data.Consts.Enums;
using EDocument_Data.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.Models
{
    public class RequestReviewer : BaseEntity
    {
        public long RequestId { get; set; }

        public string AssignedReviewerId { get; set; }

        public string ReviewedBy { get; set; }

        public string StageName { get; set; }

        public int StageNumber { get; set; }

        public ReviewerType ReviewerType { get; set; }

        public string Status { get; set; }

        public string ReviewerNotes { get; set; }

        public virtual Request Request { get; set; }

        public virtual User Reviewer { get; set; }
    }
}
