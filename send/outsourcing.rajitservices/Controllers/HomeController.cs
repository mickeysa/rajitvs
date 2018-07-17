using Dapper;
using outsourcing.rajitservices.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace outsourcing.rajitservices.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult CompanyProfile()
        {
            ViewBag.Title = "Company Profile";
            return View();
        }
        public ActionResult LanguageSolution()
        {
            ViewBag.Title = "Language Solution";
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Career()
        {
            ViewBag.Message = "Your contact page.";
            List<Career> FriendList = new List<Career>();
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString))
            {

                FriendList = db.Query<Career>("SELECT *  FROM Departments").ToList();
            }
            return View("Career",FriendList);
        }
        public ActionResult WhyUs()
        {
            ViewBag.Message = "Why Us";

            return View();
        }


        public ActionResult Test()
        {
            ViewBag.Title = "Raj It Services";
            return View();

        }
        public ActionResult SendEmail()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(MailModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (MailMessage mm = new MailMessage("developer.mickey.jaipur@gmail.com", model.Email))
                    {

                        mm.Bcc.Add("developer.mickey.jaipur@gmail.com");

                        mm.Subject = model.Message;
                        mm.Body = model.Message;
                        if (model.Attachment != null)
                        {
                            if (model.Attachment.ContentLength > 0)
                            {
                                string fileName = Path.GetFileName(model.Attachment.FileName);
                                mm.Attachments.Add(new Attachment(model.Attachment.InputStream, fileName));
                            }
                        }


                        mm.IsBodyHtml = false;

                        using (SmtpClient smtp = new SmtpClient())
                        {
                            smtp.Host = "smtp.gmail.com";
                            smtp.EnableSsl = true;
                            NetworkCredential NetworkCred = new NetworkCredential("developer.mickey.jaipur@gmail.com", "Hare@krishna");
                            smtp.UseDefaultCredentials = true;
                            smtp.Credentials = NetworkCred;
                            smtp.Port = 587;
                            smtp.Send(mm);
                            ViewBag.Message = string.Format("Thank you for contacting us – we will get back to you soon!");
                            ModelState.Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = string.Format("Some Error Occured Please Try again after some time ");
            }
            
            return View();
        }
         
    }
}