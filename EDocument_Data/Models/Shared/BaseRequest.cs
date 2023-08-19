﻿#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.Models.Shared
{
    public class BaseRequest : BaseEntity
    {
        public string BeneficiaryId { get; set; }

        public string BeneficiaryName { get; set; }

        public string BeneficiaryEmail { get; set; }

        public string BeneficiaryPostion { get; set; }

        public string BeneficiaryDepartment { get; set; }

        public string BeneficiaryPhone { get; set; }

        public string BeneficiaryExtention { get; set; }

        public string RequesterPurpose { get; set; }

        public long RequestId { get; set; }

        public virtual Request Request { get; set; }

        public long DepartmentId { get; set; }

        public virtual Department Department { get; set; }
    }
}
