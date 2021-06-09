using System;

namespace Fourchette
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaration des variables

            int nombre_ordinateur;
            int nombre_propose_par_Joueur;
            int limite_inferieur;
            int limite_superieur;


            //initialisation des variables

            limite_inferieur = 0;
            limite_superieur = 100;
            nombre_ordinateur = new Random().Next(limite_inferieur, limite_superieur);
            Console.WriteLine("Bonjour dans ce  jeux de la fourchette l'ordinateur à pris un nombre entier naturel situé entre 0 et 100");
            Console.WriteLine(", a vous de trouver ce nombre en cherchant entre les limites supérieurs et inférieurs.");

            //saisie du nombre de  l'utilisateur
            do
            {
                nombre_propose_par_Joueur = int.Parse(Console.ReadLine());
                if (nombre_propose_par_Joueur < limite_inferieur || nombre_propose_par_Joueur > limite_superieur)
                {
                    Console.WriteLine("Le nombre n'est pas dans l'intervalle " + limite_inferieur + " et " + limite_superieur+ " Veuillez me donner un nouveau nombre svp:");
                }
            }
            while (nombre_propose_par_Joueur < limite_inferieur || nombre_propose_par_Joueur > limite_superieur);






            //traitement
            do
            {
                //répéter?
                while (nombre_propose_par_Joueur != nombre_ordinateur)
                {
                    if ( limite_inferieur < nombre_propose_par_Joueur << nombre_ordinateur )
                    {
                        limite_inferieur = nombre_propose_par_Joueur;
                    }
                    else if ( nombre_ordinateur << nombre_propose_par_Joueur < limite_superieur )
                    {
                        limite_superieur = nombre_propose_par_Joueur;
                    }
                    Console.WriteLine("Si vous n'avez pas trouver le bon nombre alors, choisissez-en un autre.");
                    nombre_propose_par_Joueur = int.Parse(Console.ReadLine());
                }
                
            }
            while (nombre_propose_par_Joueur < limite_inferieur || nombre_propose_par_Joueur > limite_superieur);
            
        }
    }
}
