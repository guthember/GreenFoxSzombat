using System;
using System.Collections.Generic;
using System.Text;

namespace Novenykert
{
    class Virag : Noveny
    {
        public Virag(string szin) : base(szin)
        { 
        }

        public override void Ontozes(double viz)
        {
            vizszint += (viz * 0.75);
        }

        public override bool Szomjas()
        {
            if (vizszint < 5) return true;
            else return false;
        }


        public override string Statusz(string tipus = "Virag")
        {
            return base.Statusz(tipus);
        }
        
    }
}
