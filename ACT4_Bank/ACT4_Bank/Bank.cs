using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT4_Bank
{
    internal class Bank
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private double _somme;

        public double Somme
        {
            get { return _somme; }
            set { _somme = value; }
        }


        public Bank(string name, double somme)
        {
            this._name = name;
            this._somme = somme;
        }

        public string afficheSold()
        {
            return _name + " à " + _somme + " dans son porte monnaie." ;
        }

        public void retrait(double montant)
        {
            Somme -= montant;
        }

        public void ajout(double montant)
        {
            Somme += montant;
        }



    }

}
