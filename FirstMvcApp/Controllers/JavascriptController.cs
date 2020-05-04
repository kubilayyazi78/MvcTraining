﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMvcApp.Controllers
{
    public class JavascriptController : Controller
    {
        // GET: Javascript
        public ActionResult Index()
        {
            return View();
        }
        public JavaScriptResult Alert()
        {
            return JavaScript("alert('belhanda')");
        }
    }
}