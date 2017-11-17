using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp_02.Models
{
    public class CartViewModel
    {
        public string SelectedCategory { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
    }
}