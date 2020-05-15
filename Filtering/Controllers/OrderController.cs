using Filtering.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filtering.Controllers
{
    [AuthorizationFilterB("Controller",Order =2)]
    public class OrderController : Controller
    {
        [AuthorizationFilterA("Action",Order =1)]
        public ActionResult Index()
        {
            Debug.WriteLine("Belhanda");
            return View();
        }
    }
}