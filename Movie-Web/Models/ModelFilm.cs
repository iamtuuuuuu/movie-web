using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Movie_Web.Models
{
    public partial class ModelFilm : DbContext
    {
        public ModelFilm()
            : base("name=ModelFilm")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<FilmEpisode> FilmEpisodes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.accountID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.passwordAcc)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.avartar)
                .IsUnicode(false);

            modelBuilder.Entity<Feedback>()
                .Property(e => e.feedbackID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Feedback>()
                .Property(e => e.filmID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Feedback>()
                .Property(e => e.accountID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Film>()
                .Property(e => e.filmID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Film>()
                .Property(e => e.nameEngFilm)
                .IsUnicode(false);

            modelBuilder.Entity<Film>()
                .Property(e => e.linkImgAvt)
                .IsUnicode(false);

            modelBuilder.Entity<Film>()
                .Property(e => e.linkImgDes)
                .IsUnicode(false);

            modelBuilder.Entity<Film>()
                .Property(e => e.linkBgImage)
                .IsUnicode(false);

            modelBuilder.Entity<Film>()
                .Property(e => e.linkTrailer)
                .IsUnicode(false);

            modelBuilder.Entity<Film>()
                .Property(e => e.star)
                .IsUnicode(false);

            modelBuilder.Entity<FilmEpisode>()
                .Property(e => e.filmEpID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FilmEpisode>()
                .Property(e => e.filmID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FilmEpisode>()
                .Property(e => e.linkEpisode)
                .IsUnicode(false);
        }
    }
}
