using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using Movie_Web.Models;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace Movie_Web.DAO
{
    public class FilmEpisodeDAO
    {
        public ModelFilm dbFilmContext = null;

        public FilmEpisodeDAO()
        {
            dbFilmContext = new ModelFilm();
        }

        public int CreateFilmLe(FilmEpisode filmepLe)
        {
            var filmID = new SqlParameter("@filmID", filmepLe.filmID);
            var Episode = new SqlParameter("@Episode", filmepLe.Episode);
            var linkEpisode = new SqlParameter("@linkEpisode", filmepLe.linkEpisode);
            int res = dbFilmContext.Database.ExecuteSqlCommand("exec AddFilmEpisode @filmID , @Episode , @linkEpisode", filmID, Episode, linkEpisode);
            return res;
        }
        public int CreateTapPhim(FilmEpisode filmEp)
        {
            var filmID = new SqlParameter("@filmID", filmEp.filmID);
            var Episode = new SqlParameter("@Episode", filmEp.Episode);
            var linkEpisode = new SqlParameter("@linkEpisode", filmEp.linkEpisode);
            int res = dbFilmContext.Database.ExecuteSqlCommand("exec AddFilmEpisode @filmID , @Episode , @linkEpisode", filmID, Episode, linkEpisode);
            return res;
        }

        public List<FilmEpisode> ListAllEpisodeRelease(string id)
        {
            return dbFilmContext.FilmEpisodes.Where(x => x.filmID == id).OrderBy(x => x.Episode).ToList();
        }

        public int updateEpisode(FilmEpisode filmEp)
        {
            var filmID = new SqlParameter("@filmID", filmEp.filmID);
            var Episode = new SqlParameter("@Episode", filmEp.Episode);
            var linkEpisode = new SqlParameter("@linkEpisode", filmEp.linkEpisode);
            int res = dbFilmContext.Database.ExecuteSqlCommand("exec UpdateFilmEpisode @filmID , @Episode , @linkEpisode", filmID, Episode, linkEpisode);
            return res;
        }

        public EpisodeFilmCreateByProc getEpisode(string id, int episode)
        {
            var ep = new EpisodeFilmCreateByProc();
            string CS = ConfigurationManager.ConnectionStrings["ModelFilm"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("exec selectEpisodeFilm \'" + id + "\' , " + episode, con);
                cmd.CommandType = CommandType.Text;
                con.Open();

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {

                    ep.filmID = rdr["filmID"].ToString().Trim();
                    ep.nameFilm = rdr["nameFilm"].ToString();
                    ep.nameEngFilm = rdr["nameEngFilm"].ToString();
                    ep.contentText = rdr["contentText"].ToString();
                    ep.linkBgImage = rdr["linkBgImage"].ToString();
                    ep.releasedEpisodes = Convert.ToInt32(rdr["releasedEpisodes"]);
                    ep.totalEpisodes = Convert.ToInt32(rdr["totalEpisodes"]);
                    ep.Episode = Convert.ToInt32(rdr["Episode"]);
                    ep.linkEpisode = rdr["linkEpisode"].ToString();
                }
            }
            return ep;
        }
    }
}