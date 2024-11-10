using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tatil_Seyahat_Ytb.Models.Entities;
using Tatil_Seyahat_Ytb.Controllers;
using PagedList;
using PagedList.Mvc;

namespace Tatil_Seyahat_Ytb.Controllers
{
    public class AdminController : Controller
    {
       Context context=new Context();
        [Authorize]
        public ActionResult Index(int sayfa=1)
        {
            var values=context.Blogs.ToList().ToPagedList(sayfa, 5);
            return View(values);
        }
        public ActionResult AddBlog()
        {

            return View();
        }
        [HttpPost]
        public ActionResult AddBlog( Blog blog)
        {
            context.Blogs.Add(blog);
            context.SaveChanges();
            return  RedirectToAction("Index");
        }
        public ActionResult UpdateBlog(int id)
        {
            var value = context.Blogs.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateBlog(Blog blog)
        {
            var values=context.Blogs.Find(blog.Id);
            values.Tarih=blog.Tarih;
            values.Acıklama = blog.Acıklama;
            values.Baslık = blog.Baslık;
            values.BlogImage= blog.BlogImage;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteBlog(int id)
        {
            var values = context.Blogs.Find(id);
            context.Blogs.Remove(values);
            return RedirectToAction("Index");
        }
    }
}