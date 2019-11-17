using System.Diagnostics;
using System.Web.Mvc;

namespace ExceptionHandling.Handlers
{
    public class MyExceptionHandler : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            // Hatanın ilk yakalandığı yer
        }
    }
}