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
    public class VoucherRequest : BaseRequest
    {
        public int VendorNumber { get; set; }
        public string VendorName { get; set; }
        public string InvoiceNumber { get; set; }
        public string Description { get; set; }
        public float Amount { get; set; }
        public string AmountInWords { get; set; }
        public string Currency { get; set; }

    }
}
