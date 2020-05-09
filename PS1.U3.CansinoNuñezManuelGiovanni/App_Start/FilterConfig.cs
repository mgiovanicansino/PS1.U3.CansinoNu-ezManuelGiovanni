using System.Web;
using System.Web.Mvc;

namespace PS1.U3.CansinoNuñezManuelGiovanni
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
