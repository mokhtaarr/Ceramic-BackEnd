using DAL.interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace infrastrucure.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly IConfiguration _config;

        public EmailSender(IConfiguration config)
        {
            _config = config;

        }
        //public async Task SendEmailAsync(string fromAddress, string toAddress, string subject, string message)
        //{
        //    var mailMessage = new MailMessage(fromAddress, toAddress, subject, message);
        //    using (var smtp = new SmtpClient())
        //    {
        //        var credential = new NetworkCredential
        //        {
        //            UserName = "eldoliaeldolia@gmail.com",
        //            Password = "ntchwlibrrkpejkv"
        //        };
        //        try
        //        {
        //            smtp.Host = "smtp.gmail.com";
        //            smtp.Port = 587;
        //            smtp.EnableSsl = true;
        //            smtp.UseDefaultCredentials = false;
        //            smtp.Credentials = credential;
        //            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
        //            smtp.Send(mailMessage);
        //            await smtp.SendMailAsync(mailMessage);
        //        }
        //        catch (Exception ex)
        //        {
        //            throw;
        //        }
        //    }
           
        //}

         public async Task SendEmailAsync(string fromAddress, string toAddress, string subject, string message)
         {
            var mailMessage = new MailMessage(fromAddress, toAddress, subject, message);
            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = "Info@beshayholding.com",
                    Password = "Eldolia@123456"
                };
                try
                {
                    smtp.Host = "mail.beshayholding.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = credential;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Send(mailMessage);
                    await smtp.SendMailAsync(mailMessage);
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
           
         }
    }
}
