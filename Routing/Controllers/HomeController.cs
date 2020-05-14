using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Routing.Controllers
{   [RoutePrefix("Main")]
    public class HomeController : Controller
    {
        // GET: Home 
        [Route("~/Index:alpha")]
        public ActionResult Index()
        {
            return View();
        }
        [Route("about",Name ="About",Order =1)]
        public ActionResult About()
        {
            return View();
        }
        [Route("~/demo/{number=1}/{id?}")]
        public ActionResult Deme(int number,int? id)
        {
            return Content(string.Format("Number {0} <br/> Id={1}", number,id.HasValue ? id.ToString(): "null"));
        }

    }
}