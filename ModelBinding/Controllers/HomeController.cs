using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelBinding.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var categoryId = RouteData.Values["categoryId"];
            var name = RouteData.Values["name"];


            return Content(string.Format("Controller : {0} -  Action {1}",controller,action));
        }
    }
}