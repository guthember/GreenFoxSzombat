using System;
using System.Collections.Generic;
using System.Text;

namespace TenExample
{
    class Allat
    {
        int hungry;
        int thirsty;

        public Allat() 
        {
            hungry = 50;
            thirsty = 50;
        }

        public void Eszik() 
        {
            if( hungry > 0) hungry--;
        }

        public void Iszik()
        {
            if (thirsty > 0) thirsty--;
        }

        public void Jatszik()
        {
            thirsty++;
            hungry++;
        }

        public override string ToString()
        {
            return $"Állapotom: {hungry} éhes, {thirsty} szomjas";
        }
    }
}
