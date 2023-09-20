using EDocument_Data.Consts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.Requests.RequestReviewer
{
    public class RequestReviewerReadDto
    {
        public string? AssignedReviewer { get; set; }

        public string? ReviewedBy { get; set; }

        public string? StageName { get; set; }

        public int StageNumber { get; set; }

        public ReviewerType ReviewerType { get; set; }

        public RequestStatus Status { get; set; }

        public string? ReviewerNotes { get; set; }
    }
}
