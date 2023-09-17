using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace EDocument_Data.DTOs.User
{

    public record class UserWriteDto
    {
        
        [Required]
        [StringLength(50)]
        public required string Id { get; init; }

        [Required][StringLength(200)]
        public required string FullName { get; init; }

        [Required]
        [StringLength(50)]
        public required string UserName { get; init; }


        [Required]
        [EmailAddress]
        public required string Email { get; init; }

        [Required]
        [RegularExpression("01[0-9]{9}")]
        public required string PhoneNumber { get; init; }

        [Required]
        public bool IsEmployee { get; init; }

        [Required]
        public bool IsActive { get; init; }


        [StringLength(200)]
        public string? Company { get; init; }

        [StringLength(200)]
        public string? Position { get; init; }

        public long? DepartmentId { get; init; }

        public long? SectionId { get; init; }

        [Required]
        [StringLength(50)]
        public string? ManagerId { get; init; }
         
    }

    public record class CreateUserDto : UserWriteDto
    {

        public required string Password { get; init; }
    }
}
