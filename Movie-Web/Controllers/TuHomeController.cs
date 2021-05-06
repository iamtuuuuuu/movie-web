using Movie_Web.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Movie_Web.Models;

namespace Movie_Web.Controllers
{
    public class TuHomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    var filmdao = new FilmDAO();
        //    ViewBag.listfilm = filmdao.listAll();
        //    int numrecords = 10;
        //    ViewBag.listfilmSlide = filmdao.listFilmSlideDescendingbyCreateDate(numrecords);
        //    return View();
        //}

        public ActionResult Index(string key)
        {
            var filmdao = new FilmDAO();
            
            int numrecords = 10;
            ViewBag.listfilm = filmdao.lstFilmSearch(key,numrecords);

            ViewBag.listfilmSlide = filmdao.listFilmSlideDescendingbyCreateDate(numrecords);
            return View();
        }



    }
}