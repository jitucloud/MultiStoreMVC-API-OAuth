using demo.tt.domain.user.model;
using System.Data.Entity;
using System.Threading.Tasks;

namespace demo.tt.common.dataaccess.Interfaces
{
    public interface IUserContext : IDbContext 
    {
        DbSet<User> Users { get; set; }
        Task<User> GetUserByName(string Name);
    }
}
