using System.Web;
using System.Web.Mvc;

namespace TL_LT_Web_14
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
