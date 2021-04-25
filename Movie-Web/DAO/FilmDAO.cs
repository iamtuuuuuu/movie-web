using Movie_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        public List<Film> listAllAdmin()
        {
            return dbFilmContext.Films.OrderByDescending(x => x.createDate).ToList();
        }

        public List<Film> listFilmSlideDescendingbyCreateDate(int numberOfrecords)
        {
            return dbFilmContext.Films.OrderByDescending(x => x.createDate).Take(numberOfrecords).ToList();
        }

        public Film getFilmByID(string id)
        {
            return dbFilmContext.Films.FirstOrDefault(x => x.filmID == id);
        }

        public void deleteByID(string id)
        {
            Film deleteFilm = dbFilmContext.Films.Find(id);
            if(deleteFilm != null)
            {

                dbFilmContext.Films.Remove(deleteFilm);
                dbFilmContext.SaveChanges();
            }
        }

        public void insertFilm(Film film)
        {
            dbFilmContext.Films.Add(film);
            dbFilmContext.SaveChanges();
        }

        

        //public void replaceFilm(Film film, Film oldFilm)
        //{
        //    var propertyInfos = film.GetType().GetProperties();
        //    foreach (PropertyInfo pInfo in propertyInfos)
        //    {
        //        string propertyName = pInfo.Name; //gets the name of the property
        //        pInfo.GetValue(oldFilm, null) = pInfo.GetValue(film, null);
        //    }
        //}

    }
}