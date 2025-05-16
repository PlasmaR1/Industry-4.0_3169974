using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Industry_4._0.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
