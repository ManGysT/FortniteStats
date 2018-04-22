using FortniteStats.Tracker.Api;
using FortniteStats.Web.Common;
using FortniteStats.Web.Models;

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

        /// <summary>
        /// Gets the stats.
        /// </summary>
        /// <returns></returns>
        public StatsCollection GetStats()
        {
            var result = new StatsCollection();

            if (this.options.StatsFields == null || this.options.StatsFields.Count == 0)
            {
                return result;
            }

            var profileDetails = this.trackerApi.GetProfileDetails(this.options.Platform, this.options.EpicUserName);

            if (profileDetails != null)
            {
                result.Add(profileDetails.AllStats?.GlobalSolo?.Kills?.Label, profileDetails.AllStats?.GlobalSolo?.Kills?.DisplayValue);
                result.Add(profileDetails.AllStats?.GlobalSolo?.WinRate?.Label, profileDetails.AllStats?.GlobalSolo?.WinRate?.DisplayValue);
            }

            return result;
        }
    }
}