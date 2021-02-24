using StepUpToPlants.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StepUpToPlants.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IndexViewModel idx = new IndexViewModel();

            return View(idx);
        }

        public ActionResult YourGarden()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Tips()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Page404()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}