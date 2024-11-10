using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tatil_Seyahat_Ytb.Models.Entities;
using Tatil_Seyahat_Ytb.Controllers;

namespace Tatil_Seyahat_Ytb.Controllers
{
    public class BlogController : Controller
    {
        Context context=new Context();
        BlogYorum blogYorum = new BlogYorum();
        public ActionResult Index()
        {
            blogYorum.deger1 = context.Blogs.ToList();
            blogYorum.deger3 = context.Blogs.OrderByDescending(x=>x.Id).Take(4).ToList();
            return View(blogYorum);
        }
      
        
        public ActionResult BlogDetay(int id)
        {
          
            blogYorum.deger1 = context.Blogs.Where(x=>x.Id==id).ToList();
            blogYorum.deger3 = context.Blogs.OrderByDescending(x => x.Id).Take(4).ToList();
            blogYorum.deger2 = context.Yorumlars.Where(x=>x.BlogId==id).ToList();
            
            return View(blogYorum);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar yorum)
        {
            context.Yorumlars.Add(yorum);
            context.SaveChanges();
            return PartialView();
        }
        public ActionResult YorumList()
        {
            var values=context.Yorumlars.ToList();
            return View(values);
        }
        public ActionResult YorumSil( int id)
        {
            var values = context.Yorumlars.Find(id);
            context.Yorumlars.Remove(values);
            context.SaveChanges();
            return RedirectToAction("YorumList");
        }

        [HttpGet]
        public ActionResult YorumGüncelle(int id)
        {
            var value = context.Yorumlars.Find(id);
            return PartialView(value);
        }

        [HttpPost]
        public ActionResult YorumGüncelle(Yorumlar y)
        {
            var value=context.Yorumlars.Find(y.Id);
            value.KullanıcıAdı = y.KullanıcıAdı;
            value.Mail=y.Mail;
            value.Yorum=y.Yorum;
            context.SaveChanges();
            return RedirectToAction("YorumList");
        }




    }
}