using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Donnez moi la valeur de la somme:");
            double somme = double.Parse(Console.ReadLine());
            Console.WriteLine("Donnez moi la valeur de intérêt:");
            double intérêt = double.Parse(Console.ReadLine());
            Console.WriteLine("Donnez moi la valeur de nombreannée:");
            double nombreannée = double.Parse(Console.ReadLine());

            double intérêtsimple = somme*( 1 + nombreannée * (intérêt/100) ) ;
            Console.WriteLine("La valeur aquise de la Somme en fonction de l'intérêt simple et des années est de " + intérêtsimple);

            double intérêtcomposé = somme * Math.Pow((1 + (intérêt / 100)),nombreannée);
            Console.WriteLine("La valeur aquise de la Somme en fonction de l'intérêt simple et des années est de " + intérêtcomposé);
        }
    }
}
