using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aire_section_de_cercle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Donnez moi la valeur de r:");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Donnez moi la valeur de a:");
            int a = int.Parse(Console.ReadLine());

            double aire = (Math.PI * r * a) / 360;
            Console.WriteLine("La valeur de l'aire circulaire est " + aire);
        }
    }
}
