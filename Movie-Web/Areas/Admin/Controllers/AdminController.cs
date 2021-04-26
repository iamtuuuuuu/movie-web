using System;
using System.Collections.Generic;
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

        //public ActionResult Delete()
        //{
        //    return View();
        //}

        public ActionResult Summary()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Films(Film newFilm)
        {
            try
            {
                var filmDao = new FilmDAO();
                filmDao.insertFilm(newFilm);
                return RedirectToAction("Films");
            }
            catch
            {
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