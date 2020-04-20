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
            //var query =
            //   from post in database.Posts
            //   join meta in database.Post_Metas on post.ID equals meta.Post_ID
            //   where post.ID == id
            //   select new { Post = post, Meta = meta };

          //  return (from p in Context.Set<Product>()
          //          where p.CategoryID == categoryID
          //          select new { Name = p.Name }).ToList()
          //.Select(x => new Product { Name = x.Name });

           var res = (from flware in supply.FlowerWarehouses
                        join fl in supply.Flowers
                        on flware.FlowerId equals fl.Id
                      
                         select new { name = flware.FlowerModel}).ToList()
                         .Select(x=>new FlowerWarehouseModel { FlowerModel = x.name });  
                           


            return View(res); ;
        }
    }
}