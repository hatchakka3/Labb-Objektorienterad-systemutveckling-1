using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2
{
    public class Student : Person, IStudent
    {
        public string Betyg { get; set; }
        public Student()
        {

        }
    }
}
