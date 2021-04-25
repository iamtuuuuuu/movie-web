using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Movie_Web.DAO;
namespace Movie_Web.Controllers
{
    public class TuDetailFilmController : Controller
    {
        // GET: DetailFilm
        public ActionResult Detail(string id)
        {

            var filmDao = new FilmDAO();

            var feedbackDao = new FeedbackDAO();

            var filmModel = filmDao.getFilmByID(id);
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