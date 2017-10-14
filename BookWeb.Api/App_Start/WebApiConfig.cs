using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace BookWeb.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
            //Camel case covnert to pascal case
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver =
             new CamelCasePropertyNamesContractResolver();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Formatters.Remove(GlobalConfiguration.Configuration.Formatters.XmlFormatter);
            config.Formatters.Add(GlobalConfiguration.Configuration.Formatters.JsonFormatter);
        }
    }
}
