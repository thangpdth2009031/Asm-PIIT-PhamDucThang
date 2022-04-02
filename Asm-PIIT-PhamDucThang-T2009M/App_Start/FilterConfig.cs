using System.Web;
using System.Web.Mvc;

namespace Asm_PIIT_PhamDucThang_T2009M
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
