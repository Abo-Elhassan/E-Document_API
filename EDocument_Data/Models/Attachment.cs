#nullable disable
using EDocument_Data.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.Models
{
    public class Attachment : BaseEntity
    {
        public long Id { get; set; }
        public string FilePath { get; set; }
        public long RequestId { get; set; }
        public Request Request { get; set; }
    }
}
