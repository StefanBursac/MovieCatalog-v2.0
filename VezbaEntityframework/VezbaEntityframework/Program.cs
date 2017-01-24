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

            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<School>());


            School school = new School();

            Student student = new Student() { StudentName = "Stefan", StudentLastName = "Bursac" };
            Teacher teacher = new Teacher() { TeacherName = "Ivan" };

            school.Students.Add(student);
            school.Teachers.Add(teacher);
            school.SaveChanges();
        



        }
    }
}
