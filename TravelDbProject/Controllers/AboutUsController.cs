using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelDbProject.Models.Classes;

namespace TravelDbProject.Controllers
{
    public class AboutUsController : Controller
    {
        // GET: AboutUs
        Context c = new Context();
        public ActionResult AboutUs()
        {
            var degerler = c.AboutUss.ToList();
            return View(degerler);
        }
    }
}