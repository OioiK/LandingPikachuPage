using System.Web.Optimization;

namespace LandingPikachuPage
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/main.css"));
        }
    }
}
