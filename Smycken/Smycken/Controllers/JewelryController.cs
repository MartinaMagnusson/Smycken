using DAL.HelperClasses;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Smycken.Controllers
{
    public class JewelryController : Controller
    {
        private SmyckenRepositoryGet _smyckeRepoGet;


        public JewelryController()
        {
            _smyckeRepoGet = new SmyckenRepositoryGet();
        }
        public ActionResult AncleJewelry()
        {
            var ancleJewelry = _smyckeRepoGet.GetAllAncleJewelry();

            return View(ancleJewelry);
        }
        public ActionResult AddAncleJewelry()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAncleJewelry(AncleJewelryHelper ancleJewelry)
        {
            return View();
        }

    }
}