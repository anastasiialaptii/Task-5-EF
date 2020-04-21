using System.Web.Mvc;
using Task5_EF.Interfaces;
using Task5_EF.Models;

namespace Task5_EF.Controllers
{
    public class PlantationController : Controller
    {
        private IUnitOfWork entityUnit;

        public PlantationController(IUnitOfWork unitOfWork)
        {
            entityUnit = unitOfWork;
        }

        public ActionResult CreatePlantation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreatePlantation(PlantationModel plantation)
        {
            if (ModelState.IsValid)
            {
                entityUnit.Plantations.Create(plantation);
                entityUnit.Save();
                return RedirectToAction(nameof(GetPlantationList));
            }
            return View();
        }

        public ActionResult GetPlantationList()
        {
            return View(entityUnit.Plantations.GetAll());
        }

        public ActionResult DeletePlantation(PlantationModel plantation)
        {
            entityUnit.Plantations.Delete(plantation);
            entityUnit.Save();
            return RedirectToAction(nameof(GetPlantationList));
        }

        public ActionResult EditPlantation(int id)
        {
            return View(entityUnit.Plantations.GetById(id));
        }

        [HttpPost]
        public ActionResult EditPlantation(PlantationModel plantation)
        {
            if (ModelState.IsValid)
            {
                entityUnit.Plantations.Update(plantation);
                entityUnit.Save();
                return RedirectToAction(nameof(GetPlantationList));
            }
            return View();
        }
    }
}