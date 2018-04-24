using Dealius.Core;
using Newtonsoft.Json;

namespace FortniteStats.Web.Common.Json
{
    public static class JsonHelper
    {
        public static JsonSerializerSettings DefaultSettings()
        {
            return new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateFormatString = DateTimeExtensions.FormatISO8106,
                DateParseHandling = DateParseHandling.DateTimeOffset,
                Formatting = Formatting.None,
                NullValueHandling = NullValueHandling.Include,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
            };
        }
    }
}