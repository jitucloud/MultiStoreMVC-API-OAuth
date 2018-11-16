using Autofac;
using demo.tt.common.dataaccess.Interfaces;
using demo.tt.common.dataaccess.Managers;


namespace demo.fmc.web
{
    public class ContextRegistry
    {
        public void Register(ContainerBuilder builder)
        {
           builder.RegisterInstance<IUserContext>( new UserManager());

        }
    }
}