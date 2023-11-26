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
    public class ReschedulePmWoRequest : BaseEntity
    {
        public string RequestNumber { get; set; }
        public string RequesterSection { get; set; }
        public string DescriptionOfChange { get; set; }
        public string ReasonForRescheduling { get; set; }
        public DateTime RescheduleFrom { get; set; }
        public DateTime RescheduleTo{ get; set; }
        public string WoNumber { get; set; }
        public long RequestId { get; set; }
        public virtual Request Request { get; set; }
    }
}
