using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rajit.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult pop()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult VV()

        {
            ViewBag.Message = "New  page.";
            return View();
        }


        public ActionResult Zerif()

        {
            ViewBag.Message = "New  page.";
            return View();
        }


        public  ActionResult CompanyProfile()
        {

            return View();

        }


    }
}