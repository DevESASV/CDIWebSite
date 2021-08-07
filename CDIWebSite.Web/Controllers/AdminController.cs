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

        public ActionResult EditVideo (int id)
        {
            VidSectionVM model = _VideoSectionServices.GetVideo(id);
            List<SelectListItem> LstCategories = _VideoSectionServices.GetCategories();
            ViewBag.CategoryLst = LstCategories;
            return View(model);
        }

        [HttpPost]
        public ActionResult EditVideo(VidSectionVM model)
        {
            string message;
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            if (_VideoSectionServices.EditarVideo(model))
            {
                message = "El Video se editó con exito!";
                return RedirectToAction("VidList", "Admin", new { a = message });
            }
            else
            {
                message = "Parece que algo salió mal al editar el video, por favor intentelo nuevamente!";
                return RedirectToAction("VidList", "Admin", new { a = message });
            }
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
            string message;
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            if (_VideoSectionServices.AgregarVideo(model))
            {
                message = "EL video se agrego con exito!";
                return RedirectToAction("VidList", "Admin", new { a = message });
            }
            else
            {
                message = "Parece que algo salio mal, por favor intente nuevamente!";
                return RedirectToAction("VidList", "Admin", new { a = message });
            }
        }
    }
}