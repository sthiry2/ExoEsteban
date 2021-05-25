using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valeur_Absolue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Donnez moi la valeur de a:");
            float a = float.Parse(Console.ReadLine());
            if (a < 0) 
            {
                a = a * -1;
            }

            Console.WriteLine("La valeur absolue de a est " + a);
        }
    }
}
