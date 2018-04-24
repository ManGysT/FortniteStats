using System.Collections.Generic;

namespace FortniteStats.Web.Models.Widget
{
    public class WidgetOutputModel
    {
        public WidgetOutputModel()
        {
            this.Stats = new Dictionary<string, string>();
        }

        public WidgetOptions Options { get; set; }

        public IDictionary<string, string> Stats { get; set; }
    }
}