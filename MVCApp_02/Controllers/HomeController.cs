using MVCApp_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApp_02.Infrastructure;

namespace MVCApp_02.Controllers
{
    public class HomeController : Controller
    {

        IRepository<Model1, int> repository;
        public HomeController()
        {
            repository = new TestModelRepository();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }
        [Route("ConnectToUs")] /* url will be http://localhost:59462/connecttous */
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public JsonResult ExampleAction()
        {
            // return "Welcome to ASP.Net MVC Environment.";
            return GetJson();
        }

        public JsonResult GetJson()
        {
            var obj = new { ID = 123, Name = "CGI" };
            return Json(obj, JsonRequestBehavior.AllowGet);
        }
       /* public ActionResult ModelV()
        {
             var model = new Model1 { Id = 1234, Name = "Rakhee" };
          //  var model = new { Id = 1234, Name = "Ashwin" };
            return View(model);
        }*/

        public ActionResult ModelV(int id=0)
        {
            var model = repository.GetDetails(id);
            return View(model);
        }
    }
}