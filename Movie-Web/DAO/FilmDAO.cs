using Movie_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_Web.DAO
{
    public class FilmDAO
    {
        public ModelFilm dbFilmContext = null;
        
        public FilmDAO()
        {
            dbFilmContext = new ModelFilm();
        }
        public List<Film> listAll(){
            return dbFilmContext.Films.ToList();
        }

        public List<Film> listFilmSlideDescendingbyCreateDate(int numberOfrecords)
        {
            return dbFilmContext.Films.OrderByDescending(x => x.createDate).Take(numberOfrecords).ToList();
        }

        public Film getFilmByID(string id)
        {
            return dbFilmContext.Films.FirstOrDefault(x => x.filmID == id);
        }
    }
}