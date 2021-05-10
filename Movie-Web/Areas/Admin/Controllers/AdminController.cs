using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Movie_Web.DAO;
using Movie_Web.Models;
using Movie_Web.Helpers;
using System.Globalization;

namespace Movie_Web.Areas.Admin.Controllers
{

    public class AdminController : Controller
    {
        // GET: Admin/Admin
        [HttpGet]
        [Authorize(Roles = "True")]
        public ActionResult Index()
        {
            // fill bar chart model
            var barchartData = getBarChartData();
            ViewBag.barData = barchartData;
            return View();
        }

        public BarChartCM getBarChartData()
        {
            var modelChart = new BarChartCM();
            var labels = new List<string>();
            labels.Add("2019");
            labels.Add("2020");
            labels.Add("2021");
            
            var datasets = new List<BarChartChildCM>();
            var childModel = new BarChartChildCM();

            childModel.label = "Comments";
            childModel.backgroundColor = @"#4e73df";
            childModel.hoverBackgroundColor = @"#2e59d9";
            childModel.borderColor = @"#4e73df";
            var feedbackdao = new FeedbackDAO();
            List<int> dataList = new List<int>();
            //var abc= feedbackdao.getQuantityCommentTK("2019-01-01", "2019-12-31");

            //List<int> dataList = feedbackdao.getQuantityCommentOfYears();
            childModel.data = dataList;
            datasets.Add(childModel);
            modelChart.labels = labels;
            modelChart.datasets = datasets;
            return modelChart;
        }

        public ActionResult Accounts()
        {
            var accountDao = new AccountDAO();
            var lstAcc = accountDao.listAccountDescendingbyID();
            ViewBag.listAcc = lstAcc;
            List<string> listAccUsername = new List<string>();
            foreach (var acc in lstAcc)
            {
                listAccUsername.Add(acc.username);
            }
            ViewBag.listUsername = listAccUsername;
            return View();
        }

        public ActionResult Films()
        {
            var filmDao = new FilmDAO();
            ViewBag.listFilm = filmDao.listAllAdmin();
            return View();
        }


