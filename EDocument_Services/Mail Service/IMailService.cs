using EDocument_Services.Helpers;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Services.Mail_Service
{
    public interface IMailService
    {
        Task SendMailAsync(MailContent mailContent, IList<IFormFile>? attachments);
        string HTMLApprovalMailToString();
    }
}
