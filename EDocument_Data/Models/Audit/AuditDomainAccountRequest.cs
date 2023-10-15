#nullable disable
using System;


namespace EDocument_Data.Models.Audit
{
    public class AuditDomainAccountRequest : AuditBaseRequest
    {
        public string DisplayName { get; set; }

        public string LoginName { get; set; }

        public string OU { get; set; }

    }
}
