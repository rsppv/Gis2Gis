using System.Web.Optimization;

namespace Gis2Gis
{
  public class BundleConfig
  {
    // Дополнительные сведения об объединении см. по адресу: http://go.microsoft.com/fwlink/?LinkId=301862
    public static void RegisterBundles(BundleCollection bundles)
    {
      bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                  "~/Scripts/jquery-{version}.js",
                  "~/Scripts/jquery-{version}.intellisense.js"));

      bundles.Add(new ScriptBundle("~/bundles/npm").Include(
                    "~/Scripts/npm.js"));

      bundles.Add(new ScriptBundle("~/bundles/map").Include(
                    "~/Scripts/map-init.js"));

      bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js"));

      bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/bootstrap-theme.css",
                "~/Content/jumbotron-narrow.css"));
    }
  }
}