using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Common;

using static System.Configuration.ConfigurationManager;

namespace AzureConstructionsProgressTracker
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            new ProjectAddedQueueService(ConnectionStrings["AzureServiceBus"].ConnectionString)
                .Register();
        }
    }
}
