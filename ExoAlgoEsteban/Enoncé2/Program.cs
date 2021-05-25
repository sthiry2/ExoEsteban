using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enoncé2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Selon le temps de demain je prendrais ma décision");

            Console.WriteLine("Fait-il beau?");
            string reponse = Console.ReadLine();


            if (reponse == "oui")
            {
                Console.WriteLine("Si le temps est bon, j'irais vérifier ma bicyclette");

                Console.WriteLine("Est-elle en état de rouler?");
                string reponse2 = Console.ReadLine();

                if (reponse2 == "oui")
                {
                    Console.WriteLine("j'irais faire une ballade à bicyclette.");
                }
                else
                {
                
                    Console.WriteLine("Si ma bicyclette est en mauvais état j'irais voirs le garagiste pour la faire immédiattement réparer");

                    Console.WriteLine("Est-il possible de remettre ma bicyclette en état de rouler pour cette jounée?");
                    string reponse6 = Console.ReadLine();

                    if (reponse6 == "oui")
                    {
                        Console.WriteLine("j'irais faire une ballade à bicyclette.");
                    }
                    else
                    {
                        Console.WriteLine("j'irais faire une ballade à pied jusqu'à l'étang ceullir des joncs.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Si le temps est mauvais, j'irais chercher un livre qui me plaît.");

                Console.WriteLine("Ai-je Madame Beauvary dans ma bibliothèque de salon?");
                string reponse3 = Console.ReadLine();

                if (reponse3 == "oui")
                {
                    Console.WriteLine("J'irais m'installer comfortablement dans mon fauteuil, pour me plonger dans ma lecture");
                }
                else
                {
                    Console.WriteLine("Le livre Madame Beauvary n'est pas dans ma propre bibliothèque, donc je sors voir à la bibliothèque municipale.");

                    Console.WriteLine("Ai-je Madame Beauvary dans la bibliothèque municipale?");
                    string reponse5 = Console.ReadLine();

                    if (reponse5 == "oui")
                    {
                        Console.WriteLine("J'irais m'installer comfortablement dans mon fauteuil, pour me plonger dans ma lecture.");
                    }
                    else
                    {
                        Console.WriteLine("Je prendrais alors un livre policier qui me plaît.");
                        Console.WriteLine("J'irais m'installer comfortablement dans mon fauteuil, pour me plonger dans ma lecture.");
                    }
                }
            }            
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          }
    }
}
