using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireEtVolume
{
    class Program
    {
        static void Main(string[] args)
        {
            //saisie
            Console.WriteLine("Donnez moi la valeur de r:");
            int r = int.Parse(Console.ReadLine());

            double aire = Math.PI * 4 *Math.Pow(r,2);

            Console.WriteLine("l'aire du cercle est "+aire);


            double volume = Math.PI * (4d/3) * Math.Pow(r, 3);

            Console.WriteLine("le volume du cercle est " + volume);
        }
    }
}