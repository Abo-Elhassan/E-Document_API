using EDocument_Data.Consts.Enums;
using System.ComponentModel.DataAnnotations;

namespace EDocument_Data.DTOs.DefinedRequest
{
    public class DefinedRequestRoleCreateDto
    {
        [Required]
        public required string RoleId { get; init; }

        [Required]
        public RequestPermission Permission { get; init; }
    }
}
