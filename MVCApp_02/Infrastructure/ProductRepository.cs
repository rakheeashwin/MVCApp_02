using MVCApp_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp_02.Infrastructure
{
    //add using directive to APPLICATION.Models
    public class ProductRepository : IRepository<Product, int>
    {
        List<Product> products;
        public ProductRepository()
        {
            products = new List<Product>
            {
                new Models.Product {ProductId=1,ProductName="Test1", UnitPrice=500.50M, UnitsInStock=10,Discontinued=false },
                new Models.Product {ProductId=2,ProductName="Test2", UnitPrice=5000.50M, UnitsInStock=20,Discontinued=false },
new Models.Product {ProductId=3,ProductName="Test3", UnitPrice=50.50M, UnitsInStock=30,Discontinued=false },
new Models.Product {ProductId=4,ProductName="Test4", UnitPrice=5.50M, UnitsInStock=40,Discontinued=false }

            };
        }
        public void Create(Product item)
        {
            products.Add(item);
        }

        public void Delete(int id)
        {
            var delProduct = products.First(i => i.ProductId == id);
            products.RemoveAt(delProduct.ProductId);
        }

        public List<Product> GetAll()
        {
            return products;
        }

        public Product GetDetails(int id)
        {
            return products.FirstOrDefault(c => c.ProductId == id);
        }

        public void Update(Product item)
        {
            throw new NotImplementedException();
        }
    }
}