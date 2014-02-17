using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BSDemoMVC.Models;
using System.Net.Mail;
using System.Net;

namespace BSDemoMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About us tag line.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "";

            return View(new Contactus());
        }

        [HttpPost]
        public ActionResult Contact(Contactus contactform)
        {
            if (ModelState.IsValid)
            {
                SendEmail(contactform.Name,contactform.Email,contactform.Phone,contactform.Message);
                return RedirectToAction("ContactConfirm","Home");

            }
            return View();
 
        }

        private void SendEmail(string Name,string Email,string Phone ,string Message)
        {
            MailMessage msg = new MailMessage();
            msg.To.Add(new MailAddress(Email));
            msg.From = new MailAddress("dakbharat@gmail.com", "Contact us");
            msg.CC.Add(new MailAddress("dakbharat@gmail.com"));
            msg.Subject = "Contact us inquiry .";
            string body = "Name: " + Name + "n"
                        + "Email: " + Email + "n"                        
                        + "Phone: " + Phone + "n"
                        + "Message: " + Message + "nn";
            msg.Body = body;
            msg.IsBodyHtml = false;
            SmtpClient smtpclient = new SmtpClient("smtp.gmail.com",587);
            smtpclient.Credentials = new NetworkCredential("dakbharat@gmail.com", "mypwd");
            smtpclient.Send(msg);
            msg.Dispose();

 
        }
        public ActionResult ContactConfirm()
        {
            return View();
        }
 
        public ActionResult Quality()
        {
            return View();
        }
        public ActionResult Client()
        {
            return View();
        }
        public ActionResult Infrastructure()
        {
            return View();
        }

        public ActionResult Research()
        {
            return View();
        }
    }
}