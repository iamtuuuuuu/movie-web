using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Movie_Web.DAO;
namespace Movie_Web.Controllers
{
    public class DetailFilmController : Controller
    {
        // GET: DetailFilm
        public ActionResult Detail(string id)
        {

            /*var filmDao = new FilmDAO();
            var feedbackDao = new FeedbackDAO();
            var accountDAO = new AccountDAO();
            var filmModel = filmDao.getFilmByID(id);
            var feedBackListModel = feedbackDao.listAll(filmModel.filmID);
           


            ViewBag.filmDetail = filmModel;
            ViewBag.filmFeedBack = feedBackListModel;
            ViewBag.account = accountDAO.GetAccountByID(feedBackModel);*/
            return View();
        }


    }
}