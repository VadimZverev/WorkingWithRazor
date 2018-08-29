using System;
using System.Web.Mvc;

namespace WorkingWithrazor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string[] name = { "Apple", "Orange", "Pear" };
            return View(name);
        }

        public ActionResult List()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult Time()
        {
            return PartialView(DateTime.Now);
        }
    }
}