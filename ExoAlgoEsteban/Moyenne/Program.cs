using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moyenne
{
    class Program
    {
        static void Main(string[] args)
        {
            //saisie
            Console.WriteLine("Donnez moi la valeur de a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Donnez moi la valeur de b:");
            int b = int.Parse(Console.ReadLine());

            //traitement
            float m = (a+b)/2f;

            //affichage du resultat
            Console.WriteLine("la moyenne est "+m);
        }
    }
}
