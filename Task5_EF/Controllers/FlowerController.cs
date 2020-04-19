using System.Web.Mvc;
using Task5_EF.Models;
using Task5_EF.Repository;

namespace Task5_EF.Controllers
{
    public class FlowerController : Controller
    {
        IFlowerRepository flowerRepository;
        public FlowerController(IFlowerRepository repository)
        {
            flowerRepository = repository;
        }
        public ActionResult GetFlowerList()
        {
            return View(flowerRepository.GetFlowers());
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
                flowerRepository.InsertFlower(flower);
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