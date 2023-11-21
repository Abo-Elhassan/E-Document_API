using EDocument_Data.Custom_Attributes;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.Requests.ReschedulePmWoRequest
{
    public class ReschedulePmWoRequestCreateDto
    {
        [Required]
        public string DescriptionOfChange { get; init; }
        [Required]
        public string ReasonForRescheduling { get; init; }
        [Required]
        [OldDateValidator]
        public DateTime RescheduleFrom { get; init; }
        [Required]
        [OldDateValidator]
        [RescheduleToValidation]
        public DateTime RescheduleTo { get; init; }
        [Required]
        public string WoNumber { get; init; }

        [FileValidation(100 * 1024 * 1024,true, ".pdf", ".docx", ".xlsx", ".xls",".csv",".zip",".png",".jpg",".jpeg")]
        public List<IFormFile>? Attachments { get; set; }

        public string? Notes { get; set; }

        [Required]
        public long DefinedRequestId { get; init; }
    }
}
