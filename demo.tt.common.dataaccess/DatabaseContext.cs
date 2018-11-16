using demo.tt.domain.forms.model;
using demo.tt.domain.jobs.model;
using demo.tt.domain.users.model;
using System.Data.Entity;

namespace demo.tt.common.dataaccess
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Form> Forms { get; set; }

        public DatabaseContext() : base("Demo")
        {
        }
    }
}
