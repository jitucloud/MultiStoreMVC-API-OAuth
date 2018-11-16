using demo.tt.common.rest;
using System.Linq;
using System.Web.Http;

namespace demo.mondo.api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            BaseApiConfig.Register(config);

            // Web API routes
            config.MapHttpAttributeRoutes();
        }
    }
}
