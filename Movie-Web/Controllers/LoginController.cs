using Movie_Web.Common;
using Movie_Web.DAO;
using Movie_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movie_Web.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Login(LoginModel model)
        {
           if(ModelState.IsValid)
            {
                var accountDao = new AccountDAO();
                var result = accountDao.Login(model.Email, Encryptor.MD5Hash(model.Password));
                if (result)
                {
                    
                    // return admin
                    return RedirectToAction("About", "Home");
                }
                else
                {
                    /* if (accountDao.GetAccountByID(model).roleAcc == true)*/
                    //return index
                    ModelState.AddModelError("", "Wrong password or Username");
                    /* else
                         return RedirectToAction("Detail", "Home");*/
                }
            }
            return View();
        }

        public ActionResult SignUp(Account acc)
        {
            var accountDao = new AccountDAO();
            accountDao.Insert(acc);
            return RedirectToAction("Index");
        }
        
    }
}