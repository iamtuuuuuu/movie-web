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
            ViewBag.listAcc = accountDao.listAccountDescendingbyID();

            return View();
        }

        public ActionResult Films()
        {
            return View();
        }

        public ActionResult Summary()
        {
            return View();
        }
    }
}