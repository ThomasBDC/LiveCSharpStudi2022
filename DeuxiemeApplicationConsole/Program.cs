using System;
using MaPremiereLibrairie;

namespace Calculatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans ma calculatrice en C# :");

            bool continueExecution;
            do
            {
                doCalculComplet();

                //Savoir si l'utilisateur veut faire un autre calcul
                Console.WriteLine("Voulez-vous faire un autre calcul (O/N)?");
                string reponseContinueCalcul = Console.ReadLine();
                if (reponseContinueCalcul == "N" || reponseContinueCalcul == "n")
                {
                    continueExecution = false;
                }
                else
                {
                    continueExecution = true;
                }
            }
            while (continueExecution);
        }

        static void doCalculComplet()
        {
            Console.WriteLine("Début du calcul !");

            //Récupère le calcul auprès de l'utilisateur

            Console.WriteLine("Premier nombre : ");
            string premierChiffre = Console.ReadLine();

            Console.WriteLine("Opération (+ - / *)");
            string operation = Console.ReadLine();

            Console.WriteLine("Deuxième nombre");
            string deuxiemeChiffre = Console.ReadLine();

            //J'ai tout ce qu'il me faut dans mes variables
            //Faire le calcul
            try
            {
                int monPremierVraiChiffre = Convert.ToInt32(premierChiffre);
                int monDeuxiemeVraiChiffre = Convert.ToInt32(deuxiemeChiffre);

                var resultat = Calcul(monPremierVraiChiffre, operation, monDeuxiemeVraiChiffre);

                if (resultat != null)
                {
                    Console.WriteLine("Résultat : " + resultat);
                }
                else
                {
                    Console.WriteLine("L'opérateur n'est pas bon");
                }

                Console.WriteLine("");
            }
            catch (Exception ex)
            {
                Console.WriteLine("le nombre n'est pas bon");
            }
        }

        /// <summary>
        /// Retourne le résultat du calcul en fonction des nombres et de l'opérateur. Si l'opérateur n'est pas bon, retourne null
        /// Une divizion par 0 retourne l'exception ErrorDivideBy0
        /// </summary>
        /// <param name="nombre1">Premier nombre du calcul</param>
        /// <param name="operateur">Operateur de calcul (+,-,*,x,X,/)</param>
        /// <param name="nombre2">Deuxième nombre du calcul</param>
        /// <returns>Si opérateur ok -> résultat calcul sinon null</returns>
        static double? Calcul(int nombre1, string operateur, int nombre2)
        {
            double? resultat = 0;
            switch (operateur)
            {
                case "+":
                    resultat = nombre1 + nombre2;
                    break;
                case "-":
                    resultat = nombre1 - nombre2;
                    break;
                case "*":
                case "x":
                case "X":
                    resultat = nombre1 * nombre2;
                    break;
                case "/":
                    resultat = nombre1 / nombre2;
                    break;
                default:
                    resultat = null;
                    break;
            }

            return resultat;
            //Tout le code après le return n'est jamais exécuté
        }
    }
}
