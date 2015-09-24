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
        // GET: Admin
        public AdminController()
        {
            _smyckeRepoCreate = new SmyckenRepositoryCreate();
            _smyckeRepoGet = new SmyckenRepositoryGet();
        }
        public ActionResult Index()
        {
            return View();
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

    }
}