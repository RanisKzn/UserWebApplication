using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace UserWebApplication.Client.Services
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<TEntity> GetByIdAsync(int id);

        Task<HttpResponseMessage> DeleteAsync(int id);

        Task<HttpResponseMessage> CreateAsync(TEntity entity);

        Task<TEntity> UpdateAsync(TEntity entity);
    }
}