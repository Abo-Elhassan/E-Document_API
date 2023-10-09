using EDocument_Data.Consts.Enums;
using EDocument_Data.DTOs.Attachments;
using EDocument_Data.DTOs.Requests.RequestReviewer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Attachment = EDocument_Data.Models.Attachment;

namespace EDocument_Data.DTOs.DefinedRequest
{
    public class DefinedRequestReadDto
    {

        public long Id { get; init; }

        public required string RequestName { get; init; }


        public required string RouteName { get; init; }


        public required int ReviewersNumber { get; init; }


        public required long DepartmentId { get; init; }

        public required string DepartmentName { get; init; }


        public required List<DefinedRequestReviewerDto> DefinedRequestReviewers { get; init; }

        public required List<DefinedRequestRoleDto> DefinedRequestRoles { get; init; }

        public string CreatedBy { get; init; }
        public string ModifiedBy { get; init; }
        public DateTime? CreatedAt { get; init; }
        public DateTime? ModifiedAt { get; init; }


    }

}
