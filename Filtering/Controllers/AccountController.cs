using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filtering.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
        public ActionResult Login()
        {
            var model = "Belhanda";

            return Content(string.Format("<b>Welcome {0}", model));
        }
        [Authorize(Users ="kubi")]
        [Authorize(Roles ="Admin")]
        public ActionResult Insert()
        {
            return View();
        }
    }
}