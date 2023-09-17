using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.Role
{
    public class RoleWriteDto
    {
        [Required]
        [StringLength(450)]
        public required string Id { get; init; }

        [Required]
        [StringLength(256)]
        public required string Name { get; init; }


    }
}
