using System;

namespace TenExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Allat kutya = new Allat();
            Console.WriteLine(kutya.ToString());
            kutya.Jatszik();
            Console.WriteLine(kutya.ToString());


            Console.ReadKey();

        }
    }
}
