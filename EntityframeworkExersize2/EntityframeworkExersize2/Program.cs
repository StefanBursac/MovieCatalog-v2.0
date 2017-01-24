using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityframeworkExersize2
{
    class Program
    {
        static void Main(string[] args)
        {

            MovieCatalog mc = new MovieCatalog();

            Movie m = new Movie() { MovieName = "Martian", MovieDirector = "Ridley Scot", Genre = "Sci-Fi, Drama", ReleaseDate = new DateTime(2016, 10, 10) };

            mc.Movies.Add(m);
            mc.SaveChanges();
            mc.Movies.Remove(m);
            mc.SaveChanges();
        
            

        }
    }
}
