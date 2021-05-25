using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordre_Croissant_2_Nombres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Donnez moi la valeur de a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Donnez moi la valeur de b:");
            int b = int.Parse(Console.ReadLine());
            if (a<b)
            {
                Console.WriteLine("a, b");
            }
            else
            {
                Console.WriteLine("b, a");
            }
        }
    }
}
