
using Autofac;
using Autofac.Integration.Mvc;
using demo.fmc.web;
using Microsoft.Owin;
using Owin;
using System.Reflection;
using System.Web.Compilation;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

[assembly: OwinStartup(typeof(Startup))]
namespace demo.fmc.web
{
    public class Startup
    {
        /// Configuration method to configure startup of application
        /// </summary>
        /// <param name="app"></param>
        public void Configuration(IAppBuilder app)
        {                  
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

            //////////////////////////////AUTOFAC CONFIG/////////////////////START
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            // Injection for controller
            new ContextRegistry().Register(builder);


            builder.RegisterModule<AutofacWebTypesModule>();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}