using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VezbaEntityframework
{
    public class Student
    {

        public Student()
        {

        }
        public int StudentID { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public string StudentGender { get; set; }
        public int StudentAge { get; set; }
        public DateTime StudentBirthDate { get; set; }
        public string StudentNickName { get; set; }
        public string Age { get; set; }

    }
}
