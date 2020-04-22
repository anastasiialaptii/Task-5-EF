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

        [HttpGet]
        public ActionResult CreateFlowerWarehouse()
        {
            SupplyContext supplyContext = new SupplyContext();
            List<SelectListItem> list = new List<SelectListItem>();
            foreach (var item in supplyContext.Flowers)
            {
                SelectListItem select = new SelectListItem()
                {
                    Value = item.Id.ToString(),
                    Text = item.Name

                };
                list.Add(select);
            }
                ViewModel model = new ViewModel();
                model.Flowers = list;      

                return View(list);
            
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