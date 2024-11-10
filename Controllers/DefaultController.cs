using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Tatil_Seyahat_Ytb.Models.Entities;


namespace Tatil_Seyahat_Ytb.Controllers
{
    
    public class DefaultController : Controller
    {
        Context context=new Context();
        public ActionResult Index()
        {
            var value = context.Blogs.Take(4).ToList();
            return View(value);
        }
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            var values=context.Blogs.OrderByDescending(x=>x.Id).Take(3).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial2()
        {
            var values = context.Blogs.OrderByDescending(x => x.Id).Take(10).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial3()
        {
            var values = context.Blogs.OrderByDescending(x => x.Id).Take(3).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial4()
        {
            var values = context.Blogs.OrderByDescending(x => x.Id).Take(6).ToList();
            return PartialView(values);
        }
    }
}