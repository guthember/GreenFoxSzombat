using System;
using System.Collections.Generic;
using System.Text;

namespace Iskola
{
    class Tanar : Ember
    {
        string tantargy;

        public Tanar() : base()
        { 
        }

        public Tanar(string nev, int kor, string nem, string tantargy = "mindenes") : base(nev, kor, nem)
        {
            this.tantargy = tantargy;
        }


        public override void getCel()
        {
            Console.WriteLine("Csillogó szemű nebulók edukálása!");
        }

        public override void Bemutatkozik()
        {
            Console.WriteLine($"Szia, {nev} vagyok, {kor} éves {nem} {tantargy} tanár.");
        }
    }
}
