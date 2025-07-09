using System.Web;
using System.Web.Mvc;

namespace HHH_MVC_StudenEnrollDemo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
