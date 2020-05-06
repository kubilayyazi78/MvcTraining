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
    }
}