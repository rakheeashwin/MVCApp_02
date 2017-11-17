using MVCApp_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp_02.Infrastructure
{
    public class CategoryRepository : IRepository<Category, int>
    {
        NorthwindContext db;
        public CategoryRepository()
        {
            db = new NorthwindContext();
        }
        public void Create(Category item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public Category GetDetails(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Category item)
        {
            throw new NotImplementedException();
        }
    }
}