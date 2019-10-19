using System;
using System.Collections.Generic;
using System.Text;

namespace Iskola
{
    class Ember
    {
        //protected enum Nemek  { nő, férfi};

        protected string nev; 
        protected int kor;
        protected string nem;


        public Ember()
        {
            nev = "Anonim Jancsi";
            kor = 30;
            nem = "férfi";
        }
        public Ember(string nev, int kor, string nem)
        {
            this.nev = nev;
            this.kor = kor;
            this.nem = nem;
        }

        public virtual void Bemutatkozik()
        {
            Console.WriteLine($"Szia, {nev} vagyok, {kor} éves {nem}." );
        }

        public virtual void getCel()
        {
            Console.WriteLine("Élj a mának!");
        }
    }
}
