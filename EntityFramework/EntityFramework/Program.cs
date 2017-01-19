using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {

                SchoolContext s = new SchoolContext();
            
                Student stud = new Student() { StudentName = "nafets", DateOfBirth = new DateTime (1985,2,15) };

                s.Students.Add(stud);
                s.SaveChanges();
            

        }
    }
}
