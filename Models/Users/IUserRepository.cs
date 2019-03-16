using System.Collections.Generic;
using System.Threading.Tasks;

namespace Amaryllis.Models.Users
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> FindUserByIdAsync(long id);
    }
}