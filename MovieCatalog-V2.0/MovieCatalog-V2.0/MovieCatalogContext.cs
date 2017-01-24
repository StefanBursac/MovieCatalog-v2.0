using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCatalog_V2._0
{
    public class MovieCatalogContext : DbContext
    {
        public MovieCatalogContext() : base("MovieCatalog")
        {

        }

        public DbSet<Movie> Movies { get; set; } 


    }
}
