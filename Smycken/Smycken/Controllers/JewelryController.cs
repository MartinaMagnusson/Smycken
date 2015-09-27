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

        public ActionResult ShowAllJewelry()
        {
            var jewelry = _smyckeRepoGet.GetAllJewelry();
            return View(jewelry);
        }

        public ActionResult ShowOneJewelry(int id)
        {
            var jewelry = _smyckeRepoGet.GetOneJewelryById(id);
            return View(jewelry);
        }
        public ActionResult AncleJewelry()
        {
            var ancleJewelry = _smyckeRepoGet.GetAllAncleJewelry();

            return View(ancleJewelry);
        }

        public ActionResult Bracelet()
        {
            var bracelet = _smyckeRepoGet.GetAllBracelet();
            return View(bracelet);
        }
        public ActionResult Earrings()
        {
            var earrings = _smyckeRepoGet.GetAllEarrings();
            return View(earrings);
        }

        public ActionResult Necklace()
        {
            var necklace = _smyckeRepoGet.GetAllNecklace();
            return View(necklace);
        }
    }
}