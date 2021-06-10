using System.Web.Optimization;

namespace LandingPikachuPage
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/less").Include(
                      "~/Content/less/main.css"));
        }
    }
}
