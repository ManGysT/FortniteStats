using FortniteStats.Tracker.Api.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortniteStats.Tracker.Api.Objects
{
    public class GlobalStatsCollection
    {
        [JsonProperty(PlayTypeOriginal.Solo)]
        public StatsGroup GlobalSolo { get; set; }

        [JsonProperty(PlayTypeOriginal.Duo)]
        public StatsGroup GlobalDuo { get; set; }

        [JsonProperty(PlayTypeOriginal.Squad)]
        public StatsGroup GlobalSquad { get; set; }

        [JsonProperty(NamingStrategyType = typeof(ConcatJsonPropertyNamingStrategy), NamingStrategyParameters = new object[] { "curr_", PlayTypeOriginal.Solo })]
        public StatsGroup CurrentSeasonSolo { get; set; }

        [JsonProperty(NamingStrategyType = typeof(ConcatJsonPropertyNamingStrategy), NamingStrategyParameters = new object[] { "curr_", PlayTypeOriginal.Duo })]
        public StatsGroup CurrentSeasonDuo { get; set; }

        [JsonProperty(NamingStrategyType = typeof(ConcatJsonPropertyNamingStrategy), NamingStrategyParameters = new object[] { "curr_", PlayTypeOriginal.Squad })]
        public StatsGroup CurrentSeasonSquad { get; set; }
    }
}
