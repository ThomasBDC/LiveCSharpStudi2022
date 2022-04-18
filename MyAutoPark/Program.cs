using System;

namespace MyAutoPark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Créer notre objet en instanciant notre classe
            Car PeugeotRczDeDominique = new Car();
            //On va donner les propriétés de notre objet
            PeugeotRczDeDominique.Couleur = "Gris";
            PeugeotRczDeDominique.Marque = "Peugeot";
            PeugeotRczDeDominique.Modele = "RCZ";
            PeugeotRczDeDominique.Puissance = 156;
            PeugeotRczDeDominique.TailleRoues = 17;
            PeugeotRczDeDominique.NbPortes = 3;
            PeugeotRczDeDominique.Carburant = "Gazoil";
            PeugeotRczDeDominique.Kilometrage = 150000;
            
            //On utilise notre objet
            PeugeotRczDeDominique.Rouler(15);
            Console.WriteLine(PeugeotRczDeDominique.Marque + " " + PeugeotRczDeDominique.Modele);


            Console.ReadLine();
        }
    }
}
