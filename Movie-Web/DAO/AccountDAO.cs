using Movie_Web.Common;
using Movie_Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        public List<Account> listAccountDescendingbyID()
        {
            var results = db.Accounts.OrderByDescending(x => x.accountID).ToList();
            //foreach( var result in results)
            //{
            //    if (result.roleAcc == false)
            //    {
            //        result.roleAcc = "Admin";
            //    }
            //    else
            //    {
            //        result.roleAcc = "User";
            //    }
            //}
            return results;
        }
        public String Login(string email, string password)
        {
            var result = db.Accounts.FirstOrDefault(x => x.email == email && x.passwordAcc == password);
            Console.WriteLine(result);
            if (result == null)
            {
                return "";
            }
            return result.accountID;
        }
        public void Insert(string email, string userName, string password)
        {
            
            object[]  param= 
                {
                new SqlParameter("@email", email),
                new SqlParameter("@userName", userName),
                new SqlParameter("@password", password)

            };
            db.Database.ExecuteSqlCommand("exec InsertAccount @email, @userName, @password", param);
            
        }

    }
}