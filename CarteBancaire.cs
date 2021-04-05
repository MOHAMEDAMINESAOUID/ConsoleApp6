using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class CarteBancaire
    {
        static int Cpt;
        int CodeCarteBan;
        string TypeCarteBan;
        public CarteBancaire(string TypeCarte)
        {
            this.CodeCarteBan = ++Cpt;
            this.TypeCarteBan = TypeCarte;
        }
    }
}
