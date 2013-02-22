using System.Web;
using System.Web.Mvc;

namespace Elastacloud.Spotify.Goose
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}