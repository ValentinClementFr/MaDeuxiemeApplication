using System;

namespace MaDeuxiemeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Veuillez saisir une phrase et valider avec la touche \"Entrée\"");
            //string saisie = Console.ReadLine();
            //Console.WriteLine("Vous avez saisi : " + saisie);

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
        }
    }
}
