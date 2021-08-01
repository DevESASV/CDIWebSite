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

        public ActionResult VidList(int? page) 
        {
            page = page == null ? 0 : page;
            VidSectionVM model = _VideoSectionServices.ListaVideos((int)page);
            return View(model);
        }
    }
}