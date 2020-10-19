using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FIT5032Assignment.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Rule()
        {
            ViewBag.Message = "Rule page";

            return View();
        }

        public ActionResult Skill()
        {
            ViewBag.Message = "Skill page";
            return View();
        }

        public ActionResult Class()
        {
            ViewBag.Message = "Class page";
            return View();
        }
    }
}