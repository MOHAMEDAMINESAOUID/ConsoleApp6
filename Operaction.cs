using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ConsoleApp6
{
    class Operaction
    {
 
            public static int Cpt = 0;
            public int NumOp;
            public DateTime DateOp;
            public string Libelle;
            public MAD Montant;
            public Operaction(string libelle, MAD montant)
            {
                this.NumOp = ++Cpt;
                this.DateOp = DateTime.Now;
                this.Libelle = libelle;
                this.Montant = montant;
            }

            public void Afficher()
            {
                Console.Write($"Operaction :  {DateOp.ToShortDateString()} | N° {NumOp} |{Libelle}  ");
                Montant.Afficher();
            }
        }
    }
