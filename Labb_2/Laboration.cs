using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2
{
    public class Laboration : ILaboration
    {
        public string LabbNamn { get; set; }
        public string LabbID { get; set; }
        public Kurs Kurs { get; set; }

        public List<Student> labbStudenter { get; set; }

        public Laboration(string labbNamn, string labbID)
        {
            LabbNamn = labbNamn;
            LabbID = labbID;
            labbStudenter = new List<Student>();
        }
    }
}
