using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelFilm.Models;

namespace ModelFilm.DAO
{
    public class FilmDAO
    {
        public FilmDBContext dBContext = null;

        public FilmDAO()
        {
            dBContext = new FilmDBContext();

        }
        public List<Film> ListAll()
        {
            {
                return dBContext.Films.ToList();
            }
        }
    }
}
