using BetterCms.Sandbox.Mvc4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace BetterCms.Sandbox.Mvc4.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
        //[HttpPost]
       /* public virtual ActionResult ContactForm(ContactFormViewModel viewModel)
        {
            bool success;

            if (ModelState.IsValid)
            {
                using (var message = new MailMessage())
                {
                    message.From = new MailAddress(BCMSExtenstions.SmtpConfigSettings.mailSettings.Smtp.From);
                    message.ReplyToList.Add(new MailAddress(viewModel.Email));
                    message.To.Add(new MailAddress(viewModel.EmailTo));
                    message.Subject = String.Format(
                        BCMSExtenstions.GlobalValidationsResx.ContactFormSubjectPrefix, viewModel.Name);
                    message.IsBodyHtml = true;
                    message.Body = EmailHelper.FormatMessage(viewModel);

                    try
                    {
                        SmtpClient client = new SmtpClient();
                        client.Send(message);
                        success = true;
                    }
                    catch (Exception)
                    {
                        success = false;
                    }
                }
            }
            else
            {
                success = false;
            }

            return new JsonResult
            {
                Data = new
                {
                    success = success,
                    message = success ? "Your message successfully send." : "Sorry there has been an error while sending your message, please try again later."
                }
            };
        }*/
    }
}
