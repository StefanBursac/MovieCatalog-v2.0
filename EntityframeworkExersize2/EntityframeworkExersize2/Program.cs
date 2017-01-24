using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityframeworkExersize2
{
    class Program
    {
        static void Main(string[] args)
        {

            Database.SetInitializer<MovieCatalog>(new DropCreateDatabaseIfModelChanges<MovieCatalog>());

            MovieCatalog mc = new MovieCatalog();

            Movie m = new Movie() { MovieName = "Dark Knight", MovieDirector = "Ridley Scot", Genre = "Sci-Fi, Drama", ReleaseDate = new DateTime(2016, 10, 10) };
            Actor a = new Actor() { ActorName = "Christian Bale" };

            mc.Movies.Add(m);
            mc.Actors.Add(a);
            mc.SaveChanges();
        }
    }
}