using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maehdrescher_
{
    abstract class Fahrzeug
    {
        public int betriebsstunden { get; set; }
        public int ps { get; set;}
        public string funktionsfaehig { get; set; }

        public Fahrzeug(int Betriebsstunden, int Ps, string Funktionsfaehig)
        {
            betriebsstunden = Betriebsstunden;
            ps = Ps;
            funktionsfaehig = Funktionsfaehig;
        }
    }
}
