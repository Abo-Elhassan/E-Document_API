using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace EDocument_Data.DTOs.User
{

    public record struct RegisterUserDto
    {
        
        [Required]
        [StringLength(50)]
        public string Id { get; set; }

        [Required][StringLength(200)]
        public string FullName { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [RegularExpression("01[0-9]{9}")]
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public bool IsEmployee { get; set; }

        [Required]
        public bool IsActive { get; set; }


        [StringLength(200)]
        public string? Company { get; set; }

        [StringLength(200)]
        public string? Position { get; set; }

        public long? DepartmentId { get; set; }

        public long? SectionId { get; set; }

        public long? ManagerId { get; set; }

            
            
           
    }
}
