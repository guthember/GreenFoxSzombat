using System;

namespace ExampleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo budapestZoo = new Zoo();

            budapestZoo.NovelEgyedszam();

            if (budapestZoo is Zoo)
            {
                Console.WriteLine("Zoo osztály");
            }

            Console.ReadKey();
        }
    }
}
