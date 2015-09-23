using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL.HelperClasses;
using DAL.Repository;

namespace Smycken.Controllers
{
    public class HomeController : Controller
    {
        private SmyckenRepositoryGet _smyckeRepoGet;
        

        public HomeController()
        {
            _smyckeRepoGet = new SmyckenRepositoryGet();
        }
        public ActionResult Index()
        {
            var image = _smyckeRepoGet.GetAllNewsImage();

            return View(image);
        }


        [ChildActionOnly]
        public ActionResult Carousel()
        {
            return PartialView();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}