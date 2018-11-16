using demo.tt.common.dataaccess.Interfaces;
using System.Data.Entity;

namespace demo.tt.common.dataaccess.Managers
{
    public class JobManager : DbContext, IJobContext 
    {
    }
}
