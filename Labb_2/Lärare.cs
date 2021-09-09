using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2
{
    public class Lärare : Person, ILärare
    {
        public string Signatur { get; set; }
        public Lärare(string namn, string personnummer, string lärarID, string signatur)
        {
            this.Namn = namn;
            this.Personnummer = personnummer;
            this.ID = lärarID;
            Signatur = signatur;
        }
    }
}
