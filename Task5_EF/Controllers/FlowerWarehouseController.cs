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
            
            SupplyContext supply = new SupplyContext();
            SelectList books =new SelectList( supply.Flowers
                .ToList()
           , "Id", "Id");
var res = supply.FlowerWarehouses.Include(x => x.FlowerModel)
                .Include(x => x.WarehouseModel).ToList();
            SelectList book1 = new SelectList(supply.FlowerWarehouses.Include(x => x.FlowerModel)
               .Include(x => x.WarehouseModel).ToList()
          , "WarehouseModel", "WarehouseModel.Id");

            ViewBag.Books = new SelectList(supply.Flowers,"Id","Id");
            ViewBag.Books1 = new SelectList(supply.Places, "Id", "Id");
            
          
            return View();
        }

        [HttpPost]
        public ActionResult CreateFlowerWarehouse(FlowerWarehouseModel flowerWarehouse)
        {
            if (ModelState.IsValid)
            {
                entityUnit.FlowerWarehouses.Create(flowerWarehouse);
                entityUnit.Save();
                return RedirectToAction("GetFlowerWarehouseList");
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
            entityUnit.FlowerWarehouses.Update(flowerWarehouse);
            entityUnit.Save();
            return RedirectToAction("GetFlowerWarehouseList");
        }

        public ActionResult DeleteFlowerWarehouse(FlowerWarehouseModel flowerWarehouse)
        {
            entityUnit.FlowerWarehouses.Delete(flowerWarehouse);
            entityUnit.Save();
            return RedirectToAction("GetFlowerWarehouseList");
        }
    }
}