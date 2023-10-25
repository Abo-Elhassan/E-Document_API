using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;
using EDocument_Data.Consts;
using EDocument_Data.Models.Shared;
using Bogus.DataSets;

namespace EDocument_Services.Mail_Service
{
    public class MailService : IMailService
    {
        private readonly IOptions<MailSettings> _mailSettings;

        public MailService(IOptions<MailSettings> mailSettings )
        {
            _mailSettings = mailSettings;
        }

        /// <summary>
        /// this function is used to send mails
        /// </summary>
        /// <param to="args">string must be separated with comma charachter (,) between different emails</param>
        /// <param cc="args">string must be separated with comma charachter (,) between different emails</param>

        public async Task SendMailAsync(MailContent mailContent, IList<IFormFile>? attachments = null)
        {


            var email = new MailMessage();

            // email.From = new MailAddress(_mailSettings.Value.Email, _mailSettings.Value.DisplayName);
            email.From = new MailAddress("eDocument@dpworld.com", "eDocument");
            foreach (var address in mailContent.To.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries))
            {
                email.To.Add(address);
            }

            if (mailContent?.Cc != null)
                foreach (var address in mailContent.Cc.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries))
                {
                    email.CC.Add(address);
                }

            email.Subject = mailContent.Subject;
            email.Body = mailContent.Body;
            email.IsBodyHtml = mailContent.IsHTMLBody;

            if (attachments is not null)
            {
                foreach (var file in attachments)
                {
                    if (file.Length > 0)
                    {
                        email.Attachments.Add(new Attachment(file.FileName));
                    }

                }
            }

          //using var smtp = new SmtpClient(host: _mailSettings.Value.Host, port: _mailSettings.Value.Port);
           //smtp.EnableSsl = true;
           //smtp.Credentials = new NetworkCredential(userName: _mailSettings.Value.Email,password: ApplicationConsts.EmailPassword?.ToString());
           using var smtp = new SmtpClient("10.101.100.199", 25);
            await smtp.SendMailAsync(email);
        }


        public string HTMLApprovalMailToString()
        {
            var templatePath = $@"../{Directory.GetCurrentDirectory()}/Mail Templates/ApprovalMail.html";
            var str = new StreamReader(templatePath);
            var mailText = str.ReadToEnd();
            str.Close();

            mailText = mailText.Replace("", "");

            return mailText;
        }

    }
}
