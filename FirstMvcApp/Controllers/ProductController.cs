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

    public class ActionLengthAttribute : ActionNameSelectorAttribute
    {
        private readonly int _length;
        public ActionLengthAttribute(int length)
        {
            _length = length;
        }
        public override bool IsValidName(ControllerContext controllerContext, string actionName, MethodInfo methodInfo)
        {
            return actionName.Length <= _length;
        }
    }
    public class ProductController : Controller
    {   [HttpGet]
        public ViewResult Index()
        {
            return View();
        }
        [ActionLength(5)]
        //[ActionName("Index")]
        public ActionResult Test()
        {
            return View("Test");
        }
        // GET: Json
        [AjaxMethod]
        [ActionLength(10)]
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