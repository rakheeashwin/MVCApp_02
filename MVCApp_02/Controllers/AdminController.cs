﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp_02.Controllers
{
    [Authorize]
    public class AdminController :Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}