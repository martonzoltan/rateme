using RateMe.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RateMe.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MovieModel m = new MovieModel();
            return View(m);
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
    }
}