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
            Console.WriteLine("Donnez moi la valeur de jour:");
            int jour = int.Parse(Console.ReadLine());

            Console.WriteLine("Donnez moi la valeur de Mois:");
            string mois = Console.ReadLine();

            Console.WriteLine("Donnez moi la valeur de Année entre 1900 et 2000 éxclue:");
            int année = int.Parse(Console.ReadLine());

            if (1900<=année & année<2000)
            {
                int résultat1 = année - 1900;
                int résultat4 = résultat1 % 4;
                int valeurmois = int.Parse(Console.ReadLine());

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

                if (mois == "Février")
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

                if (mois == "Mars")
                {
                    valeurmois = 4;
                }

                if (mois == "Avril")
                {
                    valeurmois = 0;
                }

                if (mois == "Mai")
                {
                    valeurmois = 2;
                }

                if (mois == "Juin")
                {
                    valeurmois = 5;
                }

                if (mois == "Juilliet")
                {
                    valeurmois = 0;
                }

                if (mois == "Août")
                {
                    valeurmois = 3;
                }

                if (mois == "Septembre")
                {
                    valeurmois = 6;
                }

                if (mois == "Octobre")
                {
                    valeurmois = 1;
                }

                if (mois == "Novembre")
                {
                    valeurmois = 4;
                }

                if (mois == "Decembre")
                {
                    valeurmois = 6;
                }

                int reste7 = (résultat1 + résultat4 + valeurmois + jour) % 7;
            }
            else 
            {
                Console.WriteLine("Hors-Limte");
            }
        }
    }
}
