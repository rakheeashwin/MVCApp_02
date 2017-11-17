using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using MVCApp_02.Models;
using System.Web.Routing;

namespace MVCApp_02.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        StandardKernel kernel;
        public NinjectControllerFactory()
        {
            kernel = new StandardKernel();
            AddBindings();
        }
        private void AddBindings()
        {
            //    kernel.Bind<IRepository<Product, int>>().To<ProductRepository>();
            kernel.Bind<IRepository<Product, int>>().To<EFProductRepository>();
            kernel.Bind<IRepository<Category, int>>().To<CategoryRepository>();
            kernel.Bind<IAuthProvider>().To<FormsAuthenticationProvider>();
        }
    
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return (controllerType == null) ? null : (IController)kernel.Get(controllerType);
             
            //    base.GetControllerInstance(requestContext, controllerType);
        }
    }
}