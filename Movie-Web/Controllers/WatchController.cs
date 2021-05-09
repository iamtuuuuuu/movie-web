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
            var feedbackDao = new FeedbackDAO();
            var filmModel = FilmEpDAO.getEpisode(idFilm, Episode);


            var feedBackListModel = feedbackDao.listAll(filmModel.filmID);
            var FeedbackOfAcc = feedbackDao.listAccountFB(filmModel.filmID);


            int numrecords = 10;
            ViewBag.listfilmDescendingbyCreateDate = filmDao.listFilmSlideDescendingbyCreateDate(numrecords);
            ViewBag.filmDetail = filmModel;
            ViewBag.filmFeedBack = feedBackListModel;
            ViewBag.FeedBackOfAcc = FeedbackOfAcc;
            return View();
        }
        
    }
}