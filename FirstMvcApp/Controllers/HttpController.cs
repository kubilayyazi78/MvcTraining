 using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace FirstMvcApp.Controllers
{
    public class HttpController : Controller
    {
        // GET: Http
        public HttpStatusCodeResult Index()
        {
         //  return new HttpStatusCodeResult(HttpStatusCode.BadGateway);

        //   return new HttpStatusCodeResult(HttpStatusCode.BadGateway, "Bad gateway from mvc");

          return new HttpStatusCodeResult(502);
        }

        public HttpUnauthorizedResult Index2()
        {
            //return new HttpUnauthorizedResult();

            return new HttpUnauthorizedResult("not authenticate");
        }

        public HttpNotFoundResult Index3()
        {
            return HttpNotFound();

            //return HttpNotFound("Sorrt this page not found");

            //return new HttpNotFoundResult();
        }
    }
}