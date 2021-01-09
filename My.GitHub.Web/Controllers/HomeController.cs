using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace My.GitHub.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page322231.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page322222222.";

            return View();
        }
    }
}