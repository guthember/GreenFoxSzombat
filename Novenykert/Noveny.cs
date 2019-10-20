using System;
using System.Collections.Generic;
using System.Text;

namespace Novenykert
{
    class Noveny
    {
        protected string szin;
        protected double vizszint;

        /// <summary>
        /// Növény konstruktora
        /// </summary>
        /// <param name="szin">milyen szinű</param>
        public Noveny(string szin)
        {
            this.szin = szin;
            vizszint = 1.0;
        }

        /// <summary>
        /// Öntözés
        /// </summary>
        /// <param name="viz">Víz mennyisége</param>
        public virtual void Ontozes(double viz)
        {
            vizszint += viz;
                
        }

        /// <summary>
        /// Kell-e öntözni
        /// </summary>
        /// <returns>True -> Öntözni kell, False -> nem kell öntözni</returns>
        public virtual bool Szomjas() 
        {
            if (vizszint < 1) return true;
            else return false;
        }

        /// <summary>
        /// Visszaadj a státuszát string formájában
        /// </summary>
        /// <param name="tipus">Milyen típusú növény</param>
        /// <returns>szín és öntözésre szorul-e</returns>
        public virtual string Statusz(string tipus)
        {
            string tmp = $"A {szin} {tipus} ";
            if (Szomjas())
            {
                tmp += "öntözésre szorul.";
            }
            else
            {
                tmp += "nem szorul öntözésre.";
            }

            return tmp;
        }
    }
}
