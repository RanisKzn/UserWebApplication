using UserWebApplication.Core.Entities;

namespace UserWebApplication.Client.Services
{
    public class RequestService : BaseService<Request>
    {
        protected override string BasePath => $"{nameof(Request).ToLower()}";

        public RequestService(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {

        }
    }
}
