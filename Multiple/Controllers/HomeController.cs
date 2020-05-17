using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Multiple.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Delete(List<int> ids)
        {
            //using ile veri tabanı bağlantısı new leyerek nort

            //using (var context = new NorthwindContext()) { 

            foreach (var id in ids)
            {
                //var product =context.products.find(id)
                //context.products.remove(product)
                //context.savechanges();
            }
            //}
            return RedirectToAction("Index");
        }

        
    }
}