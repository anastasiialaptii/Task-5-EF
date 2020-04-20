using System.Web.Mvc;
using Task5_EF.Models;
using Task5_EF.Interfaces;

namespace Task5_EF.Controllers
{
    public class FlowerController : Controller
    {
        IUnitOfWork entityUnit;
        public FlowerController(IUnitOfWork unitOfWork)
        {
            entityUnit = unitOfWork;
        }
        public ActionResult GetFlowerList()
        {
            return View(entityUnit.Flowers.GetAll());
        }

        public ActionResult CreateFlower()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateFlower(FlowerModel flower)
        {
            if (ModelState.IsValid)
            {
                entityUnit.Flowers.Create(flower);
                entityUnit.Save();
                return RedirectToAction(nameof(GetFlowerList));
            }
            return View();
        }

        public ActionResult DeleteFlower(FlowerModel flower)
        {
            entityUnit.Flowers.Delete(flower);
            entityUnit.Save();
            return RedirectToAction(nameof(GetFlowerList));
        }

        public ActionResult EditFlower(int id)
        {
            return View(entityUnit.Flowers.GetById(id));
        }

        [HttpPost]
        public ActionResult EditFlower(FlowerModel flower)
        {
            if (ModelState.IsValid)
            {
                entityUnit.Flowers.Update(flower);
                entityUnit.Save();
                return RedirectToAction(nameof(GetFlowerList));
            }

            return View();
        }
    }
}