using demo.tt.domain.users.model;
using System.Data.Entity;
using System.Threading.Tasks;
namespace demo.tt.domain.users.interfaces
{
    public interface IUserStore
    {
        DbSet<User> Users { get; set; }
        Task<User> GetUserByName(string Name);
    }
}
