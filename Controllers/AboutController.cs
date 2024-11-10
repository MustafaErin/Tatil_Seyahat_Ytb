using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tatil_Seyahat_Ytb.Models.Entities;

namespace Tatil_Seyahat_Ytb.Controllers
{
    public class AboutController : Controller
    {
        Context context=new Context();
        public ActionResult Index()
        {
            var values=context.Hakkımızdas.ToList();
            return View(values);
        }
    }
}