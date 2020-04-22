using System.Web.Mvc;
using Task5_EF.Interfaces;
using Task5_EF.Models;

namespace Task5_EF.Controllers
{
    public class StatusController : Controller
    {
        IUnitOfWork entityUnit;
        public StatusController(IUnitOfWork unitOfWork)
        {
            entityUnit = unitOfWork;
        }
        public ActionResult GetStatusList()
        {
            return View(entityUnit.Statuses.GetAll());
        }

        public ActionResult CreateStatus()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateStatus(StatusModel status)
        {
            if (ModelState.IsValid)
            {
                entityUnit.Statuses.Create(status);
                entityUnit.Save();
                return RedirectToAction(nameof(GetStatusList));
            }
            return View();
        }

        public ActionResult DeleteStatus(StatusModel status)
        {
            entityUnit.Statuses.Delete(status);
            entityUnit.Save();
            return RedirectToAction(nameof(GetStatusList));
        }

        public ActionResult EditStatus(int id)
        {
            return View(entityUnit.Statuses.GetById(id));
        }

        [HttpPost]
        public ActionResult EditStatus(StatusModel status)
        {
            if (ModelState.IsValid)
            {
                entityUnit.Statuses.Update(status);
                entityUnit.Save();
                return RedirectToAction(nameof(GetStatusList));
            }
            return View();
        }
    }
}