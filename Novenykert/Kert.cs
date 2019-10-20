using System;
using System.Collections.Generic;
using System.Text;

namespace Novenykert
{
    class Kert
    {
        List<Virag> viragok;
        List<Fa> fak;

        int viragokSzama;
        int fakSzama;

        /// <summary>
        /// Kert konstruktora
        /// </summary>
        public Kert()
        {
            viragok = new List<Virag>();
            fak = new List<Fa>();
            viragokSzama = 0;
            fakSzama = 0;
        }

        /// <summary>
        /// Egy növényt ad a kerthez
        /// </summary>
        /// <param name="v">"virag" tipusú</param>
        public void Telepit(Virag v)
        {
            viragok.Add(v);
            viragokSzama++;
        }

        /// <summary>
        /// Egy növényt ad a kerthez
        /// </summary>
        /// <param name="f">"fa" tipusú növény</param>
        public void Telepit(Fa f) 
        {
            fak.Add(f);
            fakSzama++;
        }

        /// <summary>
        /// Meghatározza a szomjas növények számát
        /// </summary>
        /// <returns></returns>
        int SzomjasSzam() 
        {
            int ontozni = 0;

            foreach (var v in viragok)
            {
                if (v.Szomjas()) ontozni++;
            }

            foreach (var f in fak)
            {
                if (f.Szomjas()) ontozni++;
            }

            return ontozni;
        }

        /// <summary>
        /// Megöntözi a kertet
        /// </summary>
        /// <param name="viz">vízemnnyiség</param>
        public void Ontozes(double viz)
        {
            Console.WriteLine($"\nÖntözés {viz} liter vízzel");
            int mennyi = SzomjasSzam();
            if (mennyi != 0)
            {
                double vizMennyiseg = viz / mennyi;

                foreach (var v in viragok)
                {
                    if (v.Szomjas()) v.Ontozes(vizMennyiseg);
                }

                foreach (var f in fak)
                {
                    if (f.Szomjas()) f.Ontozes(vizMennyiseg);
                } 
            }
            Statusz();
        }

        /// <summary>
        /// Kiírja a kert állapotát
        /// </summary>
        public void Statusz()
        {
            if (viragokSzama > 0)
            {
                foreach (var v in viragok)
                {
                    Console.WriteLine(v.Statusz());
                }
            }

            if (fakSzama > 0)
            {
                foreach (var f in fak)
                {
                    Console.WriteLine(f.Statusz());
                }
            }
        }
    }
}
