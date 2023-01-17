﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BanHangOnl.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        [Authorize(Roles = "Admin,Employee")]
        public ActionResult Index()
        {
            return View();
        }
    }
}