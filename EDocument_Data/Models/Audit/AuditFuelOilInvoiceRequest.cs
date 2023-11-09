#nullable disable   

using EDocument_Data.Models.Shared;

namespace EDocument_Data.Models.Audit
{
    public class AuditFuelOilInvoiceRequest:AuditBaseRequest
    {
       
            public string ProductType { get; set; }
            public string InvoiceNumber { get; set; }
            public int ReceiptNumber { get; set; }
            public DateTime RequestedDate { get; set; }
        
    }
}
