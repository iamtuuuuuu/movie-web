using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using Movie_Web.Models;
using System.Data.SqlClient;
using System.Data;
namespace Movie_Web.DAO
{
    public class FeedbackDAO
    {
        public ModelFilm dbFilmContext = null;

        public FeedbackDAO()
        {
            dbFilmContext = new ModelFilm();
        }
        public List<Feedback> listAll(string id)
        {
            return dbFilmContext.Feedbacks.Where(
                x => x.filmID == id
            ).ToList();
        }

        public void Insert(string filmID, string accountID, string cmt, DateTime sentDate)
        {

            object[] param =
                {
                new SqlParameter("@filmID", filmID),
                new SqlParameter("@accountID", accountID),
                new SqlParameter("@cmt", cmt),
                new SqlParameter("@sentDate", sentDate)

            };
            dbFilmContext.Database.ExecuteSqlCommand("exec AddFeedback @filmID, @accountID, @cmt, @sentDate", param);

        }

        public List<int> getQuantityCommentOfYears()
        {
            List<int> res = new List<int>();
            var Fromyear1 = new SqlParameter("@fromYear", "2019-01-01");
            var Toyear1 = new SqlParameter("@endYear", "2019-12-31");
            var Fromyear2 = new SqlParameter("@fromYear", "2020-01-01");
            var Toyear2 = new SqlParameter("@endYear", "2020-12-31");
            var Fromyear3 = new SqlParameter("@fromYear", "2021-01-01");
            var Toyear3 = new SqlParameter("@endYear", "2021-12-31");
            var quantity1 = dbFilmContext.Database.ExecuteSqlCommand("exec getQuantityCM @FromYear, @EndYear ", Fromyear1, Toyear1);
            var quantity2 = dbFilmContext.Database.ExecuteSqlCommand("exec getQuantityCM @fromYear, @endYear ", Fromyear2, Toyear2);
            var quantity3 = dbFilmContext.Database.ExecuteSqlCommand("exec getQuantityCM @fromYear, @endYear ", Fromyear3, Toyear3);
            res.Add(quantity1);
            res.Add(quantity2);
            res.Add(quantity3);
            return res;
        }

       

        public List<Comment> listAccountFB(string id)
        {

            List<Comment> commentList = new List<Comment>();
            string CS = ConfigurationManager.ConnectionStrings["ModelFilm"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("exec selectFBACOfFilm \'" + id + "\'", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                // dung cai nay dc k

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    var cmt = new Comment();

                    cmt.username = rdr["username"].ToString();
                    cmt.avartar = rdr["avartar"].ToString();
                    cmt.cmt = rdr["cmt"].ToString();
                    cmt.sentDate = rdr["sentDate"].ToString();

                    //string dateSent = rdr["sentDate"].ToString();
                    //Console.WriteLine(dateSent);
                    //cmt.sentDate = DateTime.ParseExact(dateSent, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

                    commentList.Add(cmt);
                }
            }
            Console.WriteLine(commentList);
            return commentList;
        }
    }
}