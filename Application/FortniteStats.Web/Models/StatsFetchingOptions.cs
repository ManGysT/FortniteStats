using FortniteStats.Web.Models.Widget;

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

        public static StatsFetchingOptions Factory(WidgetOptions widgetOptions)
        {
            return new StatsFetchingOptions
            {
                Platform = widgetOptions.Platform,
                EpicUserName = widgetOptions.EpicUserName,
                ApiKey = widgetOptions.ApiKey,
            };
        }
    }
}