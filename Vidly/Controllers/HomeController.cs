using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;//for outputcachelocation class


namespace Vidly.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        [OutputCache(Duration = 50,Location = OutputCacheLocation.Server,VaryByParam = "*")] 
        //will render Index page and store in cache
        //set duration = 0 ,varybyparam = "*" ,nostore = true to disable cache
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}