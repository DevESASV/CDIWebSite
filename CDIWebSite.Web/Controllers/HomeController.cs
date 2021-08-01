using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CDIWebSite.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Videos(int? page) 
        {
            return View();
        }
    }
}