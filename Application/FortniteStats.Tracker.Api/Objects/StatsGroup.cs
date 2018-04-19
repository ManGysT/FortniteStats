using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortniteStats.Tracker.Api.Objects
{
    public class StatsGroup
    {
        [JsonProperty("trnRating")]
        public StatsItem TrnRating { get; set; }

        [JsonProperty("score")]
        public StatsItem Score { get; set; }

        [JsonProperty("top1")]
        public StatsItem Top1 { get; set; }

        [JsonProperty("top3")]
        public StatsItem Top3 { get; set; }

        [JsonProperty("top5")]
        public StatsItem Top5 { get; set; }

        [JsonProperty("top6")]
        public StatsItem Top6 { get; set; }

        [JsonProperty("top10")]
        public StatsItem Top10 { get; set; }

        [JsonProperty("top12")]
        public StatsItem Top12 { get; set; }

        [JsonProperty("top25")]
        public StatsItem Top25 { get; set; }

        [JsonProperty("kd")]
        public StatsItem KillsDeaths { get; set; }

        [JsonProperty("winRatio")]
        public StatsItem WinRate { get; set; }

        [JsonProperty("matches")]
        public StatsItem Matches { get; set; }

        [JsonProperty("kills")]
        public StatsItem Kills { get; set; }

        [JsonProperty("kpg")]
        public StatsItem KillsPerMatch { get; set; }

        [JsonProperty("scorePerMatch")]
        public StatsItem ScorePerMatch { get; set; }
    }
}
