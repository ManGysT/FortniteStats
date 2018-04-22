using AttributeRouting.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FortniteStats.Web.Controllers
{
    public class WidgetConstructorController : Controller
    {
        [GET("constructor")]
        public ActionResult Index()
        {
            return this.View();
        }
    }
}