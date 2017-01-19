using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityframeworkExersize2
{
    public class MovieCatalog : DbContext
    {

        public MovieCatalog() : base ("MovieCatalog")
        {

        }


        public DbSet<Movie> Movies { get; set; }

    }
}
