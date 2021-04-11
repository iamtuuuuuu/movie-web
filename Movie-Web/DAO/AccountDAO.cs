using Movie_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_Web.DAO
{
    public class AccountDAO
    {
        ModelFilm db = null;
        public AccountDAO()
        {
            db = new ModelFilm();
        }
        public Account GetAccountByID(string id)
        {
            return db.Accounts.FirstOrDefault(x => x.accountID == id);
        }
        
    }
}