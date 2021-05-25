using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Changement_de_Contenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Donnez moi la valeur de a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Donnez moi la valeur de b:");
            int b = int.Parse(Console.ReadLine());
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("La valeur de a est " + a); 
            Console.WriteLine("Tandis que La valeeur de b est " + b);
        }
    }
}
