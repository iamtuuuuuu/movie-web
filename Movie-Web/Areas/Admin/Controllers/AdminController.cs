using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Movie_Web.DAO;
using Movie_Web.Models;
namespace Movie_Web.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin/Admin
        public ActionResult Index()
        {
            return View();
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
            ViewBag.filmDetail = filmDao.getFilmByID(id);
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

        public ActionResult Summary()
        {
            return View();
        }

        public ActionResult CreateFilmLe()
        {
            //ViewBag.movive = value;
            return View();
        }

        public ActionResult CreateFilmBo()
        {
            //ViewBag.movive = value;
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
                Console.WriteLine("Error");
                return View();
            }
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