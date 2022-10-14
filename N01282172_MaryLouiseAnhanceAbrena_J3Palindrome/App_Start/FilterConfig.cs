using System.Web;
using System.Web.Mvc;

namespace N01282172_MaryLouiseAnhanceAbrena_J3Palindrome
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
