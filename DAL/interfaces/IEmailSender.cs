using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string fromAddress, string toAddress, string subject, string message);
    }
}
