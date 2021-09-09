using System.Collections.Generic;

namespace Labb_2
{
    public interface IPerson
    {
        string ID { get; set; }
        string Namn { get; set; }
        string Personnummer { get; set; }
        List<Kurs> studentKurser { get; set; }
        List<Laboration> studentLaborationer { get; set; }
    }
}