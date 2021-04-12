using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Movie_Web.Models;

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

       /* public List<Feedback> listAccountFB(string id)
        {

            return dbFilmContext.Database.ExecuteSqlCommand("selectFBACOfFilm @id",id);

        }*/
    }
}