using Newtonsoft.Json.Serialization;

namespace FortniteStats.Tracker.Api.Common
{
    public class ConcatJsonPropertyNamingStrategy : NamingStrategy
    {
        private readonly object[] values;

        public ConcatJsonPropertyNamingStrategy(object value1, object value2)
            : this (value1, value2, null)
        {
        }

        public ConcatJsonPropertyNamingStrategy(object value1, object value2, object value3)
            : this(value1, value2, value3, null)
        {
        }

        public ConcatJsonPropertyNamingStrategy(object value1, object value2, object value3, object value4)
            : this(value1, value2, value3, value4, null)
        {
        }

        public ConcatJsonPropertyNamingStrategy(object value1, object value2, object value3, object value4, object value5)
        {
            this.values = new object[]
            {
                value1,
                value2,
                value3,
                value4,
                value5,
            };
        }

        protected override string ResolvePropertyName(string name)
        {
            return string.Concat(this.values);
        }
    }
}
