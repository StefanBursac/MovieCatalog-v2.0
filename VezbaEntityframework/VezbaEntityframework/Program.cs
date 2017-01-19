using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace VezbaEntityframework
{
    class Program
    {
        static void Main(string[] args)
        {
            School school = new School();

            Student student = new Student() { StudentFirstName = "Stefan", StudentLastName = "Bursac", StudentGender = "Male", StudentAge = 31, StudentBirthDate = new DateTime(1985, 2, 15) };

            school.Students.Add(student);
            school.SaveChanges();


        }
    }
}
