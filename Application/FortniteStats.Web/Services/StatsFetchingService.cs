using FortniteStats.Tracker.Api;
using FortniteStats.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FortniteStats.Web.Services
{
    public class StatsFetchingService
    {
        private readonly IFortniteTrackerApi trackerApi;
        private readonly StatsFetchingOptions options;

        public StatsFetchingService(StatsFetchingOptions options)
        {
            this.trackerApi = FortniteTrackerApiFactory.Create(options.ApiKey);
            this.options = options;
        }

        public async Task<Dictionary<string, string>> GetStatsAsync(List<string> statsFields)
        {
            var result = new Dictionary<string, string>();

            if (statsFields == null || statsFields.Count == 0)
            {
                return result;
            }

            var profileDetails = await this.trackerApi.GetProfileDetailsAsync(this.options.Platform, this.options.EpicUserName);

            if (profileDetails != null)
            {
                result.Add(profileDetails.AllStats?.GlobalSolo?.WinRate?.Label, profileDetails.AllStats?.GlobalSolo?.WinRate?.DisplayValue);
                result.Add(profileDetails.AllStats?.GlobalSolo?.Kills?.Label, profileDetails.AllStats?.GlobalSolo?.Kills?.DisplayValue);
            }

            return result;
        }
    }
}