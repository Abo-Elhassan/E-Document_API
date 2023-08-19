#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.User
{
    public record struct LoginWriteDto([property: Required] string UserName, [property: Required] string Password);
}
