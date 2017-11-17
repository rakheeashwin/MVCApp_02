using MVCApp_02.Infrastructure;
using MVCApp_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp_02.Controllers
{
    public class CartController :Controller
    {
        IRepository<Category, int> _categories;
        IRepository<Product, int> _products;
        CartViewModel viewModel;

        public CartController(
            IRepository<Category,int> categories, 
            IRepository<Product,int> prods)
        {
            _categories = categories;
            _products = prods;
            viewModel = new CartViewModel();
        }

        public ActionResult Index(string selectedCategory)
        {
            viewModel = new CartViewModel
            {
                SelectedCategory = selectedCategory,
                Categories = _categories.GetAll(),
                Products = _products.GetAll().Where(c => c.CategoryId == Convert.ToInt32(selectedCategory)).ToList()

            };
            return View(viewModel);
        }
      
        public ActionResult GetProducts(string selectedCategory = "0")
        {
            var prods = _products.GetAll();

            var Products = prods.Where(c => c.CategoryId == Convert.ToInt32(selectedCategory)).ToList();
            return Json(Products.ToList(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult ProductCategory(string selectedCategory="0")
        {
            var prods = _products.GetAll();
            return PartialView(prods);
        }
    }
}