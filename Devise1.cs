using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Devise1:IEuro,IDollars
    {
        double Valeur;
        double ValEuro = 10.66, ValIDollars = 9.06;

        public Devise1(double ValDev)
        {
            this.Valeur = ValDev
        }

        public Devise1 ToDollars(MAD somme) 
            return new Devise1(somme.Conversion(ValDollars));
    public Devise1 ToEuros(MAD somme)
            return new Devise1(somme.Conversion(ValEuro));

    }
}
