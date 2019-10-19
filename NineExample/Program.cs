using System;

namespace NineExample
{
    class Program
    {
        static void Main(string[] args)
        {
            PosztIt elso = new PosztIt(ConsoleColor.Yellow, ConsoleColor.Blue, "Első ötlet");
            PosztIt masodik = new PosztIt(ConsoleColor.Magenta, ConsoleColor.Black, "Hurrá");
            PosztIt harmadik = new PosztIt(ConsoleColor.DarkGreen, ConsoleColor.Gray, "Szuper!");

            elso.Kiir();
            masodik.Kiir();
            harmadik.Kiir();

            Console.ReadKey();
        }
    }
}
