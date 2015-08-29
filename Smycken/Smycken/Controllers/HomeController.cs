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
        private SmyckenRepository _smyckeRepo;
        

        public HomeController()
        { 
            _smyckeRepo = new SmyckenRepository();
        }
        public ActionResult Index()
        {
            var image = _smyckeRepo.GetAllNewsImage();

            return View(image);
        }

        public ActionResult Test()
        {
            var contact = _smyckeRepo.GetContactInformation();
            return View(contact);
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