using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentScholarshipRegistration.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            throw new Exception("Something went wrong");
        }

        public ActionResult NotFound()
        {
            return View();
        }




    }
}