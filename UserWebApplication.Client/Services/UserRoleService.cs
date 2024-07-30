using UserWebApplication.Core.Entities;

namespace UserWebApplication.Client.Services
{
    public class UserRoleService : BaseService<UserRole>
    {
        protected override string BasePath => $"{nameof(UserRole).ToLower()}";

        public UserRoleService(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }
    }
}
