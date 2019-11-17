using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Configuration;
using ExceptionHandling.App_Start;
using ExceptionHandling.Handlers;

namespace ExceptionHandling
{
    public class MvcApplication : System.Web.HttpApplication
    {

        protected void Application_Start()
        {
            GlobalFilters.Filters.Add(new MyExceptionHandler());

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            var exception = Server.GetLastError();

            // hatayý loglama
            // kullanýcýya hata bilgisi gösterme
            // kullanýcýyý baþka sayfaya yönlendirme
            // v.s...            
        }
    }
}
