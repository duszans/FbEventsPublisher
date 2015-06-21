namespace Web.Controllers
{
    using System.Collections.Generic;
    using System.Web.Mvc;

    using EventsProvider;

    public class HomeController : Controller
    {
        public ActionResult Index(FbCategory? id)
        {
            FbCategory category = id ?? FbCategory.IT;
            List<FbEvent> events = new EventsRepository().GetByCategory(category);
            this.ViewBag.Category = category;
            return this.View(events);
        }
    }
}
