using DAL.HelperClasses;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Smycken.Controllers
{
    public class AdminController : Controller
    {
        private const string picturePath = "/Images/";
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
        public ActionResult AddJewelry(HttpPostedFileBase file, AddJewelry jewelry)
        {
            if (file != null)
            {
                string subPath = picturePath + jewelry.Name.Replace(" ", "_");
                //jewelry.PictureFileName = DateTime.Now.ToString("yyyyMMdd-Hmmss") + "_" + file.FileName;
                jewelry.PictureFileName = file.FileName;
                jewelry.PictureURL = subPath + "/";
                if (ModelState.IsValid)
                {
                    bool exists = Directory.Exists(Server.MapPath(subPath));

                    if (!exists)
                        Directory.CreateDirectory(Server.MapPath(subPath));

                    if (file != null && file.ContentLength > 0)
                        try
                        {
                            string path =
                                Path.Combine(Server.MapPath("/Images/" + jewelry.Name.Replace(" ", "_") + "/"),
                                    Path.GetFileName(jewelry.PictureFileName));
                            file.SaveAs(path);
                            ViewBag.Message = "File uploaded successfully";
                            _smyckeRepoCreate.AddJewelry(jewelry);
                            //return RedirectToAction("ShowSelectedBlog", "Horse", new { horseId = blogPost.HorseId });
                        }
                        catch (Exception ex)
                        {
                            ViewBag.Message = "ERROR:" + ex.Message.ToString();
                        }
                }
            }
            else
            {
                if (ModelState.IsValid)
                {
                    _smyckeRepoCreate.AddJewelry(jewelry);
                    //return RedirectToAction("ShowSelectedBlog", "Horse", new { horseId = jewelry.HorseId });


                }
            }
            return View(jewelry);
        }


        //[HttpPost]
        //public ActionResult AddJewelry(HttpPostedFileBase file, AddJewelry jewelry)
        ////public ActionResult AddJewelry(AddJewelry jewelry, ImageHelper image)
        //{
        //    if(file != null)
        //    {
        //        string subPath = picturePath + jewelry.Name.Replace(" ", "-");
        //        jewelry.PictureFileName = DateTime.Now.ToString("yyyyMMdd-Hmmss") + "_" + file.FileName;
        //        jewelry.PictureFileName = subPath + "/";
        //        if (ModelState.IsValid)
        //        {
        //            bool exists = Directory.Exists(Server.MapPath(subPath));
        //            if (!exists)
        //                Directory.CreateDirectory(Server.MapPath(subPath));
        //            if(file !=null && file.ContentLength > 0)
        //            {
        //                try
        //                {
        //                    string path =
        //                      Path.Combine(Server.MapPath("/Images/" + jewelry.Name.Replace(" ", "_") + "/"),
        //                          Path.GetFileName(jewelry.PictureFileName));
        //                    file.SaveAs(path);
        //                    ViewBag.Message = "File uploaded successfully";
        //                    _smyckeRepoCreate.AddJewelry(jewelry);
        //                    return View(jewelry);
        //                }
        //                catch (Exception ex)
        //                {
        //                    ViewBag.Message = "ERROR:" + ex.Message.ToString();
        //                }
        //            }
        //        }
        //    }
        //    else
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            _smyckeRepoCreate.AddJewelry(jewelry);
        //        }
        //    } 
        //    return View(jewelry);
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

        public ActionResult RemoveJewelry(int id)
        {
            _smyckeRepoUpdate.RemoveJewelry(id);
            return RedirectToAction("Products", "Admin");
        }
    }
}