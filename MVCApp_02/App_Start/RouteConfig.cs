using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Routing.Constraints;
using System.Web.Routing;

namespace MVCApp_02
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "CartRoute",
                url: "Shop/do{action}/{pageNo}", //"Shop/List", // can be like {controller}/do{action}-{id} -- Eg: /Home/doEdit-1
                defaults: new { controller = "Home", action = "Index", pageNo = UrlParameter.Optional }
                 //new { pageNo = @"/d+" },
                  //namespaces: new { "MVCApp_02", "MVCApp_03"}
               );

            // use MapPageRoute to open normal webpages of aspx
            routes.MapPageRoute(
                routeName: "AspxPage",
                routeUrl: "WebForm",
                physicalFile: "~/WebForm1.aspx");

            routes.MapRoute(
                name: "Default",
               url: "{controller}/{action}/{id}",//  /{*others}", // others need to be manually read and provide a logic to perform action using routeData
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
   //, constraints:new {
   //     controller = "^H.*",
   //     id= new RangeRouteConstraint(0,100)
   // }
            );

          
      //  constraints: new { controller = "^H.*" } - controller need to be having a name starting with H and anything after that
        }
    }
}
