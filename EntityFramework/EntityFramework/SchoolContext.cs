using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace EntityFramework
{

        public class SchoolContext : DbContext
        {
            public SchoolContext() : base("Smart School")
            {

            }

            public DbSet<Student> Students { get; set; }
            public DbSet<Standard> Standards { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Admin");

            modelBuilder.Entity<Student>().ToTable("StudentInfo");

        }


        }
    }

