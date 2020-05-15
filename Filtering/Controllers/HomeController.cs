using Filtering.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filtering.Controllers
{
    public class HomeController : Controller
    {
        [CustomFilter]
        public ActionResult Index()
        {

            Debug.WriteLine("Belhanda");
            return View();
        }
        protected override void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);
        }
    }
    
}