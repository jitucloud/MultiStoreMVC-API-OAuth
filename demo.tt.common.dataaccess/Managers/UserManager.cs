using demo.tt.common.dataaccess.Interfaces;
using demo.tt.domain.users.model;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace demo.tt.common.dataaccess.Managers
{
    public class UserManager : BaseContext<UserManager>, IUserContext
    {
        public virtual DbSet<User> Users { get; set; }

        public async Task<User> GetUserByName(string Name)
        {
            return await Task.FromResult(Users.Where(u => string.Equals(u.Name, Name)).FirstOrDefault());
        }
    }
}
