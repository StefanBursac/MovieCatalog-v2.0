using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCatalogV20
{
    public class MovieCatalogContext : DbContext
    {

        public MovieCatalogContext() : base ()
        {

        }   

       // public IEnumerable Local { get; set; }
        public DbSet<Movie> Movies { get; set; }

        
    }
}
