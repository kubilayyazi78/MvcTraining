using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Routing
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.Add(new Route("{resource}.axd/{*pathInfo}", new StopRoutingHandler()));
            routes.IgnoreRoute("{controller}/Index");

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
             name: "About",
                 url: "about",
                defaults: new { controller = "Home", action = "About" }
);

            routes.Add("About", new Route("About", new RouteValueDictionary(new { contoller = "Home", action = "About" }), new MvcRouteHandler())); 

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "About",
                url: "About",
                defaults: new { contoller = "Home", action = "About" },
                constraints: new { httpMethod = new HttpMethodConstraint("POST") }
                );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { contoller = "Hone", action = "Index", id = UrlParameter.Optional },
                constraints: new { id =new OnlyDigitConstraint() }

                );





        }
        private class OnlyDigitConstraint : IRouteConstraint
        {
            public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
            {
                if (routeDirection!=RouteDirection.IncomingRequest)
                {
                    return false;
                }
                if (values[parameterName]==UrlParameter.Optional)
                {
                    return true;
                }
                int id;
                return Int32.TryParse(values[parameterName].ToString(), out id);
            }
        }


    }
}
