using System;

namespace Novenykert
{
    class Program
    {
        static void Main(string[] args)
        {
            Virag sarga = new Virag("sárga");
            Virag kek = new Virag("kék");
            Fa lila = new Fa("lila");
            Fa piros = new Fa("piros");
            
            Kert bpFuveszkert = new Kert();
            
            bpFuveszkert.Telepit(sarga);
            bpFuveszkert.Telepit(kek);
            bpFuveszkert.Telepit(lila);
            bpFuveszkert.Telepit(piros);
            
            bpFuveszkert.Statusz();
            bpFuveszkert.Ontozes(40);
            bpFuveszkert.Ontozes(70);

            Console.ReadKey();
        }
    }
}
