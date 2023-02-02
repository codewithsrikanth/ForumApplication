using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using UIForumAPP.App_Start;

namespace UIForumAPP
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            
            //Step-4
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
