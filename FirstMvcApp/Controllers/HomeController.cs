﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMvcApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "Başlangıc";
        }

        public string Merhaba()
        {
            return "Sonuc";
        }

        public ActionResult IndexView()
        {
            return View();
        }
    }
}