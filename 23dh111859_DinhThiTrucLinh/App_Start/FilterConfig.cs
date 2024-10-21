using System.Web;
using System.Web.Mvc;

namespace _23dh111859_DinhThiTrucLinh
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
