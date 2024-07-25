using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserWebApplication.Core.Entities;

namespace UserWebApplication.Core.Repositories
{
    public interface IRequestRepository
    {
        Task<List<Request>> GetAllAsync();

        Task<Request> GetIdAsync(int id);

        Task AddAsync(Request request);

        void Delete(int id);

        Task<Request> Update(Request request);
    }
}
