using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Movie_Web.DAO;
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
            foreach( var acc in lstAcc)
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

        public ActionResult Summary()
        {   
            return View();
        }
    }
}