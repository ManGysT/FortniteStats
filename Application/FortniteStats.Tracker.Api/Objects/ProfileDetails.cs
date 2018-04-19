using Newtonsoft.Json;

namespace FortniteStats.Tracker.Api.Objects
{
    public class ProfileDetails
    {
        [JsonProperty("accountId")]
        public string AccountId { get; set; }
        [JsonProperty("platformId")]
        public int PlatformId { get; set; }
        [JsonProperty("platformName")]
        public string PlatformName { get; set; }
        [JsonProperty("platformNameLong")]
        public string PlatformNameLong { get; set; }
        [JsonProperty("epicUserHandle")]
        public string EpicUserName { get; set; }
        [JsonProperty("stats")]
        public GlobalStatsCollection AllStats { get; set; }
        [JsonProperty("lifeTimeStats")]
        public LifetimeStatsCollection LifetimeStats { get; set; }
    }
}
