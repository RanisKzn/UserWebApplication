using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserWebApplication.Core.Entities;

namespace UserWebApplication.Core.Repositories
{
    public interface IUserRoleRepository
    {
        Task<List<UserRole>> GetAllAsync();

        Task<UserRole> GetIdAsync(int id);

        Task AddAsync(UserRole UserRole);

        void Delete(int id);

        Task<UserRole> Update(UserRole UserRole);
    }
}
