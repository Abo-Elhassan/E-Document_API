using EDocument_Data.Consts.Enums;
using System.ComponentModel.DataAnnotations;

namespace EDocument_Data.DTOs.DefinedRequest
{
    public class DefinedRequestRoleUpdateDto
    {
        [Required]
        public required string RoleId { get; init; }

        [Required]
        public long DefinedRequestId { get; init; }
        [Required]
        public RequestPermission Permission { get; init; }
    }
}
