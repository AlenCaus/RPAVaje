using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Vaja1
{
    public class Sporocila
    {
        public string Posiljatelj { get ; set ; }
        public string Prejemnik { get; set; }
        public string Zadeva { get; set; }
        public string Vsebina { get; set; }

        public override string ToString()
        {
            return $"{Posiljatelj} -> {Prejemnik} | {Zadeva}";
        }

    }
}
