using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelDbProject.Models.Classes;

namespace TravelDbProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context context = new Context();
        public ActionResult Index()
        {
            var degerler = context.Blogs.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult NewBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewBlog(Blog p)
        {
            context.Blogs.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogDelete(int id)
        {
            var deger = context.Blogs.Find(id);
            context.Blogs.Remove(deger);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogBring(int id)
        {
            var deger = context.Blogs.Find(id);
            return View("BlogBring", deger);
        }
        public ActionResult BlogUpdate(Blog blog)
        {
            var Blog = context.Blogs.Find(blog.ID);
            Blog.BlogTittle = blog.BlogTittle;
            Blog.BlogDate = blog.BlogDate;
            Blog.BlogDescription = blog.BlogDescription;
            Blog.BlogImage = blog.BlogImage;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CommentList()
        {
            var degerler = context.Commentss.ToList();
            return View(degerler);
        }
        public ActionResult CommentDelete(int id)
        {
            var find = context.Commentss.Find(id);
            context.Commentss.Remove(find);
            context.SaveChanges();
            return RedirectToAction("CommentList");
        }
        public ActionResult CommentBring(int id=1)
        {
            var deger = context.Commentss.Find(id);
            return View("CommentBring",deger);
        }
        public ActionResult CommentUpdate(Comments c)
        {
            var comment = context.Commentss.Find(c.ID);
            comment.UserName = c.UserName;
            comment.Mail = c.Mail;
            comment.Comment = c.Comment;
            comment.Blog.BlogTittle = c.Blog.BlogTittle;
            context.SaveChanges();
            return RedirectToAction("CommentBring");
        }
    }
}