using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Movie_Web.Helpers;

namespace Movie_Web.Controllers
{
    public class LocController : Controller
    {
        // GET: Loc
        public ActionResult Index(string slug)
        {
            Console.WriteLine(slug);
            return View();
        }
    }
}