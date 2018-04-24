using System.Web;
using System.Web.Mvc;

namespace Gourmet_s_Choisce
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
