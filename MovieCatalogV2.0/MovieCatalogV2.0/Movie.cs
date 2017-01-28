using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCatalogV2._0
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public enum MovieGenre { Action, Drama, Comedy, SciFi };
        public MovieGenre Genre {get; set;}
        public string MovieDirector { get; set; }
        public DateTime? ReleaseDate { get; set; }
    }
}
