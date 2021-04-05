using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp6
{
    class Appbank
    {
        Client client1, client2, cl1, cl2;
        Compte compte1, compte2;
        MAD MAD1, MAD2;
        CompteEpange compteepargne1;
        Operaction op1, op2;
        int CaseSwitch;
        double valeur1, valeur2;
        public void AppTest()
        {
            do
            {
                Console.WriteLine("\n\t\t\t   ___________________________________");
                Console.WriteLine("\n\t\t\t  /             Menu                 / ");
                Console.WriteLine("\n\t\t\t /              Principal           /   ");
                Console.WriteLine("\n\t\t\t/_____________ __________________ _/\n\n");
                Console.WriteLine("\t1- Ajouter Client. ");
                Console.WriteLine("\t2- Ajouter Compte. ");
                Console.WriteLine("\t3- Afficher Client. ");
                Console.WriteLine("\t4- Consulter Compte. ");
                Console.WriteLine("\t5- Créditer Compte. ");
                Console.WriteLine("\t6- Débiter Compte. ");
                Console.WriteLine("\t7- Verser. ");
                Console.WriteLine("\t8- Ajouter Compte Epargne. ");
                Console.WriteLine("\t9- Créditer Compte Epargne. ");
                Console.WriteLine("\t10- Débiter Compte Epargne. ");
                Console.WriteLine("\t11- Calculer Interêt. ");
                Console.WriteLine("\t12- Consulter Compte Epargne. ");
                Console.WriteLine("\t13- Ajouter Opérations. ");
                Console.WriteLine("\t14- Afficher Opérations. ");
                Console.WriteLine("\t15- Afficher Liste Comptes. ");
                Console.WriteLine("\t16- Ajouter Compte Courant. ");
                Console.WriteLine("\t0- Quitter. \n\n");
                do
                {

                    Console.Write("Entrer Votre Choix : \t");
                    CaseSwitch = int.Parse(Console.ReadLine());
                    if (CaseSwitch > 15 || CaseSwitch < 0)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine(" Votre choix doit etre compris entre 0 et 15 .\n ");
                    }

                } while (CaseSwitch > 15 || CaseSwitch < 0);

                switch (CaseSwitch)
                {
                    case 0:
                        {
                            System.Environment.Exit(1);
                        }
                        break;
                    case 1:
                        {
                            Console.WriteLine("\t\t**Ajouter Client** ");
                            Console.WriteLine("\t\t--------------------");
                            Console.WriteLine("---Donner les infos du client 1--- ");
                            Console.Write("    Nom :  "); string Nom1 = Console.ReadLine();
                            Console.Write("    Prénom :  "); string Prenom1 = Console.ReadLine();
                            Console.Write("    Adresse :  "); string Adresse1 = Console.ReadLine();
                            client1 = new Client(Nom1, Prenom1, Adresse1);
                            Console.WriteLine("Donner les infos du client 2 : ");
                            Console.Write("    Nom :  "); string Nom2 = Console.ReadLine();
                            Console.Write("    Prénom :  "); string Prenom2 = Console.ReadLine();
                            Console.Write("    Adresse :  "); string Adresse2 = Console.ReadLine();
                            client2 = new Client(Nom2, Prenom2, Adresse2);
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("\t\t**Ajouter Compte** ");
                            Console.WriteLine("\t\t--------------------");
                            Console.Write("Donnez une valeur du MAD pour le client 1 : "); valeur1 = double.Parse(Console.ReadLine());
                            Console.Write("Donnez une valeur du MAD pour le client 2 : "); valeur2 = double.Parse(Console.ReadLine());
                            MAD1 = new MAD(valeur1);
                            MAD2 = new MAD(valeur2);
                            cl1 = new Client("MOHAMED AMINE", "SAOUID", "Casa");
                            cl2 = new Client("AMINE", "SADAOUI", "Rabat");
                            compte1 = new Compte(cl1, MAD1);//création du compte 1
                            compte2 = new Compte(cl2, MAD2);//création du compte 2
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("\t\t**AfficherClient** ");
                            Console.WriteLine("\t\t--------------------");
                            Console.WriteLine("Client 1 : "); client1.Afficher();
                            Console.WriteLine("Client 2 : "); client1.Afficher();
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("\t\t**Afficher Compte** ");
                            Console.WriteLine("\t\t--------------------");
                            compte1.Consulter();
                            compte2.Consulter();
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("\t\t**Créditer Compte** ");
                            Console.WriteLine("\t\t--------------------");
                            do
                            {
                                Console.Write("Quel Compte vous voulez Créditer 1 ou 2: \t");
                                CaseSwitch = int.Parse(Console.ReadLine());
                                if (CaseSwitch > 2 || CaseSwitch < 1)
                                {
                                    Console.WriteLine("\n");
                                    Console.WriteLine("                  Il existe deux compte 1 et 2 .\n ");
                                }

                            } while (CaseSwitch > 2 || CaseSwitch < 1);
                            if (CaseSwitch == 1)
                            {
                                Console.Write("Donnez une valeur à créditer : "); double val1 = double.Parse(Console.ReadLine());
                                MAD cred = new MAD(val1);
                                if (compte1.Crediter(cred))
                                {
                                    Console.WriteLine("Compte 1 Créditer avec succé!!");

                                }
                                else
                                    Console.WriteLine("Compte 1 n'est pas créditer!!");
                            }
                            else
                            {
                                Console.Write("Donnez une valeur à créditer : "); double val1 = double.Parse(Console.ReadLine());
                                MAD cred = new MAD(val1);
                                if (compte2.Crediter(cred))
                                {
                                    Console.WriteLine("Compte 2 Créditer avec succé!!");

                                }
                                else
                                    Console.WriteLine("Compte 2 n'est pas créditer!!");
                            }
                        }
                        break;
                    case 6:
                        {
                            Console.WriteLine("\t\t**Débiter Compte** ");
                            Console.WriteLine("\t\t--------------------");
                            do
                            {
                                Console.Write("Quel Compte vous voulez Débiter 1 ou 2: \t");
                                CaseSwitch = int.Parse(Console.ReadLine());
                                if (CaseSwitch > 2 || CaseSwitch < 1)
                                {
                                    Console.WriteLine("\n");
                                    Console.WriteLine("                  Il existe deux compte 1 et 2 .\n ");
                                }

                            } while (CaseSwitch > 2 || CaseSwitch < 1);
                            if (CaseSwitch == 1)
                            {
                                Console.Write("Donnez une valeur à débiter : "); double val = double.Parse(Console.ReadLine());
                                MAD deb = new MAD(val);//plafond=2000 
                                if (compte1.Debiter(deb))
                                {
                                    Console.WriteLine("Compte 1 débiter avec succé!!");
                                }
                                else
                                    Console.WriteLine("Compte 1 n'est pas débiter!!");
                            }
                            else
                            {
                                Console.Write("Donnez une valeur à débiter : "); double val = double.Parse(Console.ReadLine());
                                MAD deb = new MAD(val);//plafond=2000 
                                if (compte2.Debiter(deb))
                                {
                                    Console.WriteLine("Compte 2 débiter avec succé!!");
                                }
                                else
                                    Console.WriteLine("Compte 2 n'est pas débiter!!");
                            }
                        }
                        break;
                    case 7:
                        {
                            Console.WriteLine("\t\t**Versement** ");
                            Console.WriteLine("\t\t--------------------");
                            Console.Write("Donnez une somme à verser : "); double S = double.Parse(Console.ReadLine());
                            MAD somme = new MAD(S);
                            if (compte1.Verser(compte2, somme))
                            {
                                Console.WriteLine("Virement bien passé !!");
                            }
                            else
                                Console.WriteLine("Virement échoué !!");
                        }
                        break;
                    case 8:
                        {
                            Console.WriteLine("\t\t**Ajouter Compte Epargne** ");
                            Console.WriteLine("\t\t--------------------");
                            compteepargne1 = new CompteEpange(client1, MAD1);
                            Console.WriteLine("Compte Epargne Ajouté !");
                        }
                        break;
                    case 9:
                        {
                            Console.WriteLine("\t\t**Créditer Compte Epargne** ");
                            compteepargne1.Crediter(new MAD(100));
                            Console.WriteLine("Compte Epargne 1 Crédité !");
                        }
                        break;
                    case 10:
                        {
                            Console.WriteLine("\t\t**Débiter Compte Epargne** ");
                            compteepargne1.Debiter(new MAD(100));
                            Console.WriteLine("Compte Epargne 1 Débité !");

                        }
                        break;
                    case 11:
                        {
                            Console.WriteLine("\t\t**Calcul Interêt** ");
                            Console.WriteLine("\t\t--------------------");
                            compteepargne1.CalculInteret();
                            Console.WriteLine("Le Taux d'interêt a bien été calculé !");
                        }
                        break;
                    case 12:
                        {
                            Console.WriteLine("\t\t**Consulter Compte Epargne** ");
                            Console.WriteLine("\t\t--------------------");
                            compteepargne1.Consulter();
                        }
                        break;
                    case 13:
                        {
                            Console.WriteLine("\t\t**Ajouter Opération** ");
                            Console.WriteLine("\t\t--------------------");
                            op1 = new Operaction("+", new MAD(300)); Console.WriteLine("Opération Ajouté!");
                            op2 = new Operaction("-", new MAD(100)); Console.WriteLine("Opération Ajouté!");
                        }
                        break;
                    case 14:
                        {
                            Console.WriteLine("\t\t**Afficher Opération** ");
                            Console.WriteLine("\t\t--------------------");
                            Console.Write("Operation 1 : "); op1.Afficher();
                            Console.Write("Operation 2 : "); op2.Afficher();
                        }
                        break;
                    case 15:
                        {
                            Console.WriteLine("\t\t**Afficher Liste Comptes** ");
                            Console.WriteLine("\t\t--------------------");
                            client1.AfficherListeComptes();
                            client2.AfficherListeComptes();
                        }
                        break;
                    case 16 :
                        {
                            Console.WriteLine("\t\t**Ajouter Compte Courant** ");
                            Console.WriteLine("\t\t--------------------");
                            CompteCourt CptCourant = new CompteCourt(client1, MAD1, new MAD(20), new CarteBancaire("Visa"));
                            CptCourant.Debiter(MAD2);
                            CptCourant.AjouterInteret(12);
                        }
                        break;
                }
            } while (CaseSwitch != 0);



            Console.ReadKey();





          


        }
    }
}
