using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPlayground.Controllers
{
    public class TestStuffController : Controller
    {
        // GET: TestStuff
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TestProgress()
        {
            return PartialView("TestProgressBar");
        }

        public ActionResult TestNothing()
        {
            return null;
        }

        [HttpPost]
        public ActionResult TestSearch()
        {
            return null;
        }
    }
}