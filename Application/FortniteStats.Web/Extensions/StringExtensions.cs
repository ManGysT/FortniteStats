using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FortniteStats.Web
{
    public static class StringExtensions
    {
        public static List<string> SplitCommaSeparatedValues(this string source)
        {
            var result = new List<string>();

            if (string.IsNullOrEmpty(source))
            {
                return result;
            }

            var splittedValues = source.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            result.AddRange(splittedValues);

            return result;
        }
    }
}