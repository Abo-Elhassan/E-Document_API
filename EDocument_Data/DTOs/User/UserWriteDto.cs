#nullable disable

using System.ComponentModel.DataAnnotations;

namespace EDocument_Data.DTOs.User
{
    public record struct UserWriteDto
    {
        [Required][StringLength(50)] 
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}