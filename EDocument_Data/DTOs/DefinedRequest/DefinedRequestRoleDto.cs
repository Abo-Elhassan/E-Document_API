using EDocument_Data.Consts.Enums;
using System.ComponentModel.DataAnnotations;

namespace EDocument_Data.DTOs.DefinedRequest
{
    public class DefinedRequestRoleDto
    {
        [Required]
        public string RoleId { get; init; }

        public string RoleName { get; set; }
        [Required]
        public long DefinedRequestId { get; init; }
        [Required]
        public RequestPermission Permission { get; init; }
    }
}
