using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendrier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Donnez moi le nombre du jour:");
            int jour = int.Parse(Console.ReadLine());

            Console.WriteLine("Donnez moi le nombre du Mois:");
            string mois = Console.ReadLine();

            Console.WriteLine("Donnez moi le nombre de l'Année entre 1900 inclue et 2000 éxclue:");
            int année = int.Parse(Console.ReadLine());

            if (1900<=année & année<2000)
            {
                int année2chiffres = année - 1900;
                int résultat4 = année2chiffres / 4;
                int valeurmois = 0 ;
                string nomjour = "" ;

                if (mois == "Janvier")
                {
                    if (résultat4 == 0)
                    {
                        valeurmois = 0;
                    }
                    else
                    {
                        valeurmois = 1;
                    }
                }
                else if (mois == "Février")
                {
                    if (résultat4 == 0)
                    {
                        valeurmois = 3;
                    }
                    else
                    {
                        valeurmois = 4;
                    }
                }
                else if (mois == "Mars")
                {
                    valeurmois = 4;
                }
                else if (mois == "Avril")
                {
                    valeurmois = 0;
                }
                else if (mois == "Mai")
                {
                    valeurmois = 2;
                }
                else if (mois == "Juin")
                {
                    valeurmois = 5;
                }
                else if (mois == "Juilliet")
                {
                    valeurmois = 0;
                }
                else if (mois == "Août")
                {
                    valeurmois = 3;
                }
                else if (mois == "Septembre")
                {
                    valeurmois = 6;
                }
                else if (mois == "Octobre")
                {
                    valeurmois = 1;
                }
                else if (mois == "Novembre")
                {
                    valeurmois = 4;
                }
                else if (mois == "Decembre")
                {
                    valeurmois = 6;
                }
                Console.WriteLine("la valeur du mois est " + valeurmois);
                int reste7 = (année2chiffres + résultat4 + valeurmois + jour) % 7;
                if (reste7 == 1)
                {
                    nomjour = "Dimanche";
                }
                else if (reste7 == 2)
                {
                    nomjour = "Lundi";
                }
                else if (reste7 == 3)
                {
                    nomjour = "Mardi";
                }
                else if (reste7 == 4)
                {
                    nomjour = "Mercredi";
                }
                else if (reste7 == 5)
                {
                    nomjour = "Jeudi";
                }
                else if (reste7 == 6)
                {
                    nomjour = "Vendredi";
                }
                else if (reste7 == 0)
                {
                    nomjour = "Samedi";
                }
                Console.WriteLine(" Le jour de cette année là était un " + nomjour);
            }
            else 
            {
                Console.WriteLine("Hors-Limte");
            }
        }
    }
}