        public ActionResult Edit(string id)
        {
            var filmDao = new FilmDAO();
            var filmDetail = filmDao.getFilmByID(id);
            DateTime format = (DateTime)filmDetail.releaseFilm;
            var formatDT = format.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            //var dt = filmDetail.releaseFilm.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            ViewBag.filmDetail = filmDetail;
            ViewBag.dt = formatDT;
            //ViewBag.dt = formatDT;
            //DateTime dt = (DateTime)filmDetail.releaseFilm;
            //ViewBag.dateadd = convertToString(dt);
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Film film)
        {
            try
            {
                var filmDao = new FilmDAO();
                var oldFilm = filmDao.getFilmByID(film.filmID);
                foreach (PropertyInfo propertyInfo in film.GetType().GetProperties())
                {
                    propertyInfo.SetValue(oldFilm, propertyInfo.GetValue(film));
                }
                filmDao.dbFilmContext.SaveChanges();
                return RedirectToAction("Films");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult FeedBack(string id)
        {
            return View();
        }

        public ActionResult CreateFilmLe()
        {

            return View();
        }

        public ActionResult CreateFilmBo()
        {

            return View();
        }

        [HttpPost]
        //FormCollection formvalue
        //public ActionResult CreateUser(FormCollection fc)
        //{

        //    UserModel usermodel = new UserModel();

        //    if (TryUpdateModel(usermodel, fc.ToValueProvider()))

        //        UpdateModel(usermodel, fc.ToValueProvider());

        //    return View("UserView");
        //}

        public ActionResult addFilm(Film filmboInfor)
        {
            try
            {
                filmboInfor.createDate = DateTime.Now;
                filmboInfor.createBy = "Hung";
                filmboInfor.releasedEpisodes = 0;
                var filmDao = new FilmDAO();
                filmDao.insertFilm(filmboInfor);
                return RedirectToAction("Films");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult addFilmEpisode(string id)
        {
            var filmDao = new FilmDAO();
            ViewBag.filmBo = filmDao.getFilmByID(id);
            ViewData["episodeNow"] = filmDao.getFilmByID(id).releasedEpisodes + 1;
            return View();
        }

        [HttpPost]
        public ActionResult addFilmEpisode(FilmEpisode ep)
        {

            int res = new FilmEpisodeDAO().CreateTapPhim(ep);

            string message = "SUCCESS";
            if (res > 0)
            {
                var filmBoID = ep.filmID;
                var filmDao = new FilmDAO();
                var inforFilm = filmDao.getFilmByID(filmBoID);
                inforFilm.releasedEpisodes = inforFilm.releasedEpisodes + 1;
                filmDao.dbFilmContext.SaveChanges();
                return Json(new { Message = message, JsonRequestBehavior.AllowGet });
            }
            message = "Failed";
            return Json(new { Message = message });
        }
        public ActionResult CreateFilm()
        {
            try
            {

                var film = new Film();
                UpdateModel<Film>(film);
                var filmEp = new FilmEpisode();
                UpdateModel<FilmEpisode>(filmEp);
                film.createDate = DateTime.Now;
                film.createBy = "Hung";
                film.releasedEpisodes = 1;
                film.totalEpisodes = 1;
                var filmDao = new FilmDAO();
                filmDao.insertFilm(film);
                filmEp.Episode = 1;
                int res = new FilmEpisodeDAO().CreateFilmLe(filmEp);
                if (res > 0)
                {
                    return RedirectToAction("Films");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm mới không thành công");
                }
                return View("CreateFilmLe");
            }
            catch
            {
                //return View();
                //Console.WriteLine("Error");
                return View();
            }
        }

        public ActionResult FilmBoInformation(string id)
        {
            var filmDao = new FilmDAO();
            var feedbackDao = new FeedbackDAO();
            var filmEpDao = new FilmEpisodeDAO();
            var filmModel = filmDao.getFilmByID(id);
            var feedBackListModel = feedbackDao.listAll(filmModel.filmID);
            var FeedbackOfAcc = feedbackDao.listAccountFB(filmModel.filmID);
            ViewBag.filmDetail = filmModel;
            ViewBag.filmFeedBack = feedBackListModel;
            ViewBag.FeedBackOfAcc = FeedbackOfAcc;
            ViewBag.filmEpisode = filmEpDao.ListAllEpisodeRelease(filmModel.filmID);
            return View();

        }


        [HttpPost]
        public ActionResult UpdateEpisode(IList<FilmEpisode> LFE)
        {
            Console.WriteLine(LFE);
            foreach (var ep in LFE)
            {
                int res = new FilmEpisodeDAO().updateEpisode(ep);
                if (res > 0)
                {
                    continue;
                }
                else
                {
                    ModelState.AddModelError("", "Sửa không thành công");
                }
            }
            return RedirectToAction("FilmBoInformation");
        }



        public ActionResult FilmLeInformation(string id)
        {
            var filmDao = new FilmDAO();
            var epDao = new FilmEpisodeDAO();
            var feedbackDao = new FeedbackDAO();
            var filmModel = filmDao.getFilmByID(id);
            var Epfilm = epDao.getEpFilmLeByFilmID(id);
            var feedBackListModel = feedbackDao.listAll(filmModel.filmID);
            var FeedbackOfAcc = feedbackDao.listAccountFB(filmModel.filmID);
            ViewBag.filmDetail = filmModel;
            ViewBag.EpDetail = Epfilm;
            ViewBag.filmFeedBack = feedBackListModel;
            ViewBag.FeedBackOfAcc = FeedbackOfAcc;
            return View();

        }

        [HttpPost]
        public ActionResult UpdateFilmLe(string filmEpID, string filmID, string linkEpisode)
        {
            filmEpID = Request.Form["filmEpID"];
            filmID = Request.Form["filmID"];
            linkEpisode = Request.Form["linkEpisode"];
            int Episode = 1;
            int res = new FilmEpisodeDAO().updateEpisode2(filmEpID, filmID, filmID, Episode);
            if (res != 0)
            {
                ModelState.AddModelError("", "Sửa không thành công");
            }
            return RedirectToAction("FilmLeInformation");
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            try
            {
                var filmDao = new FilmDAO();
                filmDao.deleteByID(id);
                return RedirectToAction("Films");
            }
            catch
            {
                return View();
            }
        }
    }
}