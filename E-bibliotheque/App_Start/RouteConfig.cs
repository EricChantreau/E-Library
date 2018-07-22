using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace E_librairy
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "Print",
                defaults: new { controller = "Book", action = "Index" }
            );

            routes.MapRoute(
                name: "Authors",
                url: "Print/Authors",
                defaults: new { controller = "Author", action = "Index" }
            );

            routes.MapRoute(
                name: "Author",
                url: "Print/Author/{id}",
                defaults: new { controller = "Author", action = "GetAuthor" },
                constraints: new { id = @"\^d+$" }
            );

            routes.MapRoute(
                name: "Book",
                url: "Print/Book/{id}",
                defaults: new { controller = "Book", action = "GetBook" },
                constraints: new { id = @"\^d+$" }
            );

            routes.MapRoute(
                name: "SearchBook",
                url: "Search/Book/{keyword}",
                defaults: new { controller = "Book", action = "SearchBook" }
            );
        }
    }
}
