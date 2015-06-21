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
            FbCategory category = id ?? FbCategory.IT;
//            List<FbEvent> events = new List<FbEvent>
//                                   {
//                                       new FbEvent { Category = FbCategory.IT.ToString(), Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer venenatis in risus nec laoreet. Suspendisse gravida, nulla vitae elementum rutrum, urna ante convallis nisi, sit amet vestibulum odio nisl at ante. Nullam placerat semper neque, et consectetur ex dapibus eget. Nullam mattis nisi ligula. Donec vitae quam quis neque imperdiet elementum non id orci. Fusce purus nulla, interdum nec nulla sit amet, fermentum porta ipsum. Curabitur a neque at nisl pretium placerat. Nulla pharetra, lorem semper placerat elementum, velit diam blandit metus, et dapibus arcu nisi vel lorem. Integer pretium lectus et commodo maximus. Suspendisse et ante augue. Vestibulum consequat elit eget fermentum pulvinar. Praesent faucibus id metus quis mollis. Cras at facilisis purus.1", Name = "Name1" },
//                                       new FbEvent { Category = FbCategory.IT.ToString(), Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer venenatis in risus nec laoreet. Suspendisse gravida, nulla vitae elementum rutrum, urna ante convallis nisi, sit amet vestibulum odio nisl at ante. Nullam placerat semper neque, et consectetur ex dapibus eget. Nullam mattis nisi ligula. Donec vitae quam quis neque imperdiet elementum non id orci. Fusce purus nulla, interdum nec nulla sit amet, fermentum porta ipsum. Curabitur a neque at nisl pretium placerat. Nulla pharetra, lorem semper placerat elementum, velit diam blandit metus, et dapibus arcu nisi vel lorem. Integer pretium lectus et commodo maximus. Suspendisse et ante augue. Vestibulum consequat elit eget fermentum pulvinar. Praesent faucibus id metus quis mollis. Cras at facilisis purus.2", Name = "Name2" }
//                                   };
            List<FbEvent> events = new EventsRepository().GetByCategory(category);
            return this.View(events);
        }

        //public ActionResult About()
        //{
        //    return View();
        //}
    }
}
