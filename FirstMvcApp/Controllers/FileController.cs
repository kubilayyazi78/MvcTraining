using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMvcApp.Controllers
{
    public class FileController : Controller
    {
        public FileResult Index()
        {
            return File("dizin", "application/msword");

         //   return File("dizin", "application/msword", "dosyaadi.doc");
         
         //   return File("dizin", "text/plain");

           // return File("dizin", "text/plain", "goliq.txt");

            //return new FilePathResult("dizin", "text/plain")
           // {
             //   FileDownloadName = "dosyaadi"
            //};
        }

        public FileContentResult Index2()
        {
            byte[] bytes = System.IO.File.ReadAllBytes(Server.MapPath("dizin"));

            return File(bytes, "text/plain", "dosyaadi");
        }

        public ActionResult Index3()
        {
            var fileStream = new FileStream(Server.MapPath("dizin"), FileMode.Open);
            return File(fileStream, "dosyaadi");
        }
    }
}