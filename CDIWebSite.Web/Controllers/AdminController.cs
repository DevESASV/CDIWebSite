using CDIWebSite.Web.Services.Calls;
using CDIWebSite.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CDIWebSite.Web.Controllers
{
    public class AdminController : Controller
    {
        public readonly VideoServices _VideoSectionServices = new VideoServices();
        // GET: Admin
        public ActionResult LogIn()
        {
            return View();
        }

        public ActionResult VidList(int? page, string a) 
        {
            ViewBag.Action = a;
            page = page == null ? 0 : page;
            VidSectionVM model = _VideoSectionServices.ListaVideos((int)page);
            return View(model);
        }

        public ActionResult NewVideo()
        {
            List<SelectListItem> LstCategories = _VideoSectionServices.GetCategories();
            ViewBag.CategoryLst = LstCategories;
            return View();
        }

        [HttpPost]
        public ActionResult NewVideo(VidSectionVM model)
        {
            string message = "EL video se agrego con exito!";
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            _VideoSectionServices.AgregarVideo(model);
            return RedirectToAction("VidList", "Admin", new { a = message});
        }
    }
}