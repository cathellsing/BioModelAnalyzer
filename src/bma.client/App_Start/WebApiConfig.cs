// Copyright (c) Microsoft Research 2016
// License: MIT. See LICENSE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace bma.client
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            GlobalConfiguration.Configuration.IncludeErrorDetailPolicy  = IncludeErrorDetailPolicy.Always;

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}"
            );
        }
    }
}
