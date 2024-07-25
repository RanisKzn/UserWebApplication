using Newtonsoft.Json;
using System.Net.Http;
using UserWebApplication.Core.Entities;

namespace UserWebApplication.Client.Services
{
    public class UserService : BaseService<User>
    {
        protected override string BasePath => $"{nameof(User).ToLower()}";

        public UserService(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {

        }

        public virtual async Task<User> LoginAsync(UserDto userDto)
        {
            var response = await _httpClient.PostAsJsonAsync($"{BasePath}/Login", userDto);
            var result = JsonConvert.DeserializeObject<User>(await response.Content.ReadAsStringAsync());

            return result;
        }
    }
}
