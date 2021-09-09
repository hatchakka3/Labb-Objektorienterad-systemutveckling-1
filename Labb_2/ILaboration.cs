using System.Collections.Generic;

namespace Labb_2
{
    public interface ILaboration
    {
        Kurs Kurs { get; set; }
        string LabbID { get; set; }
        string LabbNamn { get; set; }
        List<Student> labbStudenter { get; set; }
    }
}