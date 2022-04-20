using System;
using System.Collections.Generic;
using System.Text;

namespace MyAutoPark
{
    //public
    //private
    //internal
    //protected -> on ne l'a pas expliqué
    public class Car
    {
        #region constructeur(s)
        public Car(string couleur, string marque, string modele, int puissance)
        {
            Couleur = couleur;
            Marque = marque;
            Modele = modele;
            Puissance = puissance;
        }
        #endregion

        #region propriétés
        public string Couleur;
        public string Marque;
        public string Modele;
        public int Puissance;
        public int TailleRoues;
        public int NbPortes;
        public string Carburant;
        public int Kilometrage;
        #endregion


        #region méthodes
        /// <summary>
        /// Ajoute le nombre de kilomètres mentionnés à la propriété Kilometrage
        /// </summary>
        /// <param name="nbKilometres">Nombre de kilomètres à ajouter</param>
        public void Rouler(int nbKilometres)
        {
            Kilometrage += nbKilometres;
        }

        public void Rouler(string nbKilometres)
        {
            int nbKilometresInt = Convert.ToInt32(nbKilometres);
            Kilometrage += nbKilometresInt;
        }
        #endregion
    }


    //Je crée une autre classe

    //public class
    //public static class -> Ne sera pas instancié pourra êter appelée depuis son nom
    public static class CarburantsHelper
    {
        public static string getCarburant(string modele)
        {
            switch (modele)
            {
                case "308":
                    return "Gazoil";
                case "RCZ":
                    return "Essence";
                default:
                    return "électrique";
            }
        }
    }
}
