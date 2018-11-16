using demo.tt.common.rest;
using System.Web.Http;

namespace demo.fmc.api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Base Api Config
            BaseApiConfig.Register(config);

            // Web API routes
            config.MapHttpAttributeRoutes();
            config.EnsureInitialized();
        }
    }
}
