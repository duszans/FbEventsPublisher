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
            List<FbEvent> events = new List<FbEvent>
                                   {
                                       new FbEvent { Category = FbCategory.It, Description = "Description1", Name = "Name1" },
                                       new FbEvent { Category = FbCategory.It, Description = "Description2", Name = "Name2" }
                                   };
            return this.View(events);
        }
    }
}
