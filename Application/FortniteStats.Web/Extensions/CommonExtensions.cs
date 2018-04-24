using System.Linq;
using System.Web;
using System.Web.Mvc;
using FortniteStats.Web.Common.Json;
using Newtonsoft.Json;

namespace FortniteStats.Web
{
    public static class CommonExtensions
    {
        /// <summary>
        /// Determines whether [is json request] [the specified model state].
        /// </summary>
        /// <param name="request">The request.</param>
        public static bool IsJsonRequest(this HttpRequestBase request)
        {
            var requestTypes = request.AcceptTypes ?? new string[0];
            return requestTypes.Contains("application/json");
        }

        /// <summary>
        /// Toes the json.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="settings">The settings.</param>
        /// <returns></returns>
        public static string ToJson(this object source, JsonSerializerSettings settings = null)
        {
            return JsonConvert.SerializeObject(source, settings ?? JsonHelper.DefaultSettings());
        }

        /// <summary>
        /// Froms the json.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json">The json.</param>
        /// <param name="settings">The settings.</param>
        /// <returns></returns>
        public static T FromJson<T>(this string json, JsonSerializerSettings settings = null)
        {
            return string.IsNullOrEmpty(json)
                ? default(T)
                : JsonConvert.DeserializeObject<T>(json, settings ?? JsonHelper.DefaultSettings());
        }

        /// <summary>
        /// To the js.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="settings">The settings.</param>
        /// <returns></returns>
        public static IHtmlString ToJs(this object source, JsonSerializerSettings settings = null)
        {
            return MvcHtmlString.Create(ToJson(source, settings));
        }
    }
}