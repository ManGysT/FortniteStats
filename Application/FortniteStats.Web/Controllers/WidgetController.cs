using AttributeRouting.Web.Mvc;
using FortniteStats.Web.Models;
using FortniteStats.Web.Models.Widget;
using System.Web.Mvc;

namespace FortniteStats.Web.Controllers
{
    public class WidgetController : Controller
    {
        [GET("{EpicUserName}/{Platform:regex(^pc$|^xbl$|^psn$)=pc}")]
        [GET("{Platform:regex(^pc$|^xbl$|^psn$)=pc}")]
        public ActionResult Index(WidgetOptions options)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View("Error", ErrorModel.Factory(this.ModelState));
            }

            var outputModel = new WidgetOutputModel
            {
                Options = options
            };

            return this.View(outputModel);
        }
    }
}