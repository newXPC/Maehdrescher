using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maehdrescher_
{
    internal class Silo
    {
        public int aktuelleLadung = 0;
        public int kapazitaet { get; set;}
        public Silo(int Kapazitaet) 
        {
            kapazitaet = Kapazitaet;
        }

        public int getAktuelleLadung()
        {
            return aktuelleLadung;

        }

        public void addLadung(int ladung)
        {
            aktuelleLadung += ladung;
            Console.WriteLine($"Die aktuelle Ladung beträgt jetzt {aktuelleLadung}");

        }

        public void leeren()
        {
            aktuelleLadung = 0;
            Console.WriteLine("Das Silo wurde geleert");

        }

        public bool hatNochKapazitaet(int ladung)
        {
            if(ladung <= (kapazitaet - aktuelleLadung))
            {
                return true;
            }
            else
            {
                return false; 
            }

        }
    }

}
