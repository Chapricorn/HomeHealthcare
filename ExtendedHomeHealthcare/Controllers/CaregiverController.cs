using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExtendedHomeHealthcare.Controllers
{
    public class CaregiverController : Controller
    {
        // GET: Caregiver
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        //[Authorize(Roles = "Admin")]
        [Authorize]
        public ActionResult Caregiver()
        {

            ViewBag.Message = "Your caregiver page.";

            return View();
        }

    }
}