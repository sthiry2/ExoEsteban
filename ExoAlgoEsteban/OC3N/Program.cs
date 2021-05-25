using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC3N
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Donnez moi la valeur de a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Donnez moi la valeur de b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Donnez moi la valeur de c:");
            int c = int.Parse(Console.ReadLine());

            if (c < a)
            {
                if (c < b)
                {
                    if (a < b)
                    {
                        Console.WriteLine("c, a, b");
                    }
                    else
                    {
                        Console.WriteLine("c, b, a");
                    }
                }
                else
                {
                    if (a > b)
                    {
                        Console.WriteLine("c, a, b");
                    }
                    else
                    {
                        Console.WriteLine("b, c, a");
                    }
                }
            }
            else
            {
                if (c > b)
                {
                    if (a > b)
                    {
                        Console.WriteLine("b, a, c");
                    }
                    else
                    {
                        Console.WriteLine("a, b, c");
                    }
                }
                else
                {
                    if (a < b)
                    {
                        Console.WriteLine("a, c, b");
                    }
                    else
                    {
                        Console.WriteLine("b, a, c");
                    }
                }
            }
           }
    }
}
