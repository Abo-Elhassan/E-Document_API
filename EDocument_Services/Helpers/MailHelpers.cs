using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Services.Helpers
{
    public record class MailSettings(string Email, string Host, int Port, string? Password=null);

    public record struct MailContent(string To, string Cc, string Subject, string Body, bool IsHTMLBody);
}
