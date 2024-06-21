using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maehdrescher_
{
    internal class Maehdrescher : Fahrzeug
    {
        public int getreideTankInhalt;

        public Maehdrescher(int Betriebsstunden, int Ps, string Funktionsfaehig, int GetreideTankInhalt)
            :base(Betriebsstunden, Ps, Funktionsfaehig)
        {
            getreideTankInhalt = GetreideTankInhalt;
        }
        public void ernteBisVoll()
        {
            getreideTankInhalt = 10000;
        }

        public void fuelleSilo(Silo silo)
        {
            while(silo.hatNochKapazitaet(100) && getreideTankInhalt > 0)
            {
                silo.addLadung(100);
                getreideTankInhalt -= 100;
            }
            Console.WriteLine("Das Silo ist befüllt.");
        }
    }
}
