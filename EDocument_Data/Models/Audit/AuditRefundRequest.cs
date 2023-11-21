#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDocument_Data.Models.Shared;

namespace EDocument_Data.Models.Audit
{
    public class AuditRefundRequest : AuditBaseEntity
    {
        public string RequestNumber { get; set; }
        public long RequestId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerMobileNumber { get; set; }
        public string RefundSubject { get; set; }
        public string RefundDescription { get; set; }
        public string RefundType { get; set; }
        public string ShipmentType { get; set; }
        public string DocumentNumber { get; set; }
        public string RelatedContainers { get; set; }
        public string ConcernedEmployeeId { get; set; }
        public string ConcernedEmployeeName { get; set; }
        public string ConcernedDepartment { get; set; }      
        public string CreditNote { get; set; }
        public string Amount { get; set; }

    }
}
