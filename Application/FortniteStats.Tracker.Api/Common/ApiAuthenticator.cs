using RestSharp;
using RestSharp.Authenticators;

namespace FortniteStats.Tracker.Api.Common
{
    internal class ApiAuthenticator : IAuthenticator
    {
        private readonly string apiKey;

        public ApiAuthenticator(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public void Authenticate(IRestClient client, IRestRequest request)
        {
            request.AddHeader("TRN-Api-Key", this.apiKey);
        }
    }
}
