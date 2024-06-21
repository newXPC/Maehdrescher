using System;

namespace Maehdrescher_
{

    public class Ernte
    {
        static void Main()
        {
            Silo silo = new Silo(10000);
            Maehdrescher maehdrescher = new Maehdrescher(0, 300, "ja", 0);
            maehdrescher.ernteBisVoll();
            maehdrescher.fuelleSilo(silo);
            silo.leeren();
            
        }

    }
}