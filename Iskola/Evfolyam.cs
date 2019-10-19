using System;
using System.Collections.Generic;
using System.Text;

namespace Iskola
{
    class Evfolyam
    {
        string kezdesEve;
        List<Tanulo> tanulok;
        List<Tanar> tanarok;


        public Evfolyam(string kezdesEve)
        {
            tanulok = new List<Tanulo>();
            tanarok = new List<Tanar>();
            this.kezdesEve = kezdesEve;
        }


        public void Info()
        {
            // Az évfolyam kezdesEve-ben kezdett, van tanulok.size() tanulója és tanarok.size() tanár tanítja őket."
            Console.WriteLine($"Az évfolyam {kezdesEve}-ben kezdett, van {tanulok.Count} tanulója és {tanarok.Count} tanár tanítja őket.");
        }

        public void hozzaAd(Tanulo tanulo)
        {
            tanulok.Add(tanulo);
        }

        public void hozzaAd(Tanar tanar)
        {
            tanarok.Add(tanar);
        }
    }
}
