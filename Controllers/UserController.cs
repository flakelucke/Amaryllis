using System.Collections.Generic;
using System.Threading.Tasks;
using Amaryllis.Models.Users;
using Microsoft.AspNetCore.Mvc;

namespace Amaryllis.Controllers
{
    [Route("api/users")]
    public class UserController:Controller
    {
        private readonly IUserRepository repository;
        public UserController(IUserRepository repository)
        {
            this.repository = repository;
        }
        [HttpGet]
        public async Task<IEnumerable<User>> GetAllUsers()
        {
            var  k = await repository.GetAllUsersAsync();
            return await repository.GetAllUsersAsync();
        }
    }
}