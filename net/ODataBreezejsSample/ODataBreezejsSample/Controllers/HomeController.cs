using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ODataBreezejsSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Some page in your MVC app.";

            return View();
        }
        public ActionResult BowaA()
        {
            ViewBag.Message = "Original sample with breeze.debug.js";

            return View();
        }
        public ActionResult BowaB()
        {
            ViewBag.Message = "Separate adapters - Q is not defined error";

            return View();
        }
        public ActionResult BowaC()
        {
            ViewBag.Message = "Separate adapters with fixed breeze.dataService.odata.js";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page";

            return View();
        }
    }
}