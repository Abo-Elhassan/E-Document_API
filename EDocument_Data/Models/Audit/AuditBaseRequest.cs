#nullable disable
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.Models.Audit
{
    public class AuditBaseRequest : AuditBaseEntity
    {

        public string RequestNumber { get; set; }

        public string BeneficiaryId { get; set; }

        public string BeneficiaryName { get; set; }

        public string BeneficiaryEmail { get; set; }

        public string BeneficiaryPosition { get; set; }

        public string BeneficiaryDepartment { get; set; }

        public string BeneficiaryPhoneNumber { get; set; }

        public string BeneficiaryCompany { get; set; }

        public int? BeneficiaryExtention { get; set; }

        public long RequestId { get; set; }



    }
}
