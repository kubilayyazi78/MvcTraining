using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

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
       // [HandleError]
        public ActionResult Update()
        {

            var i = 0;
            var d = 100 / i;

            return View();
        }
        [OutputCache(Duration =10,Location =OutputCacheLocation.Client )]
        public ActionResult Cache()
        {
            return View();
        }
        [OutputCache(CacheProfile ="CacheProfile")]
        //[OutputCache(Duration =360,VaryByParam ="id;name")]
        public ActionResult Cache2(int id, string name)
        {
            return View();
        }
    }
}