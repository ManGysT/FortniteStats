using FortniteStats.Tracker.Api.Common;
using FortniteStats.Tracker.Api.Objects;
using RestSharp;
using System.Threading.Tasks;

namespace FortniteStats.Tracker.Api
{
    internal class FortniteTrackerApi : IFortniteTrackerApi
    {
        private const string baseUrl = "https://api.fortnitetracker.com/v1";
        private readonly RestClient client;

        public FortniteTrackerApi(string apiKey)
        {
            this.client = new RestClient(baseUrl);
            this.client.AddHandler("application/json", NewtonsoftJsonSerializer.Default);
            this.client.Authenticator = new ApiAuthenticator(apiKey);
        }

        /// <summary>
        /// Gets the profile details.
        /// </summary>
        /// <param name="platform">The platform.</param>
        /// <param name="epicUserName">Name of the epic user.</param>
        /// <returns></returns>
        public async Task<ProfileDetails> GetProfileDetailsAsync(string platform, string epicUserName)
        {
            var request = new RestRequest("profile/{platform}/{epicUserName}", Method.GET);
            request.AddUrlSegment("platform", platform.ToLowerInvariant());
            request.AddUrlSegment("epicUserName", epicUserName);

            var response = await this.client.ExecuteTaskAsync<ProfileDetails>(request);

            return response.Data;
        }
    }
}
