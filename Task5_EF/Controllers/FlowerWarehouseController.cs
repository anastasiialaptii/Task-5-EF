using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task5_EF.Models;

namespace Task5_EF.Controllers
{
    public class FlowerWarehouseController : Controller
    {
        // GET: FlowerWarehouse
        public ActionResult GetFlowerWarehouseList()
        {
            SupplyContext supply = new SupplyContext();


           var res = supply.FlowerWarehouses.ToList();

            return View(res); ;
        }
    }
}