using System.Web.Optimization;

namespace UIForumAPP.App_Start
{
    //Step-2
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/bootstrap").Include("~/Scripts/jquery-3.6.3.js","~/Scripts/umd/popper.js","~/Scripts/bootstrap.js"));
            bundles.Add(new StyleBundle("~/Styles/bootstrap").Include("~/Content/bootstrap.min.css"));
            bundles.Add(new StyleBundle("~/Styles/MyStyles").Include("~/Content/myStyles.css"));

            //Step-3
            BundleTable.EnableOptimizations = true;

        }
    }
}