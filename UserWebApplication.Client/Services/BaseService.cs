using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;
using System.Net.Http;

namespace UserWebApplication.Client.Services
{
    public abstract class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private readonly IHttpClientFactory _httpClientFactory;

        protected readonly HttpClient _httpClient;

        protected virtual string BasePath => $"{nameof(TEntity).ToLower()}";

        public BaseService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _httpClient = _httpClientFactory.CreateClient("Api");
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            var result = await _httpClient.GetFromJsonAsync<IEnumerable<TEntity>>($"{BasePath}/GetAll")!;
            return result!;
        }

        public virtual async Task<HttpResponseMessage> DeleteAsync(int id)
        {
            var result = await _httpClient.DeleteAsync($"{BasePath}/Delete/{id}");
            return result;
        }

        public virtual async Task<HttpResponseMessage> CreateAsync(TEntity entity)
        {
            var result = await _httpClient.PostAsJsonAsync($"{BasePath}/Add", entity);
            return result;
        }

        public virtual async Task<TEntity> UpdateAsync(TEntity entity)
        {
            var response = await _httpClient.PutAsJsonAsync($"{BasePath}/Update", entity);
            var result = JsonConvert.DeserializeObject<TEntity>(await response.Content.ReadAsStringAsync());

            return result;
        }

        public virtual async Task<TEntity> GetByIdAsync(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<TEntity>($"{BasePath}/GetById/{id}")!;
            return result!;
        }
    }
}
