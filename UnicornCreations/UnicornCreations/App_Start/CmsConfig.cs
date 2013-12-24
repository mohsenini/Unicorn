using System.Web.Mvc;
using System.Web.Routing;
using N2.Engine;
using N2.Web.Mvc;

namespace UnicornCreations.App_Start
{
    public class CmsConfig
    {
        public static void Register(RouteCollection routes, ViewEngineCollection viewEngines, IEngine engine)
        {
            routes.MapContentRoute("Content", N2.Context.Current);
        }
    }
}