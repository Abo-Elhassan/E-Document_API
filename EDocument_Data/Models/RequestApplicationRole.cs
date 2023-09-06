#nullable disable
using EDocument_Data.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.Models
{
    public class RequestApplicationRole:BaseEntity
    {
        public long RequestId { get; set; }
        public long ApplicationId { get; set; }
        public long RoleId { get; set; }
        public Request Request { get; set; }
        public DefinedApplication Application { get; set; }
        public DefinedApplicationRole Role { get; set; }
    }
}
