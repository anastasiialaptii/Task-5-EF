using System.Web.Mvc;
using Task5_EF.Interfaces;
using Task5_EF.Models;

namespace Task5_EF.Controllers
{
    public class FlowerPlantationController : Controller
    {
        IUnitOfWork entityUnit;

        public FlowerPlantationController(IUnitOfWork unitOfWork)
        {
            entityUnit = unitOfWork;
        }
        public ActionResult GetFlowerPlantationList()
        {
            return View(entityUnit.FlowerPlantations.GetAll());
        }

        public ActionResult CreateFlowerPlantation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateFlowerPlantation(FlowerPlantationModel flowerPlantation)
        {
            if (ModelState.IsValid)
            {
                entityUnit.FlowerPlantations.Create(flowerPlantation);
                entityUnit.Save();
                return RedirectToAction(nameof(GetFlowerPlantationList));
            }
            return View();
        }

        public ActionResult DeleteFlowerPlantation(FlowerPlantationModel flowerPlantation)
        {
            entityUnit.FlowerPlantations.Delete(flowerPlantation);
            entityUnit.Save();
            return RedirectToAction(nameof(GetFlowerPlantationList));
        }

        public ActionResult EditFlowerPlantation(int id)
        {
            return View(entityUnit.FlowerPlantations.GetById(id));
        }

        [HttpPost]
        public ActionResult EditFlowerPlantation(FlowerPlantationModel flowerPlantation)
        {
            if (ModelState.IsValid)
            {
                entityUnit.FlowerPlantations.Update(flowerPlantation);
                entityUnit.Save();
                return RedirectToAction(nameof(GetFlowerPlantationList));
            }
            return View();
        }
    }
}