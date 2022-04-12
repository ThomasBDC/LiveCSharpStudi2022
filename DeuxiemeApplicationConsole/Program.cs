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
                DoCalculComplet();

                continueExecution = AskYesNo("Voulez-vous faire un nouveau calcul ? (O/N)");
            }
            while (continueExecution);
        }
        static void DoCalculComplet()
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

                var resultat = Calcul(monPremierVraiChiffre, monDeuxiemeVraiChiffre, operation);

                var resultatAddition = Calcul(monPremierVraiChiffre, monDeuxiemeVraiChiffre);

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
        /// Si aucun operateur n'est donné, cela fera une addition
        /// </summary>
        /// <param name="nombre1">Premier nombre du calcul</param>
        /// <param name="operateur">Operateur de calcul (+,-,*,x,X,/)</param>
        /// <param name="nombre2">Deuxième nombre du calcul</param>
        /// <returns>Si opérateur ok -> résultat calcul sinon null</returns>
        static double? Calcul(int nombre1, int nombre2, string operateur = "+")
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

        /// <summary>
        /// Pose une question à l'utilisateur dans la console. 
        /// </summary>
        /// <param name="questionADemander">Question qui sera affichée dans la console</param>
        /// <returns>Retourne un booléen en fonction de la réponse utilisateur</returns>
        static bool AskYesNo(string questionADemander = "Voulez-vous continuer ?")
        {
            //Ecrire la question à l'utilisateur 
            Console.WriteLine(questionADemander);
            //Ecouter sa réponse
            string reponse = Console.ReadLine();
            //Vérifier si elle vaut N ou n
            if (reponse == "N" || reponse == "n")
            //Si oui retourner faux
            {
                return false;
            }
            //Sinon retouner vrai
            else
            {
                return true;
            }
        }

    }

}
