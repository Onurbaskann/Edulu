﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Edulu3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [Route("Home/Index")]
        public ActionResult Index()
        {
            return View();
        }
    }
}