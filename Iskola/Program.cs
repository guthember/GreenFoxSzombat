using System;
using System.Collections.Generic;

namespace Iskola
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Ember> emberek = new List<Ember>();

            Ember mari = new Ember("Mari", 46, "nő");
            emberek.Add(mari);
            Ember jancsi = new Ember();
            emberek.Add(jancsi);
            Tanulo janka = new Tanulo("Janka", 12, "nő", "Bartók");
            emberek.Add(janka);
            Tanulo tanulo = new Tanulo();
            emberek.Add(tanulo);
            Tanar sandor = new Tanar("Sándor", 35, "férfi", "testnevelés");
            emberek.Add(sandor);
            Tanar tanar = new Tanar();
            emberek.Add(tanar);
            Igazgato igazgato = new Igazgato();
            emberek.Add(igazgato);
            Igazgato zoli = new Igazgato("Kovács Zoltán", 46, "male", "Dobó István Gimnázium");
            emberek.Add(zoli);

            tanulo.Hianyzik(3);

            for (int i = 0; i < 5; i++)
            {
                zoli.Felvesz();
            }

            for (int i = 0; i < 3; i++)
            {
                igazgato.Felvesz();
            }

            foreach (Ember ember in emberek)
            {
                ember.Bemutatkozik();
                ember.getCel();
            }

            Evfolyam szuper = new Evfolyam("2019");
            szuper.hozzaAd(tanulo);
            szuper.hozzaAd(janka);
            szuper.hozzaAd(tanar);
            szuper.hozzaAd(sandor);
            szuper.Info();

            Console.ReadKey();
        }
    }
}
