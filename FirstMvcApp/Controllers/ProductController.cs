using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace FirstMvcApp.Controllers
{
    public class Category
    {
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
    }
    public class AjaxMethodAttribute : ActionMethodSelectorAttribute
    {
        public override bool IsValidForRequest(ControllerContext controllerContext, MethodInfo methodInfo)
        {
            return controllerContext.HttpContext.Request.IsAjaxRequest();
        } 
    }
    public class ProductController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        // GET: Json
        [AjaxMethod]
        public JsonResult GetAll()
        {
            var products = new List<Category>
            {
                new Category
                {
                     ProductName="Laptop",
                      UnitPrice=700,
                },
                new Category
                {
                    ProductName="Mouse",
                     UnitPrice=5
                }
            };
            return Json(products, JsonRequestBehavior.AllowGet);
        }
    }
}