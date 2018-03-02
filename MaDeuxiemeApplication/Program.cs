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

            /*
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
            */

            /*
            foreach (string parametre in args)
            {
                Console.WriteLine(parametre);
            }
            */

            /*
            foreach (string parametre in Environment.GetCommandLineArgs())
            {
                Console.WriteLine(parametre);
            }
            */

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("Hello ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("les couleurs");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" dans la console\n");
        }
    }
}
