using ExtendedHomeHealthcare.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

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
     

    }
    
}