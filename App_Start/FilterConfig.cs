using System.Web;
using System.Web.Mvc;

namespace Tatil_Seyahat_Ytb
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
