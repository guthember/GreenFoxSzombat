using System;
using System.Collections.Generic;
using System.Text;

namespace NineExample
{
    class PosztIt
    {
        ConsoleColor hatterSzin;
        string szoveg;
        ConsoleColor szovegSzin;

        /// <summary>
        /// PosztIt konstruktor
        /// </summary>
        /// <param name="bg">háttérszín</param>
        /// <param name="fg">szövegszín</param>
        /// <param name="sz">amit kiír szöveg</param>
        public PosztIt(ConsoleColor bg, ConsoleColor fg, string sz)
        {
            hatterSzin = bg;
            szovegSzin = fg;
            szoveg = sz;

        }

        /// <summary>
        /// Kiírja a szöveget a képernyőre a megadott szinekkel
        /// </summary>
        public void Kiir()
        {
            ConsoleColor originFg = Console.ForegroundColor;
            ConsoleColor originBg = Console.BackgroundColor;
            Console.ForegroundColor = szovegSzin;
            Console.BackgroundColor = hatterSzin;
            Console.WriteLine(szoveg);
            Console.ForegroundColor = originFg;
            Console.BackgroundColor = originBg;
        }
    }
}
