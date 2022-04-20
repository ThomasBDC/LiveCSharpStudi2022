using MaPremiereLibrairie;
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
                Kilometrage = 150000
            };

            string monCarbu = CarburantsHelper.getCarburant(PeugeotRczDeDominique.Carburant);

            //On utilise notre objet
            PeugeotRczDeDominique.Rouler(15);
            Console.WriteLine(PeugeotRczDeDominique.Marque + " " + PeugeotRczDeDominique.Modele);


            ClassDetest maClasse = new ClassDetest(12);

            maClasse.MyPublicProperty = 5;


            Class1.DisBonjour("LAurent");
            


            Console.ReadLine();
        }
    }
}
