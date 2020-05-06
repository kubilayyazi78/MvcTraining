using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMvcApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "Başlangıc";
        }
        [NonAction]
        public string Merhaba()
        {
            return "Sonuc";
        }
        [ActionName("IndexDemo")]
        public ActionResult IndexView()
        {
            return View("Index");
        }
        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult IndexView2()
        {
            return View("Index");
        }

       // [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        [HttpPost]
        [AcceptVerbs("Get","Post")]
        public ActionResult IndexView3()
        {
            return View("Index");
        }
    }
}