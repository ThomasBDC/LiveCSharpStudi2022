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

        //SET
        //Couleur = "rouge"
        //GET
        //var maCouleur = Couleur;

        public string Couleur { get; set; }
        public string Marque { get; set; }  
        public string Modele { get; set; }
        public int Puissance { get; set; }
        public int TailleRoues { get; set; }
        public int NbPortes { get; set; }

        

        //Gazoil, Essence, Ethanol, Electrique, Hybrid, Gpl
        //Doit avoir une valeur parmis un liste
        public MesCarburants Carburant { get; set; } 
        public int Kilometrage { get; set; }
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
        public static string[] MesCarburantsTab = new string[] { "Gazoil", "Essence", "Ethanol" };

        public static MesCarburants getCarburant(string modele)
        {
            switch (modele)
            {
                case "308":
                    return MesCarburants.Gazoil;
                case "RCZ":
                    return MesCarburants.Sp98;
                default:
                    return MesCarburants.Electrique;
            }
        }
    }


    public enum MesCarburants
    {
        Gazoil = 0,
        Sp95 = 1,
        Sp98 = 2,
        Ethanol = 3,
        Electrique = 4,
        Hybrid = 5,
        Gpl = 6
    }
}
