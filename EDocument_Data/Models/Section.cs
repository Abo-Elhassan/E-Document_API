#nullable disable
using EDocument_Data.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.Models
{
    public class Section : BaseEntity
    {
        public long Id { get; set; }
        public string SectionName { get; set; }
        public long? DepartmentId { get; set; }
        public string HeadId { get; set; }
        public Department Department { get; set; }
        public virtual ICollection<User> Employees { get; set; }  = new HashSet<User>();
        public virtual User Head { get; set; }
    }
}
