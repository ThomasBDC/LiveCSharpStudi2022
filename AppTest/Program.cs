using System;
using System.Collections.Generic;
using System.Linq;

namespace AppTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO : Faire une application pour calculer une moyenne

            Console.WriteLine("Bienvenue dans votre application de calcul de moyenne.");

            Console.WriteLine("Tapez vos chiffres, puis entrée. Lorsque c'est bon, tapez OK");

            List<int> mesNombres = new List<int>();

            bool continueExecution = true;

            while (continueExecution)
            {
                string nombre = Console.ReadLine();

                try
                {
                    int nombreEntier = Convert.ToInt32(nombre);
                    mesNombres.Add(nombreEntier);
                }
                catch(Exception ex)
                {
                    continueExecution = false;
                }
            }

            //Calcul de la moyenne

            int total = 0;
            foreach (int nombreCourant in mesNombres)
            {
                total = total + nombreCourant;
            }


            // int              double  /  int     => double
            var moyenne = (double)total / mesNombres.Count;
            moyenne = Math.Round(moyenne, 2);
            Console.WriteLine("Moyenne : "+ moyenne);

            Console.ReadLine();

        }
    }
}
