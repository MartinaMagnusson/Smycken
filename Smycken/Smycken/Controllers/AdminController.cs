using DAL.HelperClasses;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Smycken.Controllers
{
    public class AdminController : Controller
    {
        private SmyckenRepositoryCreate _smyckeRepoCreate;
        private SmyckenRepositoryGet _smyckeRepoGet;
        private SmyckenRepositoryUpdate _smyckeRepoUpdate;
        // GET: Admin
        public AdminController()
        {
            _smyckeRepoCreate = new SmyckenRepositoryCreate();
            _smyckeRepoGet = new SmyckenRepositoryGet();
            _smyckeRepoUpdate = new SmyckenRepositoryUpdate();
        }
        public ActionResult Products()
        {
            var jewelry = _smyckeRepoGet.GetAllJewelry();
            return View(jewelry);
        }
        public ActionResult AddJewelry()
        {
            var jewelry = new AddJewelry();
            return View(jewelry);
        }
        [HttpPost]
        public ActionResult AddJewelry(AddJewelry jewelry)
        //public ActionResult AddJewelry(AddJewelry jewelry, ImageHelper image)
        {
            if (ModelState.IsValid)
            {
                _smyckeRepoCreate.AddJewelry(jewelry);
            }
            return View(jewelry);
        }

        //public ActionResult EditJewelry()
        //{
           
        //    return View();
        //}
        public ActionResult EditJewelry(int id)
        {
            var jewelry = _smyckeRepoGet.GetJewelryById(id);
            return View(jewelry);
        }

        [HttpPost]
        public ActionResult EditJewelry(EditJewelry jewelry)
        {
            _smyckeRepoUpdate.UpdateJewelry(jewelry);
            return RedirectToAction("Products", "Admin");
        }

        public ActionResult RemoveJewelry(int jewelry)
        {
            _smyckeRepoUpdate.RemoveJewelry(jewelry);
            return RedirectToAction("Products", "Admin");
        }
    }
}