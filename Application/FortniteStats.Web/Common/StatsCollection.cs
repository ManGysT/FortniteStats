using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FortniteStats.Web.Common
{
    public class StatsCollection : Dictionary<string, string>
    {
        public StatsCollection()
        {
        }

        public StatsCollection(IDictionary<string, string> data)
            : base(data)
        {
        }
    }
}