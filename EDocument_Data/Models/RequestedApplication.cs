#nullable disable
using EDocument_Data.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.Models
{
    public class RequestedApplication :BaseEntity
    {
        public long Id { get; set; }
        public string ApplicationName { get; set; }
        public string ApplicationOwnerId { get; set; }
        public ApplicationUser ApplicationOwner { get; set; }

        public virtual ICollection<DefinedRequestRole> DefinedRequestRoles { get; set; } = new HashSet<DefinedRequestRole>();

        public virtual ICollection<DefinedRequestReviewer> DefinedRequestReviewers { get; set; } = new HashSet<DefinedRequestReviewer>();
    }
}
