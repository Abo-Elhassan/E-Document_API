#nullable disable
using EDocument_Data.Consts;
using EDocument_Data.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.Models
{
    public class TravelDeskRequest : BaseRequest
    {
        //public List<TravelDeskRequisition> RequestTypes { get; set; }
        public string RequestTypes { get; set; }


        public string BeneficiaryNationality { get; set; }

        public string AttachmentPath { get; set; }

        public float CostAllocation { get; set; }

        public Currency Currency { get; set; }

    }
}
