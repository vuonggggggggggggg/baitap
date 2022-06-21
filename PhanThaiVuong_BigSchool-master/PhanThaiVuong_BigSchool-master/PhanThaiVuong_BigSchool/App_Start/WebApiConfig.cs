using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace PhanThaiVuong_BigSchool
{

    public class WebApiConfig

    {
        public static void Register(HttpConfiguration config)
        {


            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "UnFollow",
                routeTemplate: "api/unfollow/{followerId}/{followeeId}",
                defaults: new { controller = "Followings", action = "UnFollow", followerId = RouteParameter.Optional, followeeId = RouteParameter.Optional }
                );
        }

      
    }
}

   