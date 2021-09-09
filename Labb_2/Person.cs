using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2
{
    public abstract class Person : IPerson
    {
        public List<Kurs> studentKurser { get; set; }

        public List<Laboration> studentLaborationer { get; set; }
        public string Namn { get; set; }
        public string Personnummer { get; set; }
        public string ID { get; set; }
        public Person()
        {
            studentKurser = new List<Kurs>();
            studentLaborationer = new List<Laboration>();

        }
    }
}
