using System.Web.Mvc;
using Task5_EF.Interfaces;
using Task5_EF.Models;

namespace Task5_EF.Controllers
{
    public class SupplyController : Controller
    {
        IUnitOfWork entityUnit;
        public SupplyController(IUnitOfWork unitOfWork)
        {
            entityUnit = unitOfWork;
        }
        public ActionResult GetSupplyList()
        {
            return View(entityUnit.Supplies.GetAll());
        }

        public ActionResult CreateSupply()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSupply(SupplyModel supply)
        {
            if (ModelState.IsValid)
            {
                entityUnit.Supplies.Create(supply);
                entityUnit.Save();
                return RedirectToAction(nameof(GetSupplyList));
            }
            return View();
        }

        public ActionResult DeleteSupply(SupplyModel supply)
        {
            entityUnit.Supplies.Delete(supply);
            entityUnit.Save();
            return RedirectToAction(nameof(GetSupplyList));
        }

        public ActionResult EditSupply(int id)
        {
            return View(entityUnit.Supplies.GetById(id));
        }

        [HttpPost]
        public ActionResult EditSupply(SupplyModel supply)
        {
            if (ModelState.IsValid)
            {
                entityUnit.Supplies.Update(supply);
                entityUnit.Save();
                return RedirectToAction(nameof(GetSupplyList));
            }
            return View();
        }
    }
}