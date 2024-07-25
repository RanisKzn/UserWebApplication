using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserWebApplication.Core.Entities;

namespace UserWebApplication.Core.Repositories
{
    public interface IRequestCategoryRepository
    {
        Task<List<RequestCategory>> GetAllAsync();

        Task<RequestCategory> GetIdAsync(int id);

        Task AddAsync(RequestCategory RequestCategory);

        void Delete(int id);

        Task<RequestCategory> Update(RequestCategory RequestCategory);
    }
}
