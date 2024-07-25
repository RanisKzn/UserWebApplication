using UserWebApplication.Core.Entities;

namespace UserWebApplication.Client.Services
{
    public class UserService : BaseService<User>
    {
        protected override string BasePath => $"{nameof(User).ToLower()}";

        public UserService(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {

        }
    }
}
