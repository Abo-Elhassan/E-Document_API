using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.Models.Shared
{
    public class MailSettings 
    {
        public required string DisplayName { get; init; }
        public required string Email { get; init; }
        public required string Host { get; init; }
        public required int Port { get; init; }
        public string? Password { get; init; }

    }


    public class MailContent
    {
        public required string To { get; init; }
        public  string? Cc { get; init; }
        public required string Subject { get; init; }
        public required string Body { get; init; }
        public required bool IsHTMLBody { get; set; }

    }

  
}
