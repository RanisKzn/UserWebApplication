using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserWebApplication.Core.Entities;

namespace UserWebApplication.Core.Repositories.Bases
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllAsync();

        Task<User> GetIdAsync(int id);

        Task AddAsync(User user);

        void Delete(int id);

        Task<User> Update(User user);

        Task<User> Login(UserDto user);
    }
}
