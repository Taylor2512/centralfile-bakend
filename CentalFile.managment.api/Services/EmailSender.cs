using Microsoft.AspNetCore.Identity.UI.Services;

using System.Net;
using System.Net.Mail;

namespace CentalFile.managment.api.Services
{
    public class EmailSender(IConfiguration configuration) : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            IConfigurationSection smtpConfig = configuration.GetSection("Smtp");
            SmtpClient smtpClient = new(smtpConfig["Host"])
            {
                Port = int.Parse(smtpConfig["Port"]),
                Credentials = new NetworkCredential(smtpConfig["Username"], smtpConfig["Password"]),
                EnableSsl = true,
            };

            MailMessage mailMessage = new()
            {
                From = new MailAddress(smtpConfig["Username"]),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true,
            };
            mailMessage.To.Add(email);

            return smtpClient.SendMailAsync(mailMessage);
        }
    }
}