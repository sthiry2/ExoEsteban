using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoEnoncé
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pour l'énoncé, vous ferez une lecture attentive.");

            Console.WriteLine("Avez-vous compris?");
            string reponse = Console.ReadLine();


            if (reponse != "oui")
            {
                Console.WriteLine("Si malgré tout, il vous semble ne pas l'avoir compris, vous le relirez."); 

                Console.WriteLine("Avez-vous compris?");
                string reponse2 = Console.ReadLine();

                if (reponse2 != "oui")
                {
                    Console.WriteLine("Si après cette relecture, le texte ne vous paraît pas clair, vous demanderez des renseigment complémentaires à l'un de vos formateurs.");
                }
            }
            Console.WriteLine("écrire le pseudo-code, ");
            Console.WriteLine("vérifier le pseudo-code, ");
            Console.WriteLine("écrire le programme, ");
            Console.WriteLine("constituer le jeu d'essai, ");
            Console.WriteLine("tester le programe.");
            
        }
    }
}
