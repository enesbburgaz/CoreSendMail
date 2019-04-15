using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MimeKit;

namespace CoreSendEmail.Models
{
    public class EmailSettingsController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmailSetting emailSetting)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(emailSetting.senderName, emailSetting.userName));
            message.To.Add(new MailboxAddress(emailSetting.recipientName, emailSetting.recipientMail));
            message.Subject = emailSetting.subject;
            message.Body = new TextPart("plain")
            {
                Text = emailSetting.content
            };
            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate(emailSetting.userName, emailSetting.password);
                client.Send(message);
                client.Disconnect(true);
            }
            return RedirectToAction("Index", "EmailSettings");
        }
    }
}
