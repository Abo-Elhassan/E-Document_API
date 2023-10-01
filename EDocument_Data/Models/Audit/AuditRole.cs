
using Microsoft.AspNetCore.Identity;
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
    public class AuditRole : IdentityRole<string>
    {
        [Key]
        [Column(TypeName = "numeric(18,0)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Key { get; set; }
        public DateTime? CreatedAt { get; set; }

        public DateTime? ModifiedAt { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        public string TransactionType { get; set; }
        public string DataStatus { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
