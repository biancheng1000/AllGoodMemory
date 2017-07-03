using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AllGoodMemory.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "这是可心的个人网页";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "请联系可心的爸爸(-^_^-)!";

            return View();
        }
    }
}