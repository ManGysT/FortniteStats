using FortniteStats.Web.Common;
using System.ComponentModel.DataAnnotations;

namespace FortniteStats.Web.Models.Widget
{
    public class WidgetOptions
    {
        public WidgetOptions()
        {
        }

        public string Platform { get; set; }

        [Required(ErrorMessage = "Для кого вытягивать статистику? Надо задать параметр [epicUserName].")]
        public string EpicUserName { get; set; }

        [Required(ErrorMessage = "Без API key ничего не получится =( Надо задать параметр [apiKey].")]
        public string ApiKey { get; set; }

        public string Stats { get; set; }
    }
}