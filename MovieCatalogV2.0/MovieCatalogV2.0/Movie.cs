using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCatalogV20
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public Genre MovieGenre { get; set; }
        public string MovieDirector { get; set; }
        public DateTime? ReleaseDate { get; set; }

        public enum Genre { Action,Drama,Comedy,SciFi,Fantasy};
    }
}
