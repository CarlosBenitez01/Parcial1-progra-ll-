using System.Web;
using System.Web.Mvc;

namespace Carlos_Francisco_Benitez_Quintanilla
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
