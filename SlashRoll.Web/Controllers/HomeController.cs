using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SlashRoll.Web.RollReference;

namespace SlashRoll.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            RollClient client = new RollClient();

            int result = client.SlashRoll(User.Identity.Name);

            ViewBag.Message = User.Identity.Name + "rolled " + result;

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
