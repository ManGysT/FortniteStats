using AttributeRouting.Web.Mvc;
using FortniteStats.Web.Models;
using FortniteStats.Web.Models.Widget;
using FortniteStats.Web.Services;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace FortniteStats.Web.Controllers
{
    public class WidgetController : Controller
    {
        [GET("{EpicUserName}/{Platform:regex(^pc$|^xbl$|^psn$)=pc}")]
        [GET("{Platform:regex(^pc$|^xbl$|^psn$)=pc}")]
        public async Task<ActionResult> Index(WidgetOptions options)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View("Error", ErrorModel.Factory(this.ModelState));
            }

            var statsFetcher = new StatsFetchingService(StatsFetchingOptions.Factory(options));

            var statsFields = options.Stats.GetCommaSeparatedValues();
            var stats = await statsFetcher.GetStatsAsync(statsFields);

            var outputModel = new WidgetOutputModel
            {
                Stats = stats
            };

            return this.View(outputModel);
        }

        [GET("")]
        [AjaxOnly]
        public async Task<ActionResult> GetData(WidgetOptions options)
        {
            var statsFetcher = new StatsFetchingService(StatsFetchingOptions.Factory(options));

            var statsFields = options.Stats.GetCommaSeparatedValues();
            var stats = await statsFetcher.GetStatsAsync(statsFields);

            return this.Json(stats);
        }
    }
}