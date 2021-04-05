using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    interface IEuro
    {
        Devise ToEuros(MAD somme);
    }
}
