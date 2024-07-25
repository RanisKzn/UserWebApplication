using UserWebApplication.Core.Entities;

namespace UserWebApplication.Client.Services
{
    public class UserProvider : IUserProvider
    {
        public User CurrentUser { get; set; }
    }
}
