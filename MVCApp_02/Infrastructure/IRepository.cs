using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCApp_02.Infrastructure
{
    public interface IRepository<TModel, TIdentity>
    {
        List<TModel> GetAll();
        TModel GetDetails(TIdentity id);
        void Create(TModel item);
        void Update(TModel item);
        void Delete(TIdentity id);
            
    }
}
