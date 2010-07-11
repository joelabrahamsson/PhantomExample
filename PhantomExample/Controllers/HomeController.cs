using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhantomExample.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = ConfigurableModule.Configuration.GetConfiguration().Message;

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}