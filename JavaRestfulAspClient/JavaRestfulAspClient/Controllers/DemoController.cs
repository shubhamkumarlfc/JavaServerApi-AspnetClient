using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JavaRestfulAspClient.Models;

namespace JavaRestfulAspClient.Controllers
{
    public class DemoController : Controller
    {
        private DemoRestfulClient demoRestfulClient = new DemoRestfulClient();

        public ActionResult Index()
        {
            ViewBag.result1 = demoRestfulClient.helloWorld().Result;
            ViewBag.result2 = demoRestfulClient.helloWorldHTML().Result;
            ViewBag.result3 = demoRestfulClient.hi("Shubham").Result;
            return View();
        }
    }
}