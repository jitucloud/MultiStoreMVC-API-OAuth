using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using demo.tt.domain.users.interfaces;
using demo.tt.domain.users.model;

namespace demo.tt.domain.users.store
{
    public class UserStore : IUserStore
    {
        public virtual DbSet<User> Users { get; set; }

        /// <summary>
        /// Get User By Name
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public async Task<User> GetUserByName(string Name)
        {
            return await Task.FromResult(Users.Where(u => string.Equals(u.Name, Name)).FirstOrDefault());
        }
    }
}
