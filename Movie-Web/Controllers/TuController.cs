using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Movie_Web.Models;
using Movie_Web.DAO;

namespace Movie_Web.Controllers
{
    public class TuController : Controller
    {
        // GET: Tu
        public ActionResult Index()
        {
            var filmdao = new FilmDAO();
            ViewBag.listAll = filmdao.listAll();
            return View();
        }
    }
}