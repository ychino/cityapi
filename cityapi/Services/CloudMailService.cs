using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace cityapi.Services
{
    public class CloudMailService : IMailService
    {
        private string _mailTo = "sampleadmin@compnay.com";
        private string _mailFrom = "noreply@company.com";

        public void Send(string subject, string message)
        {
            // Output to debug window pretending sending emails
            Debug.WriteLine($"Mail from {_mailFrom} to {_mailTo}, with CloudMailService");
            Debug.WriteLine($"Subject: {subject}");
            Debug.WriteLine($"Message: {message}");

        }
    }
}
