using System;

namespace Diviseur_de_Nombre
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("définir le nombre entier n");
            int n = int.Parse(Console.ReadLine());
            int x = 1;


            while (x != n+1)
            {
                //code que je repete ds la boucle
                int diviseur = n % x;
                if (diviseur == 0)
                {
                    Console.WriteLine(x + " est un divsiseur de " + n);
                }
                x++;
            }
        }
    }
}
