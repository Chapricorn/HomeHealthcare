using ExtendedHomeHealthcare.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ExtendedHomeHealthcare.Controllers
{
    public class HomeController : Controller
    {
        // GET /home/index
        public ActionResult Index()
        {
            return View();
        }

        // GET /home/about
        public ActionResult About()
        {
            ViewBag.Message = "Your about page.";

            return View();
        }
        public ActionResult Services()
        {
            ViewBag.Message = "Your service page.";

            return View();
        }
        public ActionResult Employment()
        {
            ViewBag.Message = "Your employment page.";

            return View();
        }
        public ActionResult Gallery()
        {
            ViewBag.Message = "Your gallery page.";

            return View();
        }



        //[HttpGet]
        //public ActionResult Create()
        //{
        //    return View();
        //}


        //[Authorize(Roles = "Admin")]
        [Authorize]
        public ActionResult Caregiver()
        {

            ViewBag.Message = "Your caregiver page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact(EmailModel model)
        {
            if (ModelState.IsValid)
            {
                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("koudkou@gmail.com"));  // replace with valid value 
                message.From = new MailAddress("sender@gmail.com");  // replace with valid value
                message.Subject = "Your email subject";
                message.Body = string.Format(body, model.Name, model.EmailAddress, model.PhoneNumber, model.Message);
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "koudkou@gmail.com",  // replace with valid value
                        Password = "19koucha80"  // replace with valid value
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp-mail.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Sent");
                }
            }
            return View(model);
        }
        public ActionResult Sent()
        {
            return View();
        }

    }
    
}