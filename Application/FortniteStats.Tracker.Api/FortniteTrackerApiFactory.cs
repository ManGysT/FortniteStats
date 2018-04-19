namespace FortniteStats.Tracker.Api
{
    public static class FortniteTrackerApiFactory
    {
        public static IFortniteTrackerApi Create(string apiKey)
        {
            return new FortniteTrackerApi(apiKey);
        }
    }
}
