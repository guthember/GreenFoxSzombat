using System;
using System.Collections.Generic;
using System.Text;

namespace Iskola
{
    class Igazgato : Ember
    {
        string iskola;
        int felvettTanulok;

        public Igazgato() : base()
        { 
        }
        public Igazgato(string nev, int kor, string nem, string iskola = "Utca") : base(nev, kor, nem)
        {
            this.iskola = iskola;
            felvettTanulok = 0;
        }

        public void Felvesz()
        {
            felvettTanulok++;
        }

        public override void Bemutatkozik()
        {
            // "Szia, nev vagyok, kor éves nem a(z) iskola képviselője és már felvettTanulok tanulót felvételiztettem.";
            Console.WriteLine($"Szia, {nev} vagyok, {kor} éves {nem} a(z) {iskola}  képviselője már {felvettTanulok} tanulót felvételiztettem.");
        }

        public override void getCel()
        {
            Console.WriteLine("Csillogó szemű nebulók felvétele az iskolába!");
        }
    }
}
