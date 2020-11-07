using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using MimeKit;

namespace authproject.Services
{
    public class EmailSender : IEmailSender
    {
        private SmtpEmailOptions _options;
        public EmailSender(IConfiguration configuration)
        {
            _options = configuration.GetSection("EmailSetting").Get<SmtpEmailOptions>();

        }
        public async Task SendEmailAsync(string email, string subject, string htmlMessage){

            var message = new MimeMessage();


            message.From.Add(new MailboxAddress(_options.Username, _options.Username));
            //MailboxAddress(name, email)

            message.To.Add(new MailboxAddress(email, email));

            message.Subject = subject;

            var bodyBuilder = new BodyBuilder();

            bodyBuilder.HtmlBody = htmlMessage;

            message.Body = bodyBuilder.ToMessageBody();

            using(var client = new SmtpClient()){

                await client.ConnectAsync(_options.Host, _options.Port, SecureSocketOptions.SslOnConnect);
                client.AuthenticationMechanisms.Remove("XOAUTH2");
                await client.AuthenticateAsync(_options.Username, _options.Password);
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }

        }

    }
}