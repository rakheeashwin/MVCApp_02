using MVCApp_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp_02.Infrastructure
{
    public class EFProductRepository : IRepository<Product, int>
    {
        NorthwindContext nw;

        public EFProductRepository()
        {
            nw = new NorthwindContext();
        }
        public void Create(Product item)
        {
            if ((nw.Products.FirstOrDefault(c => c.ProductName ==item.ProductName)) == null)
            {
                nw.Products.Add(item);
                nw.SaveChanges();
            }
            else
                throw new ArgumentException("Requesed item already exists");

           
        }

        public void Delete(int id)
        {
            // nw.Products.Remove(nw.Products.FirstOrDefault(c => c.ProductId == id));
            var prod = nw.Products.Find(id);
            if (prod != null)
            {
                nw.Products.Remove(prod);
                nw.SaveChanges();
            }
            else
                throw new ArgumentNullException("Requested item not found");
            //nw.SaveChanges();
        }

        public List<Product> GetAll()
        {
           
            return nw.Products.ToList();
        }

        public Product GetDetails(int id)
        {
            return nw.Products.FirstOrDefault(c => c.ProductId == id);
        }

      
        public void Update(Product item)
        {
            foreach (Product temp in nw.Products)
            {
                if (temp.ProductId == item.ProductId)
                {
                    temp.ProductName = item.ProductName;
                    temp.Discontinued = item.Discontinued;
                    temp.UnitPrice = item.UnitPrice;
                    temp.UnitsInStock = item.UnitsInStock;
                    break;
                }

            }
            /*      can be done this way also
             *            var temp = nw.Products.Find(item.ProductId);
                        if (temp.ProductId == item.ProductId)
                        {
                            temp.ProductName = item.ProductName;
                                temp.Discontinued = item.Discontinued;
                                temp.UnitPrice = item.UnitPrice;
                                temp.UnitsInStock = item.UnitsInStock;
                            //nw.Entry(temp).State = System.Data.Entity.EntityState.Modified;

                        }
                        else
                throw new ArgumentNullException("Requesed item doesnot exists");
*/
            nw.SaveChanges();

        }
    }
}