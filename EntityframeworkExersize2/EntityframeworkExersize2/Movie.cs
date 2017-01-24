using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityframeworkExersize2
{
    public class Movie
    {   [Key]
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public string MovieDirector { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public char Foreign { get; set; }

    }
}
