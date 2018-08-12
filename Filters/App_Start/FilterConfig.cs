using Filters.Filters;
using System.Web;
using System.Web.Mvc;

namespace Filters
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new CustomExceptionFilter());
            filters.Add(new CustomActionFilter());
            //filters.Add(new CustomExceptionFilter());
        }
    }
}