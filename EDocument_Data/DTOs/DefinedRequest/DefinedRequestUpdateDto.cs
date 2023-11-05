using EDocument_Data.DTOs.DefinedRequestReviewer;
using EDocument_Data.DTOs.DefinedRequestRole;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.DefinedRequest
{
    public class DefinedRequestUpdateDto
    {

        [Required]
        public required string RequestName { get; init; }
        [Required]

        public required string RouteName { get; init; }
        [Required]

        public required int ReviewersNumber { get; init; }
        [Required]

        public required long DepartmentId { get; init; }
        [Required]

        public required List<DefinedRequestReviewerUpdateDto> DefinedRequestReviewers { get; init; }
        [Required]
        public required List<DefinedRequestRoleUpdateDto> DefinedRequestRoles { get; init; }


    }
}
