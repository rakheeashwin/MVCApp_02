using MVCApp_02.Infrastructure;
using MVCApp_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp_02.Controllers
{
    public class ProductsController : Controller
    {
        IRepository<Product, int> _repository;

        public ProductsController(IRepository<Product, int> repos)
        {
            //_repository = new ProductRepository();
            _repository = repos;
        }
        // GET: Products
        public ActionResult Index()
        {
            var model = _repository.GetAll();
            return View(model);
        }

        public ActionResult Update(int id)
        {
            var model = _repository.GetDetails(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(Product item)
        {
            try
            {
                _repository.Update(item);

                return this.RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View("Error");
            }
        }

        public ActionResult Create(int id=0)
        {

            return View();

        }
        //using Product object passed
        [HttpPost]
        public ActionResult Create(Product item)
        {
            try
            {
                if (ModelState.IsValid)  // Validate the form model data in Model level 
                {
                    _repository.Create(item);
                    return this.RedirectToAction("Index");
                }
                else
                    return View();
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View("Error");
            }
        }
        //using Request variables
        //[HttpPost]
        //public ActionResult Create()
        //{
        //    try
        //    {
        //        var item = new Product();
        //        item.ProductName = Request.Form["ProductName"];
        //        item.UnitPrice = Convert.ToInt32(Request.Form["UnitPrice"]);
        //        item.UnitsInStock = Convert.ToInt16(Request.Form["UnitsInStock"]);
        //        item.Discontinued = Convert.ToBoolean(Request.Form["Discontinued"]);
        //        _repository.Create(item);
        //        return RedirectToAction("Index");
        //    }
        //    catch(Exception ex)
        //    {
        //        ViewBag.Message = ex.Message;
        //        return View("Error");
        //    }
        //}
        //create with FormCollection
        //[HttpPost]
        //public ActionResult Create(FormCollection coll)
        //{
        //    try
        //    {
        //        var item = new Product();
        //        var name = coll["ProductName"];
        //        if (string.IsNullOrEmpty(name)) // Validation for empty Product name - validations will be moved to Model itself
        //        {
        //            ModelState.AddModelError("ProductName", "Product name is required.");
        //            return View();
        //        }
        //        else
        //            ModelState.AddModelError("ProductName", "");

        //        item.ProductName = coll["ProductName"];
        //        item.UnitPrice = Convert.ToInt32(coll["UnitPrice"]);
        //        item.UnitsInStock = Convert.ToInt16(coll["UnitsInStock"]);
        //        item.Discontinued = Convert.ToBoolean(coll["Discontinued"]);
        //        _repository.Create(item);
        //        return RedirectToAction("Index");
        //    }
        //    catch (Exception ex)
        //    {
        //        ViewBag.Message = ex.Message;
        //        return View("Error");
        //    }
        //}
        public ActionResult Details(int id = 0)
        {
            var model = _repository.GetDetails(id);
            return View(model);
        }
        public ActionResult Delete(int id = 0)
        {
            try
            {
               var model= _repository.GetDetails(id);
                //                return this.RedirectToAction("Index");
                return View(model);

            }
            catch (Exception ex)
            {
                return View("Error");
            }
        }

        [HttpPost]
        public ActionResult Delete(string id = "0")
        {
            try
            {
                _repository.Delete(Convert.ToInt32(id));
                return this.RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                return View("Error");
            }
        }
    }
}