#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDocument_Data.Consts.Enums;
using EDocument_Data.Models.Shared;

namespace EDocument_Data.Models
{
    public class VoucherRequest : BaseEntity
    {
        public string VendorNumber { get; set; }
        public string VendorName { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string BeneficiaryName { get; set; }
        public string Description { get; set; }
        public float VoucherAmount { get; set; }
        public Currency VoucherCurrency{ get; set; }
        public string VoucherType{ get; set; }
        public  long RequestId { get; set; }
        public virtual Request Request { get; set; }
    }
}
