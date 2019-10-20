using System;
using System.Collections.Generic;
using System.Text;

namespace Novenykert
{
    class Fa : Noveny
    {
        public Fa(string szin) : base(szin)
        { 
        }

        public override void Ontozes(double viz)
        {
            vizszint += (viz * 0.4);
        }

        public override bool Szomjas()
        {
            if (vizszint < 10) return true;
            else return false;
        }

        public override string Statusz(string tipus = "Fa")
        {
            return base.Statusz(tipus);
        }
    }
}
