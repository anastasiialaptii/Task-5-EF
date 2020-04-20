using System.Web.Mvc;
using Task5_EF.Models;
using Task5_EF.Interfaces;

namespace Task5_EF.Controllers
{
    public class FlowerController : Controller
    {
        IUnitOfWork unit;
        public FlowerController(IUnitOfWork uof)
        {
            unit = uof;
        }
        public ActionResult GetFlowerList()
        {          
            return View(unit.Flowers.GetAll());
        }

        public ActionResult CreateFlower()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpPost]
        public ActionResult CreateFlower(FlowerModel flower)
        {
            if (ModelState.IsValid)
            {
                unit.Flowers.Create(flower);
                unit.Save();
                return RedirectToAction(nameof(GetFlowerList));
            }
            else
                return View();
        }

        public ActionResult DeleteFlower(FlowerModel flower)
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult EditFlower()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult EditFlower(int? id)
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}