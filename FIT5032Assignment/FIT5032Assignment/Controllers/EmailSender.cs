using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace FIT5032Assignment.Controllers
{
    public class EmailSender
    {
        // Please use your API KEY here.
        private const String API_KEY = "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                                                                                      ";

        public void Send(String toEmail, String subject, String contents)
        {
            var client = new SendGridClient(API_KEY);
            var from = new EmailAddress("475094645@qq.com", "FIT5032 Example Email User");
            var to = new EmailAddress(toEmail, "");
            var plainTextContent = contents;
            var htmlContent = "<p>" + contents + "</p>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = client.SendEmailAsync(msg);
        }

    }
}