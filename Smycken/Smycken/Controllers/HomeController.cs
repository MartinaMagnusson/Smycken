using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL.HelperClasses;
using DAL.Repository;
using System.Threading.Tasks;

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
    }
}