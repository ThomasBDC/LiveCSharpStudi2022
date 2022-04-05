using System;
using MaPremiereLibrairie;

namespace Calculatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans ma calculatrice en C# :");

            //TODO : Faire une calculatrice
            while (true)
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

                    //En fonction de la valeur de 'operation'
                    //Effectuer la bonne opération
                    double resultat = 0;
                    bool operateurOK = true;
                    switch (operation)
                    {
                        case "+":
                            resultat = monPremierVraiChiffre + monDeuxiemeVraiChiffre;
                            break;
                        case "-":
                            resultat = monPremierVraiChiffre - monDeuxiemeVraiChiffre;
                            break;
                        case "*" :
                        case "x" :
                        case "X" :
                            resultat = monPremierVraiChiffre * monDeuxiemeVraiChiffre;
                            break;
                        case "/": 
                            resultat = monPremierVraiChiffre / monDeuxiemeVraiChiffre;
                            break;
                        default :
                            operateurOK = false;
                            break;
                    }

                    if(operateurOK)
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
        }
    }
}
