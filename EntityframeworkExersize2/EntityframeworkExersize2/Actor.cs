using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityframeworkExersize2
{
    public class Actor
    {
        [Key]
        public int ActorID { get; set; }

        public string ActorName { get; set; }

        public string ActorLastName { get; set; }

        public string Glumac { get; set; }

    }
}
