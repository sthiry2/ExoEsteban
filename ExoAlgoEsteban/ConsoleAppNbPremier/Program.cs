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
            Console.WriteLine("Donnez moi la valeur de e:");
            int e = int.Parse(Console.ReadLine()); // Nombre de l'Ensemble des entiers servant de diviseur. 
            Console.WriteLine("Donnez moi la valeur de m:");
            int m = int.Parse(Console.ReadLine()); // Module de la division
            Console.WriteLine("Donnez moi la valeur de r:");
            int r = int.Parse(Console.ReadLine()); // Résultat de la division (seulement si le résultat est entier)
           // if( n = 0 ) 
            {
                Console.WriteLine ("n n'est pas un nombre premier") ;
                


            }
        }
    }
}
