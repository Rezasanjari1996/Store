using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myweb.Controllers
{
    public class exampleController : Controller
    {
        // GET: example
        public ActionResult Index()
        {
            ViewData["massage1"] = "hello world";
            ViewBag.massage2 = "salammm";
            return View();
        }

        public ActionResult Index2()
        {
            return View();
        }

        public ActionResult Index3()
        {
            return View();
        }
    }
}