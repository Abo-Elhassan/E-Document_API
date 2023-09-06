#nullable disable
using EDocument_Data.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.Models
{
    public class DefinedApplication :BaseEntity
    {
        public long Id { get; set; }
        public string ApplicationName { get; set; }
        public string ApplicationOwnerId { get; set; }
        public User ApplicationOwner { get; set; }

        public virtual ICollection<User> ItAdmins { get; set; } = new HashSet<User>();
        public virtual ICollection<DefinedApplicationRole> DefinedApplicationRoles { get; set; } = new HashSet<DefinedApplicationRole>();
        public virtual ICollection<RequestApplicationRole> RequestApplicationRoles { get; set; } = new HashSet<RequestApplicationRole>();

    }
}
