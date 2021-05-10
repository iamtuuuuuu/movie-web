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

        public List<ChartCM> getQuantityCommentOfYears()
        {
            List<ChartCM> res = new List<ChartCM>();
            string CS = ConfigurationManager.ConnectionStrings["ModelFilm"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                string queryString = "select datepart (yyyy,[sentDate]) as[year],count(cmt) as SoLuong from Feedback group by DATEPART(yyyy,[sentDate])";
                SqlCommand cmd = new SqlCommand(queryString, con);
                con.Open();
                // dung cai nay dc k
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    var chartcmt = new ChartCM();
                    chartcmt.year = rdr["year"].ToString();
                    chartcmt.quantityCM = Int32.Parse(rdr["SoLuong"].ToString());
                    //cmt.sentDate = rdr["sentDate"].ToString();
                    res.Add(chartcmt);
                }
            }
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