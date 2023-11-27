
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;


namespace EDocument_Data.DTOs.Requests.MultimediaRequest
{
    public class ApproveMultimediaRequestDto
    {
        [Required]
        public long RequestId { get; init; }
        public DateTime? EstimatedDeliveryDate { get; init; }
        public IFormFile? PrTeamAttachment { get; init; }
        public string? ReviewedNotes { get; init; }
    }
}
