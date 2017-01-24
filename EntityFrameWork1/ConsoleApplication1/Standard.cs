using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Standard
    {
        public Standard()
        {

        }

        public int StandardId { get; set; }
        public string StandardName { get; set; }

        public ICollection<Student> Student { get; set; }

    }
}
