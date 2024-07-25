using UserWebApplication.Core.Entities;

namespace UserWebApplication.Client.Services
{
    public interface IUserProvider
    {
        User CurrentUser { get; set; }
    }
}
