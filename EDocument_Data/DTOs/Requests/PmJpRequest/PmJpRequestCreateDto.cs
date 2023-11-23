using EDocument_Data.Custom_Attributes;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.Requests.PmJpRequest
{
    public class PmJpRequestCreateDto
    {
        [Required]
        public string DescriptionOfChange { get; init; }
        [Required]
        public string ChangeReason { get; init; }
        [Required]
        public string ChangeType { get; init; }
        [Required]
        [OldDateValidator]
        public DateTime StartDate { get; init; }

        [OldDateValidator]
        [MocEndDateValidationAttribute]
        public DateTime? EndDate { get; init; }
        public string? PmJpCode { get; init; }
        public string? AssetType { get; init; }
        public string? AssetCode { get; init; }
        public string? CurrentInterval { get; init; }
        public string? NewInterval { get; init; }
        public string? AddedMaterials { get; init; }
        public string? RemovedMaterials { get; init; }
        public string? AddedLaborCraft { get; init; }
        public string? RemovedLaborCraft { get; init; }
        public string? AddedTask { get; init; }
        public string? RemovedTask { get; init; }
        public string? AddedMeter { get; init; }
        public string? RemovedMeter { get; init; }
        public int? PmPriority { get; init; }


        [FileValidation(100 * 1024 * 1024,true, ".pdf", ".docx", ".xlsx", ".xls",".csv",".zip",".png",".jpg",".jpeg")]
        public List<IFormFile>? Attachments { get; set; }

        public string? Notes { get; set; }

        [Required]
        public long DefinedRequestId { get; init; }
    }
}
