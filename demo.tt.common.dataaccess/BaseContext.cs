using System.Data.Entity;

namespace demo.tt.common.dataaccess
{
    public class BaseContext<TContext> : DbContext where TContext : DbContext
    {
        static BaseContext()
        {
            Database.SetInitializer<TContext>(null);
        }

        protected BaseContext() : base("Demo")
        {

        }
    }
}
