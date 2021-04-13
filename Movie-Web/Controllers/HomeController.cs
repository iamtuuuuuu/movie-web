using Movie_Web.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Movie_Web.Models;

namespace Movie_Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var filmdao = new FilmDAO();
            ViewBag.listfilm = filmdao.listAll();
            int numrecords = 10;
            ViewBag.listfilmSlide = filmdao.listFilmSlideDescendingbyCreateDate(numrecords);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Detail()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult SignIn()
        {
            return View();
        }
        public ActionResult SingOut()
        {
            return View();
        }
        public ActionResult Category()
        {
            return View();
        }
    }
}