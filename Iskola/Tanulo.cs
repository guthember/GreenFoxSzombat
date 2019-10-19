using System;
using System.Collections.Generic;
using System.Text;

namespace Iskola
{
    class Tanulo : Ember
    {
        string elozoIskola;
        int hianyzottNapok;

        public Tanulo() : base()
        { 
        }
        public Tanulo(string nev, int kor, string nem, string elozo = "Élet Iskolája") : base(nev, kor, nem)
        {
            this.elozoIskola = elozo;
            hianyzottNapok = 0;
        }

        public override void getCel()
        {
            Console.WriteLine("Túljutni az érettségin!");
        }

        public override void Bemutatkozik()
        {
            Console.WriteLine($"Szia, {nev} vagyok, {kor} éves {nem}, {elozoIskola} intézményből jöttem, {hianyzottNapok} napot hiányoztam eddig.");
        }

        public void Hianyzik(int napokSzama) 
        {
            hianyzottNapok += napokSzama;
        }
    
    }
}
