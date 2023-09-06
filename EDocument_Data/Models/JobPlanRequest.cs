#nullable disable
using EDocument_Data.Consts;
using EDocument_Data.Consts.Enums;
using EDocument_Data.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.Models
{
    public class JobPlanRequest : BaseEntity
    {
        public string Description { get; set; }
        public JobPlanAction Action { get; set; }
        public long RequestId { get; set; }
        public virtual Request Request { get; set; }
    }
}
