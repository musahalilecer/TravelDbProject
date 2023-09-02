using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelDbProject.Models.Classes;

namespace TravelDbProject.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context context = new Context();
        BlogComment blogcomment = new BlogComment();
        public ActionResult Blog()
        {
            //var blogs = c.Blogs.ToList();
            blogcomment.Value1 = context.Blogs.ToList();
            blogcomment.Value3 = context.Blogs.Take(3).ToList();

            return View(blogcomment);
        }
        Blog blog = new Blog();
        public ActionResult BlogDetails(int id)
        {
        //    var findblog = c.Blogs.Where(x => x.ID == id).ToList();
            blogcomment.Value1 = context.Blogs.Where(x=>x.ID == id).ToList();
            blogcomment.Value2 = context.Commentss.Where(x=>x.BlogId == id).ToList();
            return View(blogcomment);
        }
        //[HttpGet]
        //public PartialViewResult()
        //{
        //    return PartialView();
        //}
        [HttpGet]
        public PartialViewResult AddComment(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult AddComment(Comments comments)
        {
            context.Commentss.Add(comments);
            context.SaveChanges();
            return PartialView();
        }
    }
}