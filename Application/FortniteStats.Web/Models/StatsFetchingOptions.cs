using FortniteStats.Web.Models.Widget;
using System.Collections.Generic;

namespace FortniteStats.Web.Models
{
    public class StatsFetchingOptions
    {
        public StatsFetchingOptions()
        {
        }

        public string Platform { get; set; }
        public string EpicUserName { get; set; }
        public string ApiKey { get; set; }
        public List<string> StatsFields { get; set; }

        public static StatsFetchingOptions Factory(WidgetOptions widgetOptions)
        {
            return new StatsFetchingOptions
            {
                Platform = widgetOptions.Platform,
                EpicUserName = widgetOptions.EpicUserName,
                ApiKey = widgetOptions.ApiKey,
                StatsFields = widgetOptions.Stats.SplitCommaSeparatedValues()
            };
        }
    }
}