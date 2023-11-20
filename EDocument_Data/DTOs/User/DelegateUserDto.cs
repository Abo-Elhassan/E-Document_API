using EDocument_Data.Custom_Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.User
{
    public class DelegateUserDto
    {
        [Required]
        [MaxLength(50)]
        public string DelegatedUserId { get; init; }
        [Required]
        [OldDateValidator]
        public DateTime DelegatedUntil { get; init; }
    }
}
