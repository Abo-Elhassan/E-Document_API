﻿#nullable disable
using EDocument_Data.Models.Shared;


namespace EDocument_Data.Models
{
    public class FuelOilInvoiceRequest : BaseRequest
    {
        public string ProductType { get; set; }
        public string InvoiceNumber { get; set; }
        public int ReceiptNumber { get; set; }
        public int? SwiftNumber { get; set; }
        public DateTime RequestedDate { get; set; }
    }
}
