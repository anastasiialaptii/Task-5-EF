using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task5_EF.Managers;
using Task5_EF.Models;

namespace Task5_EF.Controllers
{
    public class HomeController : Controller
    {
        StatusTableManager myManager = new StatusTableManager();
        public ActionResult Index()
        {
           // myManager.Create();
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
    }
}