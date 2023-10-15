#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.Models.Shared
{
    public class BaseRequest : BaseEntity
    {
        public string RequestNumber { get; set; }

        public string BeneficiaryId { get; set; }

        public string BeneficiaryName { get; set; }

        public string BeneficiaryEmail { get; set; }

        public string BeneficiaryPosition { get; set; }

        public string BeneficiaryDepartment { get; set; }

        public string BeneficiaryPhoneNumber { get; set; }

        public string BeneficiaryExtention { get; set; }

        public long RequestId { get; set; }

        public virtual Request Request { get; set; }


    }
}
