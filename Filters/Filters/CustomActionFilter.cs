using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters.Filters
{
    public class CustomActionFilter : Attribute,IActionFilter
    {

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            
            // filterContext.HttpContext.Response.Write("Done Action Filter"); 
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Request.Headers.Add("name", "nishikant");
           // filterContext.HttpContext.Response.Write("Done Action Filter");
        }
    }
}