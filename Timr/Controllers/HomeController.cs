﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccessLayer;

namespace Timr.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            TestDAL dal = new TestDAL();
            dal.a();
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}