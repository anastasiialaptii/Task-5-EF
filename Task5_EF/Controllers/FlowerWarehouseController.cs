using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task5_EF.Models;
using System.Data.Entity;
using Task5_EF.Interfaces;

namespace Task5_EF.Controllers
{
    public class FlowerWarehouseController : Controller
    {
        IUnitOfWork entityUnit;

        public FlowerWarehouseController(IUnitOfWork unitOfWork)
        {
            entityUnit = unitOfWork;
        }
        public ActionResult GetFlowerWarehouseList()
        {
            return View(entityUnit.FlowerWarehouses.GetAll()); ;
        }


        public ActionResult CreateFlowerWarehouse()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateFlowerWarehouse(FlowerWarehouseModel flowerWarehouse)
        {
            if (ModelState.IsValid)
            {
                entityUnit.FlowerWarehouses.Create(flowerWarehouse);
                entityUnit.Save();
                return RedirectToAction(nameof(GetFlowerWarehouseList));
            }
            return View();
        }

        public ActionResult EditFlowerWarehouse(int id)
        {
            return View(entityUnit.FlowerWarehouses.GetById(id));
        }

        [HttpPost]
        public ActionResult EditFlowerWarehouse(FlowerWarehouseModel flowerWarehouse)
        {
            if (ModelState.IsValid)
            {
                entityUnit.FlowerWarehouses.Update(flowerWarehouse);
                entityUnit.Save();
                return RedirectToAction(nameof(GetFlowerWarehouseList));
            }
            return View();
        }

        public ActionResult DeleteFlowerWarehouse(FlowerWarehouseModel flowerWarehouse)
        {
            entityUnit.FlowerWarehouses.Delete(flowerWarehouse);
            entityUnit.Save();
            return RedirectToAction(nameof(GetFlowerWarehouseList));
        }
    }
}