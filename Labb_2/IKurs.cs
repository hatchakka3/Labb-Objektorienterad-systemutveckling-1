using System.Collections.Generic;

namespace Labb_2
{
    public interface IKurs
    {
        string kursID { get; set; }
        string kursNamn { get; set; }
        List<Laboration> laborationer { get; set; }
        List<Lärare> lärare { get; set; }
        List<Student> studenter { get; set; }
    }
}