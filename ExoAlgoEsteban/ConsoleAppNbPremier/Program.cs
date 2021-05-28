using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNbPremier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Donnez moi la valeur de n:");
            int n = int.Parse(Console.ReadLine()); // Nombre de l'Ensemble des entiers dont on cherche à déterminer si il est premier ou non
            if ( n == 0 || n == 1) 
            {
                Console.WriteLine ("n n'est pas un nombre premier") ;
            }
            else 
            {
                int diviseur = 2;
                int reste = 0;
                do
                {
                    reste = n%diviseur;// Module de la division
                    diviseur++;
                }
                while (reste != 0);
                if (diviseur-1 != n)
                {
                    Console.WriteLine("n n'est pas un nombre premier");
                }
                else
                {
                    Console.WriteLine("n est un nombre premier");
                }
            }
        }
    }
}
