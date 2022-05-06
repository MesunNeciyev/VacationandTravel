using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelandVacation.Models.Data;

namespace TravelandVacation.Controllers
{
    public class HomeController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var infos = c.AboutPages.ToList();

            return View(infos);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Destinations()
        {
            ViewBag.Message = "Your Destination page.";

            return View();
        }

        public ActionResult Blog()
        {
            ViewBag.Message = "Your Blog page.";

            return View();
        }
    }
}