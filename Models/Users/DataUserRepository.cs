using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Amaryllis.Models.Users
{
    public class DataUserRepository : IUserRepository
    {
        public readonly DataContext context;
        public DataUserRepository (DataContext context)
        {
            this.context = context;
        }

        public async Task<User> FindUserByIdAsync(long id)
        {
            return await context.Users.FirstOrDefaultAsync(x=>x.UserId==id);
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await context.Users.ToListAsync();
        }
    }
}