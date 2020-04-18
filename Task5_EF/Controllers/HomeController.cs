using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task5_EF.Managers;
using Task5_EF.Models;
using Task5_EF.Repository;

namespace Task5_EF.Controllers
{
    public class HomeController : Controller
    {
        IFlowerRepository flowerRepository;
        public HomeController(IFlowerRepository r)
        {
            flowerRepository = r;
        }
        public ActionResult Index()
        {
            return View(flowerRepository.GetFlowers());
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