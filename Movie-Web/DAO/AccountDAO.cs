using Movie_Web.Common;
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
        public String Login(string email, string password)
        {
            var result = db.Accounts.FirstOrDefault(x => x.email == email && x.passwordAcc == password);
            return result.accountID;
        }
        public int Insert(Account acc)
        {
            var passHash = Encryptor.MD5Hash(acc.passwordAcc);
            acc.passwordAcc = passHash;
            db.Accounts.Add(acc);
            db.SaveChanges();
            return 1;
        }

    }
}