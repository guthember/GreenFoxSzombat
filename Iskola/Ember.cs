using System;
using System.Collections.Generic;
using System.Text;

namespace Iskola
{
    class Ember
    {
        //protected enum Nemek  { nő, férfi};

        string nev; 
        int kor;
        string nem;

        public Ember(string nev = "Anonim Jancsi", int kor = 30, string nem = "férfi")
        {
            this.nev = nev;
            this.kor = kor;
            this.nem = nem;
        }

        public void Bemutatkozik()
        {
            Console.WriteLine($"Szia, {nev} vagyok, {kor} éves {nem}." );
        }

        public void getCel()
        {
            Console.WriteLine("Élj a mának!");
        }
    }
}
