using System.Web.Mvc;
using Task5_EF.Interfaces;
using Task5_EF.Models;

namespace Task5_EF.Controllers
{
    public class WarehouseController : Controller
    {
        IUnitOfWork entityUnit;

        public WarehouseController(IUnitOfWork unitOfWork)
        {
            entityUnit = unitOfWork;
        }

        public ActionResult GetWarehouseList()
        {
            return View(entityUnit.Warehouses.GetAll());
        }

        public ActionResult CreateWarehouse()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateWarehouse(WarehouseModel warehouse)
        {
            if (ModelState.IsValid)
            {
                entityUnit.Warehouses.Create(warehouse);
                entityUnit.Save();
                return RedirectToAction(nameof(GetWarehouseList));
            }
            return View();
        }

        public ActionResult EditWarehouse(int id)
        {
            return View(entityUnit.Warehouses.GetById(id));
        }

        [HttpPost]
        public ActionResult EditWarehouse(WarehouseModel warehouse)
        {
                entityUnit.Warehouses.Update(warehouse);
                entityUnit.Save();
                return RedirectToAction(nameof(GetWarehouseList));

        }

        public ActionResult DeleteWarehouse(WarehouseModel warehouse)
        {
            entityUnit.Warehouses.Delete(warehouse);
            entityUnit.Save();
            return RedirectToAction(nameof(GetWarehouseList));
        }
    }
}