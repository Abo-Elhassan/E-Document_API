﻿#nullable disable


namespace EDocument_Data.Models.Audit
{
    public class AuditAccessControlRequest : AuditBaseRequest
    {
        public string AccessedBlocks { get; set; }
        public string AccessMethod { get; set; }
        public string EmployeeSignaturePath { get; set; }
    }
}
