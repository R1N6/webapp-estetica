using System.Web;
using System.Web.Mvc;

namespace MVC_Maca_Co
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
