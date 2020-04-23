using System.Web.Mvc;
using Task5_EF.Interfaces;
using Task5_EF.Models;

namespace Task5_EF.Controllers
{
    public class FlowerSupplyController : Controller
    {
        IUnitOfWork entityUnit;

        public FlowerSupplyController(IUnitOfWork unitOfWork)
        {
            entityUnit = unitOfWork;
        }
        public ActionResult GetFlowerSupplyList()
        {
            return View(entityUnit.FlowerSupplies.GetAll());
        }

        public ActionResult CreateFlowerSupply()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateFlowerSupply(FlowerSupplyModel flowersupply)
        {
            if (ModelState.IsValid)
            {
                entityUnit.FlowerSupplies.Create(flowersupply);
                entityUnit.Save();
                return RedirectToAction(nameof(GetFlowerSupplyList));
            }
            return View();
        }

        public ActionResult DeleteFlowerSupply(FlowerSupplyModel flowersupply)
        {
            entityUnit.FlowerSupplies.Delete(flowersupply);
            entityUnit.Save();
            return RedirectToAction(nameof(GetFlowerSupplyList));
        }

        public ActionResult EditFlowerSupply(int id)
        {
            return View(entityUnit.FlowerSupplies.GetById(id));
        }

        [HttpPost]
        public ActionResult EditFlowerSupply(FlowerSupplyModel flowersupply)
        {
            if (ModelState.IsValid)
            {
                entityUnit.FlowerSupplies.Update(flowersupply);
                entityUnit.Save();
                return RedirectToAction(nameof(GetFlowerSupplyList));
            }
            return View();
        }
    }
}