using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.Models
{
    public class Role: IdentityRole
    {
        public virtual ICollection<DefinedRequest> DefinedRequests { get; set; } = new HashSet<DefinedRequest>();
    }
}
