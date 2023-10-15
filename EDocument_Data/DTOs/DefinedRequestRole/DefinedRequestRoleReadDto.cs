using EDocument_Data.Consts.Enums;
using System.ComponentModel.DataAnnotations;

namespace EDocument_Data.DTOs.DefinedRequestRole
{
    public class DefinedRequestRoleReadDto
    {

        public string RoleId { get; init; }
        public string RoleName { get; set; }
        public long DefinedRequestId { get; init; }
        public RequestPermission Permission { get; init; }
    }
}
