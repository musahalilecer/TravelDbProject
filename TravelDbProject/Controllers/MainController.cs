using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelDbProject.Models.Classes;

namespace TravelDbProject.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        Context context = new Context();
        public ActionResult Index()
        {
            var degerler = context.Blogs.ToList();
            return View(degerler);
        }
        public PartialViewResult Partial1()
        {
            var degerler = context.Blogs.OrderByDescending(x=>x.ID).Take(2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial2()
        {
            var deger = context.Blogs.Where(x=>x.ID == 1).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial3()
        {
            var degerler = context.Blogs.Take(10).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial4()
        {
            var degerler = context.Blogs.Take(5).ToList();
            return PartialView(degerler);
        }
    }
}