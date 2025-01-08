using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using MimeKit;
using TravelPlanning.Data;



namespace TravelPlanning.Services
{
    public class GmailEmailSender : IEmailSender<TravelPlanningUser>
    {
        private readonly IConfiguration _config;
        private readonly ILogger<GmailEmailSender> _logger;

        public GmailEmailSender(IConfiguration config, ILogger<GmailEmailSender> logger)
        {
            _config = config;
            _logger = logger;
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress(_config["Gmail:SenderName"], _config["Gmail:SenderEmail"]));
            emailMessage.To.Add(MailboxAddress.Parse(email));
            emailMessage.Subject = subject;

            var builder = new BodyBuilder
            {
                HtmlBody = htmlMessage
            };

            emailMessage.Body = builder.ToMessageBody();

            try
            {
                using var client = new SmtpClient();
                // Gmail SMTP settings
                await client.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                await client.AuthenticateAsync(_config["Gmail:Email"], _config["Gmail:AppPassword"]);
                await client.SendAsync(emailMessage);
                await client.DisconnectAsync(true);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to send email to {Email}", email);
                throw;
            }
        }

        public async Task SendConfirmationLinkAsync(TravelPlanningUser user, string email, string confirmationLink)
        {
            string subject = "Confirm your Travel Planning Account";
            string htmlMessage = $@"
            <h1>Welcome to Travel Planning!</h1>
            <p>Thank you for registering. Please confirm your account by <a href='{confirmationLink}'>clicking here</a>.</p>
            <p>If you did not create this account, you can ignore this email.</p>
            <br/>
            <p>Best regards,<br/>Travel Planning Team</p>";

            await SendEmailAsync(email, subject, htmlMessage);
        }

        public Task SendPasswordResetCodeAsync(TravelPlanningUser user, string email, string resetCode)
        {
            throw new NotImplementedException();
        }

        public Task SendPasswordResetLinkAsync(TravelPlanningUser user, string email, string resetLink)
        {
            throw new NotImplementedException();
        }
    }
}
