using EDocument_Data.Consts.Enums;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;


namespace EDocument_Data.DTOs.Requests.CCTVAccessRequest
{
    public class CCTVAccessRequestUpdateDto
    {

        public int? BeneficiaryExtention { get; init; }

        [Required]
        public List<string> RequestedRoles { get; init; }

        public string? Notes { get; set; }

    }
}
