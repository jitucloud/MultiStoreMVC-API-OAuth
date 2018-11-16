using Autofac;
using Autofac.Integration.WebApi;
using demo.fmc.api;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using System.Reflection;

[assembly: OwinStartup(typeof(Startup))]

namespace demo.fmc.api
{

    public class Startup
    {
        /// Configuration method to configure startup of application
        /// </summary>
        /// <param name="app"></param>
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration configuration = new HttpConfiguration();
            WebApiConfig.Register(configuration);

            // AutoFac
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            new ContextRegistry().Register(builder);
            var container = builder.Build();

            // Create the depenedency resolver.
            var resolver = new AutofacWebApiDependencyResolver(container);
            configuration.DependencyResolver = resolver;
            app.UseAutofacMiddleware(container);
            app.UseAutofacWebApi(configuration);
            app.UseWebApi(configuration);
        }
    }
}