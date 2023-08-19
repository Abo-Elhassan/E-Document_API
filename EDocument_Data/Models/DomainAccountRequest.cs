#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDocument_Data.Models.Shared;

namespace EDocument_Data.Models
{
    public class DomainAccountRequest : BaseRequest
    {
        public string DisplayName { get; set; }

        public string LoginName { get; set; }

        public string OU { get; set; }

    }
}
