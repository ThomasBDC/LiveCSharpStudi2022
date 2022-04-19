using System;

namespace MyAutoPark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Déclaration de variable
            string toto;

            //Instanciation, valorisation, ajouter une valeur
            toto = "ma valeur";

            //Utilisation
            Console.WriteLine(toto);
            toto.Substring(1);

                        
            //Créer notre objet en instanciant notre classe
            Car PeugeotRczDeDominique = new Car("Gris", "Peugeot", "RCZ", 156) 
            { 
                TailleRoues = 17,
                NbPortes = 3,
                Carburant = " Gazoil",
                Kilometrage = 150000
            };
            
            //On utilise notre objet
            PeugeotRczDeDominique.Rouler(15);
            Console.WriteLine(PeugeotRczDeDominique.Marque + " " + PeugeotRczDeDominique.Modele);


            Console.ReadLine();
        }
    }
}
