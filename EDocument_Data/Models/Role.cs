
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.Models
{
    public class Role: IdentityRole<string>
    {
        public virtual ICollection<DefinedRequestRole> DefinedRequestRoles { get; set; } = new HashSet<DefinedRequestRole>();
    }
}
