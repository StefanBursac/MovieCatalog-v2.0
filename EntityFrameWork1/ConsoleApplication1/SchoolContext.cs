using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("School")
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }


    
    }
}
