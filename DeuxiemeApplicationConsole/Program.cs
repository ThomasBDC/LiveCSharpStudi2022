using System;
using MaPremiereLibrairie;

namespace DeuxiemeApplicationConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faire une calculatrice
            while (true)
            {

                string premierChiffre = Console.ReadLine();
                string deuxiemeChiffre = Console.ReadLine();

            
                try
                {
                    int monPremierVraiChiffre = Convert.ToInt32(premierChiffre);
                    int monDeuxiemeVraiChiffre = Convert.ToInt32(deuxiemeChiffre);

                    Console.WriteLine(monPremierVraiChiffre + monDeuxiemeVraiChiffre);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("le nombre n'est pas bon");  
                }
            }
        }
    }
}
