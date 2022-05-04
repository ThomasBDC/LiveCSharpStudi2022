using MaPremiereLibrairie;
using System;

namespace MyAutoPark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car MaVoiture = new Car("Gris", "Peugeot", "RCZ", 156)
            {
                NbCeintureSecurite = 12
            };


            Console.WriteLine(MaVoiture);






















            Livre monLivrePrefere = new Livre("Le petit prince")
            {
                Auteur = "Antoine de St Exupéry",
                Synopsis = "Un petit prince qui arrive sur terre et recontre un explorateur",
                DateSortie = new DateTime(1944, 01, 05)
            };

            monLivrePrefere.Auteur = "Booder";

            monLivrePrefere.Titre = "Ma vie de moi";

            Console.WriteLine(monLivrePrefere.Titre);




            Console.WriteLine("Hello World!");

            //Déclaration de variable
            string toto;

            //Instanciation, valorisation, ajouter une valeur
            toto = "ma valeur";

            //Utilisation
            Console.WriteLine(toto);
            toto.Substring(1);

            Console.WriteLine("Donnez moi votre carburant : ");

















            var meEnums = Enum.GetValues(typeof(MesCarburants));

            foreach(var monEnum in meEnums)
            {
                Console.WriteLine((int)monEnum + " " + monEnum.ToString());
            }

            int monCarburant = Convert.ToInt32(Console.ReadLine());

            //Créer notre objet en instanciant notre classe
            Car PeugeotRczDeDominique = new Car("Gris", "Peugeot", "RCZ", 156)
            {
                TailleRoues = 17,
                NbPortes = 3,
                Kilometrage = 150000
            };

            Moto maMoto = new Moto("Gris", "Derbi", "Senda", 15)
            {
                TailleRoues = 12,
                Kilometrage = 5000
            };

            PeugeotRczDeDominique.Carburant = (MesCarburants)monCarburant;

            //On utilise notre objet
            PeugeotRczDeDominique.Rouler(15);
            Console.WriteLine(PeugeotRczDeDominique.Marque + " " + PeugeotRczDeDominique.Modele + 
                " Carburant :" +PeugeotRczDeDominique.Carburant );


            ClassDetest maClasse = new ClassDetest(12);

            maClasse.MyPublicProperty = 5;


            Class1.DisBonjour("LAurent");
            


            Console.ReadLine();
        }
    }
}
