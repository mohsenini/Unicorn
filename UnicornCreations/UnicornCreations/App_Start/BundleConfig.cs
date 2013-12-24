using System.Web.Optimization;

namespace UnicornCreations.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            Bundle masterCssBundle = new Bundle("~/bundles/css/master");
            masterCssBundle.Include("~/Static/less/bootstrap.css");
            masterCssBundle.Include("~/Static/less/custom/unicorn.css");
            masterCssBundle.Transforms.Add(new CssMinify());
            bundles.Add(masterCssBundle);

            bundles.Add(new StyleBundle("~/bundles/css/print")
                            .Include("~/Static/less/print.less"));

            //bundles.Add(new StyleBundle("~/bundles/css/ie")
            //                .Include("~/Static/less/ie.less"));

            Bundle masterScriptBundle = new ScriptBundle("~/bundles/script/master");
            masterScriptBundle.Include("~/Static/bootstrap/js/jquery-1.9.1.min.js");
            masterScriptBundle.Include("~/Static/bootstrap/js/bootstrap.min.js");
            masterScriptBundle.Include("~/Static/js/custom/unicorn.js");
            bundles.Add(masterScriptBundle);

            bundles.UseCdn = true;

            //Bundle jquery = new ScriptBundle("~/bundles/script/jquery", "//ajax.aspnetcdn.com/ajax/jquery/jquery-1.9.1.min.js")
            //    .Include("~/Static/js/jquery-{version}.js");
            //jquery.CdnFallbackExpression = "window.jQuery";
            //bundles.Add(jquery);


        } 
    }
}