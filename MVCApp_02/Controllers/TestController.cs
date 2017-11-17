using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp_02.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult TestView(string id="")
        {
            ViewBag.Id = string.IsNullOrEmpty(id) ? "EMPTY" : id;
            return View();
        }
    }
}