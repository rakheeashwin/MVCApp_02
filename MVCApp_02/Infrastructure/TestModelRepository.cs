using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCApp_02.Models;

namespace MVCApp_02.Infrastructure
{
    public class TestModelRepository : IRepository<Model1, int>
    {
        List<Model1> list;


        public TestModelRepository()
        {
            list = new List<Model1>
            {
                new Model1 {Id=0, Name="Test" },
                 new Model1 {Id=1, Name="Test 01" },
                  new Model1 {Id=2, Name="Test 02" },
                   new Model1 {Id=3, Name="Test 03" },
                    new Model1 {Id=4, Name="Test 04" }
            };

        }

        public Model1 GetDetails(int id)
        {
            var detail = list.FirstOrDefault(x => x.Id == id);
            return detail;
        }
        public List<Model1> GetAll()
        {
            return list;
        }



        public void Create(Model1 item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

     

        public void Update(Model1 item)
        {
            throw new NotImplementedException();
        }
    }
}