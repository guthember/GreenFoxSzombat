using System;
using System.Collections.Generic;

namespace GreenFoxSzombat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nevek = new List<string>();
            Console.WriteLine($"A lista elemszáma: {nevek.Count}");

            nevek.Add("János");

            if (nevek.Count > 0)
            {
                Console.WriteLine("Nem üres a lista");
            }
            else
            {
                Console.WriteLine("Üres a lista");
            }

            nevek.Add("Vilmos");
            nevek.Add("Amanda");

            Console.WriteLine($"A lista elemszáma: {nevek.Count}");

            Console.WriteLine($"A lista harmadik eleme: {nevek[2]}");

            Console.WriteLine("Az elemek:");
            foreach (var item in nevek)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
