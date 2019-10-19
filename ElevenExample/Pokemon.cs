using System;
using System.Collections.Generic;
using System.Text;

namespace ElevenExample
{
    class Pokemon
    {
        string nev;
        string tipus;
        string ellenfel;

        public Pokemon(string nev, string tipus, string ellenfel)
        {
            this.nev = nev;
            this.tipus = tipus;
            this.ellenfel = ellenfel;
        }

        public string Nev { get => nev; }

        public bool hatasosEllene(Pokemon masik)
        {
            return this.ellenfel.Equals(masik.tipus);
        }
    }
}
