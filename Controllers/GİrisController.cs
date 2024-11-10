using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.Services.Description;
using Tatil_Seyahat_Ytb.Models.Entities;

namespace Tatil_Seyahat_Ytb.Controllers
{
    
    public class GİrisController : Controller
    {
        Context context = new Context();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login( Admin admin)
        {
            var value=context.Admins.FirstOrDefault(x=>x.Kullanıcı==admin.Kullanıcı && x.Sifre==admin.Sifre);
            if (value != null)
            {
                FormsAuthentication.SetAuthCookie(value.Kullanıcı,false);
                Session["Kullanıcı"] = value.Kullanıcı.ToString();
                return RedirectToAction("index","Admin");
            }
            else
            {
                return View();
            }
            
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login","Gİris");
        }
    }
}