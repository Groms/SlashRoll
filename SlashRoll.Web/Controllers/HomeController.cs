using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SlashRoll.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = User.Identity.Name;

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
