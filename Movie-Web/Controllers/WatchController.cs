using Movie_Web.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movie_Web.Controllers
{
    public class WatchController : Controller
    {
        // GET: Watch
        public ActionResult Watch(string idFilm, int Episode)
        {
            var filmDao = new FilmDAO();
            var FilmEpDAO = new FilmEpisodeDAO();

            var filmModel = FilmEpDAO.getEpisode(idFilm, Episode);
            Console.WriteLine(filmModel);

            int numrecords = 10;
            ViewBag.listfilmDescendingbyCreateDate = filmDao.listFilmSlideDescendingbyCreateDate(numrecords);
            ViewBag.filmDetail = filmModel;
            return View();
        }
        
    }
}