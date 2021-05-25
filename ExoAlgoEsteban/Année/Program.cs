using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Année
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Donnez moi la valeur de A:");
            int A = int.Parse(Console.ReadLine());
            if (A%4 == 0)
            {
                if (A % 100 == 0 & A % 400 != 0)
                {
                    Console.WriteLine("Non bisextile selon les conditions suivant le cas");
                }
                else
                {
                    Console.WriteLine("Bisextile");
                }
            }
            else
            {
                Console.WriteLine("Non bisextile selon les conditions suivant le cas");
            }
        }
    }
}
