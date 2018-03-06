using System;
using System.Collections.Generic;
using System.Text;

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

            /*
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("Hello ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("les couleurs");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" dans la console\n");
            */

            /*
            for (int i = 1; i <= 40; i++)
            {
                Console.WriteLine("Ligne numéro " + i);
                if (i % 10 == 0)
                {
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            */

            /*
            Console.WriteLine("Hello world");
            int x = Console.CursorLeft;
            int y = Console.CursorTop;
            Console.SetCursorPosition(25, 7);
            Console.WriteLine("Hello world aussi");
            Console.SetCursorPosition(x, y);
            Console.WriteLine("En dessous du premier");
            */

            /*
            CentrerLeTexte("Hello world");
            CentrerLeTexte("Je suis un texte plus long");
            */

            /*
            int i = 0;
            int j = 0;
            int largeur = 21;
            int hauteur = 4;
            Console.WriteLine(@"      .--------.");
            Console.WriteLine(@" ____/_____|___ \___");
            Console.WriteLine(@"O    _   - |   _   ,*");
            Console.WriteLine(@" '--(_)-------(_)--'");
            while (true)
            {
                ConsoleKeyInfo info = Console.ReadKey(true);
                switch (info.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (i > 0)
                        {
                            Console.MoveBufferArea(i, j, largeur, hauteur, i - 1, j);
                            i--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (i < Console.WindowWidth - largeur)
                        {
                            Console.MoveBufferArea(i, j, largeur, hauteur, i + 1, j);
                            i++;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (j > 0)
                        {
                            Console.MoveBufferArea(i, j, largeur, hauteur, i, j - 1);
                            j--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        Console.MoveBufferArea(i, j, largeur, hauteur, i, j + 1);
                        j++;
                        break;
                }
                if (info.Key == ConsoleKey.Q)
                    break;
            }
            */

            /*
            char cLight = Encoding.GetEncoding(850).GetChars(new byte[] { 176 })[0];
            char cDark = Encoding.GetEncoding(850).GetChars(new byte[] { 177 })[0];
            char cDarkLight = Encoding.GetEncoding(850).GetChars(new byte[] { 178 })[0];

            DessinerHerbe(cLight);
            DessinerMaison(cDark);
            DessinerToit(cDark);
            DessinerPorte(cDarkLight);

            Console.ResetColor();
            Console.SetCursorPosition(0, 20);
            Console.CursorVisible = false;
            Console.ReadKey(true);
            */

            /*
            int noteDo = 262;
            int noteRe = 294;
            int noteMi = 330;
            int noire = 400;
            int blanche = 800;

            Console.Beep(noteDo, noire);
            Console.Beep(noteDo, noire);
            Console.Beep(noteDo, noire);
            Console.Beep(noteRe, noire);
            Console.Beep(noteMi, blanche);
            Console.Beep(noteRe, blanche);
            Console.Beep(noteDo, noire);
            Console.Beep(noteMi, noire);
            Console.Beep(noteRe, noire);
            Console.Beep(noteRe, noire);
            Console.Beep(noteDo, noire);
            */

            string chaine = "12,25";
            int i = Convert.ToInt32(chaine);
            Console.WriteLine(i);
        }

        private static void CentrerLeTexte(string texte)
        {
            int nbEspaces = (Console.WindowWidth - texte.Length) / 2;
            Console.SetCursorPosition(nbEspaces, Console.CursorTop);
            Console.WriteLine(texte);
        }

        private static void DessinerPorte(char cDarkLight)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            for (int j = 0; j < 3; j++)
            {
                Console.SetCursorPosition(33, 11 + j);
                for (int i = 0; i < 4; i++)
                {
                    Console.Write(cDarkLight);
                }
            }
        }

        private static void DessinerToit(char cDark)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            for (int i = 0; i < 6; i++)
            {
                Console.SetCursorPosition(35 + i, i + 2);
                Console.Write(cDark);
                Console.SetCursorPosition(35 - i, i + 2);
                Console.Write(cDark);
            }
        }

        private static void DessinerMaison(char cDark)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            for (int j = 0; j < 7; j++)
            {
                Console.SetCursorPosition(30, 7 + j);
                for (int i = 0; i < 11; i++)
                {
                    Console.Write(cDark);
                }
            }
        }

        private static void DessinerHerbe(char cLight)
        {
            Console.SetCursorPosition(0, 10);
            Console.BackgroundColor = ConsoleColor.Green;
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < Console.WindowWidth; i++)
                {
                    Console.Write(cLight);
                }
            }
        }
    }
}
