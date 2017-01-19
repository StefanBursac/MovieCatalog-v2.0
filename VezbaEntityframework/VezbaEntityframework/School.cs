using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VezbaEntityframework
{
    public class School : DbContext
    {

        public  School() : base("Skola")
        {

        }

        public DbSet<Student> Students { get; set; }



    }
}
