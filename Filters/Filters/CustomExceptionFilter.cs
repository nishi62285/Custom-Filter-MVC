using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {

        public void OnException(ExceptionContext filterContext)
        {
            var controllerName = (string)filterContext.RouteData.Values["controller"];
            var actionName = (string)filterContext.RouteData.Values["action"];
            var model = new HandleErrorInfo(filterContext.Exception, controllerName, actionName);

            //filterContext.Result = new RedirectToRouteResult("Error", null);

            filterContext.Result = new ViewResult
            {
                ViewData = new ViewDataDictionary<HandleErrorInfo>(model),
                ViewName = "~/Views/Error/Index.cshtml",
            };
            filterContext.ExceptionHandled = true;  
            //filterContext.Result = new ViewResult
            //{
            //    ViewName = "~/Views/Error/Index.cshtml", 
                
            //};
        }
    }
}