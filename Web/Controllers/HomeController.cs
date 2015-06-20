using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    using EventsProvider;

    public class HomeController : Controller
    {
        public ActionResult Index(FbCategory? id)
        {
            FbCategory category = id ?? FbCategory.It;
            List<FbEvent> events = new EventsRepository().GetByCategory(category);
            return this.View(events);
        }

    }
}
