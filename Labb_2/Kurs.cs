using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2
{
    public class Kurs : IKurs
    {
        public string kursID { get; set; }
        public string kursNamn { get; set; }
        
        public List<Student> studenter { get; set; }
        public List<Lärare> lärare { get; set; }
        public List<Laboration> laborationer { get; set; }

        public Kurs()
        {
            studenter = new List<Student>();
            lärare = new List<Lärare>();
            laborationer = new List<Laboration>();
        }
    }
}
