using UserWebApplication.Core.Entities;

namespace UserWebApplication.Client.Services
{
    public class RequestCategoryService : BaseService<RequestCategory>
    {
        protected override string BasePath => $"{nameof(RequestCategory).ToLower()}";

        public RequestCategoryService(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {

        }
    }
}
