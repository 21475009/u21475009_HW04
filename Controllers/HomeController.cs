using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u21475009_HW04.Controllers
{
    public class HomeController : Controller


    {
        


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Apply()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Application page";

            return View();
        }
    }
}