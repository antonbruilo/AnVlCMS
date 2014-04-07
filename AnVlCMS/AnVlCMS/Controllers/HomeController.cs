using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnVlCMS.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            int i = 10;
            int h = 5;
            double klo = 25.0;
            int e = 7;

         return View();
        }

    }
}
