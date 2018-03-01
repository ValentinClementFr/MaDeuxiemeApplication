using System;
using System.Collections.Generic;

namespace MaDeuxiemeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Veuillez saisir une phrase et valider avec la touche \"Entrée\"");
            //string saisie = Console.ReadLine();
            //Console.WriteLine("Vous avez saisi : " + saisie);

            /*
            bool ageIsValid = false;
            int age = -1;
            while (!ageIsValid)
            {
                Console.WriteLine("Veuillez saisir votre age");
                string saisie = Console.ReadLine();
                if (int.TryParse(saisie, out age))
                    ageIsValid = true;
                else
                {
                    ageIsValid = false;
                    Console.WriteLine("L'age que vous avez saisi est incorrect ...");
                }
            }
            Console.WriteLine("Votre âge est de : " + age);
            */

            /*
            Console.WriteLine("Veuillez appuyer sur une touche pour démarrer le calcul ...");
            Console.ReadKey(true);
            int somme = 0;
            for (int i = 0; i < 100; i++)
            {
                somme += i;
            }
            Console.WriteLine(somme);
            */

            /*
            Console.WriteLine("Voulez-vous continuer (O/N) ?");
            ConsoleKeyInfo saisie = Console.ReadKey(true);
            if (saisie.Key == ConsoleKey.O)
            {
                Console.WriteLine("On continue ...");
            }
            else
            {
                Console.WriteLine("On s'arrête ...");
            }
            */

            int valeurATrouver = new Random().Next(1, 101);
            bool numeroOk = false;
            int compteur = 0;

            Console.WriteLine("Veuillez entrer un numero entre 1 et 100");

            while (!numeroOk)
            {
                string saisie = Console.ReadLine();

                if (int.TryParse(saisie, out int numero))
                {
                    if (numero > valeurATrouver)
                    {
                        Console.WriteLine("Moins");
                        compteur++;
                    }
                    else if(numero < valeurATrouver)
                    {
                        Console.WriteLine("Plus");
                        compteur++;
                    }
                    else if(numero == valeurATrouver)
                    {
                        Console.WriteLine("Gagné !!");
                        Console.WriteLine("Vous avez joué " + compteur + " fois");
                        numeroOk = true;
                    }
                }
                else
                {
                    Console.WriteLine("La valeur entrée n'est pas un nombre");
                }
            }
        }

        static int CalculSommeIntersection()
        {
            List<int> multiplesDe3 = new List<int>();
            List<int> multiplesDe5 = new List<int>();

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    multiplesDe3.Add(i);
                if (i % 5 == 0)
                    multiplesDe5.Add(i);
            }

            int somme = 0;
            foreach (int m3 in multiplesDe3)
            {
                foreach (int m5 in multiplesDe5)
                {
                    if (m3 == m5)
                        somme += m3;
                }
            }
            return somme;
        }
    }
}
