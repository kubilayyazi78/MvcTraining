using Microsoft.Security.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Security.Controllers
{
    public class HomeController : Controller
    {
        [ValidateAntiForgeryToken]
        public ActionResult Index()
        {
            return View();
        }
        [ValidateInput(false)]
        public ActionResult Index2(string user)
        {
            //user.about mesela ilgili alan için yapılır.
            user = Sanitizer.GetSafeHtmlFragment(user);

            return View();
        }
    }
}