using Microsoft.AspNetCore.Identity.UI.Services;

namespace Asset_Management.Services
{
    public class DevelopmentEmailSender : IEmailSender
    {
        private readonly ILogger _logger;

        public DevelopmentEmailSender(ILogger<DevelopmentEmailSender> logger)
        {
            _logger = logger;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            _logger.LogInformation(
                "Email: {email}\nSubject: {subject}\nMessage: {message}",
                email, subject, htmlMessage);
            
            return Task.CompletedTask;
        }
    }
}