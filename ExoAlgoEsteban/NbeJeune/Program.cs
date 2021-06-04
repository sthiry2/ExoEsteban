using System;

namespace NbeJeune
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("On cherche le nombre de jeune gens.");
            int[] nbStagF = new int[20];
            nbStagF[0] = 45;
            nbStagF[1] = 35;
            nbStagF[2] = 65;
            nbStagF[3] = 76;
            nbStagF[4] = 34;
            nbStagF[5] = 20;
            nbStagF[6] = 20;
            nbStagF[7] = 30;
            nbStagF[8] = 30;
            nbStagF[9] = 30;
            nbStagF[10] = 20;
            nbStagF[11] = 20;
            nbStagF[12] = 30;
            nbStagF[13] = 20;
            nbStagF[14] = 30;
            nbStagF[15] = 20;
            nbStagF[16] = 20;
            nbStagF[17] = 8;
            nbStagF[18] = 15;
            nbStagF[19] = 23;
            int compteurDeNbJeune=0;
            for (int i = 0; i < nbStagF.Length; i++)
            {
                if (nbStagF[i] <= 20)
                {
                    compteurDeNbJeune++;
                }
            }
            Console.WriteLine("Il y a " + compteurDeNbJeune + " jeune(s)");
        }
    }
}
