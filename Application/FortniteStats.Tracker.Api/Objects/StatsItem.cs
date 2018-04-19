using Newtonsoft.Json;

namespace FortniteStats.Tracker.Api.Objects
{
    public class StatsItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }
        [JsonProperty("field")]
        public string Field { get; set; }
        [JsonProperty("category")]
        public StatsCategory Category { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
        [JsonProperty("rank")]
        public string Rank { get; set; }
        [JsonProperty("displayValue")]
        public string DisplayValue { get; set; }
    }
}
