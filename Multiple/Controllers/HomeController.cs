using Multiple.Selectors;
using System;
using System.Collections.Generic;
using System.IO;
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
        [MultipleAction]
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
        [MultipleAction]
        public ActionResult Export(List<int> ids)
        {
            // List<Product> products

            //  using (var context new Nortwind()){

            //   products=context.Products
            //     .where(t=>ids.Contains(t.product.id))
            //   .tolist()




            //            }
            return Json(ids, JsonRequestBehavior.AllowGet);//ids yerine products
        }

        public ActionResult Insert(int product , HttpPostedFile file)
        {
            if (file!=null && file.ContentLength>0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/contenct/files"), fileName);

                file.SaveAs(path);
            }
            return View();
        }

        
    }
}