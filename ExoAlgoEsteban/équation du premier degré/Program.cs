using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace équation_du_premier_degré
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("On cherche la valeur de x pour l'équation a*x + b = 0:");
            Console.WriteLine("Avec la valeur de a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Avec la valeur de b:");
            int b = int.Parse(Console.ReadLine());
            float x;
            if(a==0 && b==0)
            {
                Console.WriteLine("équation indéterminée");
            }
            else
            {
                if (a == 0 && b != 0)
                {
                    Console.WriteLine("équation inpossible");
                }
                else
                {
                    x = -b / a;
                    Console.WriteLine("la valeur de x = " + x);
                }
            }
        }
    }
}
