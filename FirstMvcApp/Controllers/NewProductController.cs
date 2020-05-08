using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMvcApp.Controllers
{
    public class NewProductController : Controller
    {
        // GET: NewProduct
        public ActionResult Index()
        {

            ViewData["message"] = "Message from viewData";

            ViewBag.MessageV = "message from viebag";

            ViewBag.Numbers = new [] {1,2,3,4 };

            TempData["message"] = "message from tempdata";

            return RedirectToAction("Index2");
                //return View();
        }

        public ActionResult Index2()
        {
            return View();
        }
    }
}