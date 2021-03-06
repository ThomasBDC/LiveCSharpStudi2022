using System;
using System.Collections.Generic;
using System.Text;

namespace MyAutoPark
{
    //public
    //private
    //internal
    //protected -> on ne l'a pas expliqué
    public class Car : Vehicule, IVehiculeAction
    {
        #region constructeur(s)
        public Car(string couleur, string marque, string modele, int puissance) : base(couleur, marque, modele, puissance)
        {
            //Constructeur de car
        }
        #endregion

        #region propriétés
        public int NbPortes { get; set; }
        public bool IsDecapotable { get; set; }
        public bool HaveClim { get; set; }
        public int NbCeintureSecurite { get; set; }

        public void CommentTourner()
        {
            Console.WriteLine("Avec le volant");
        }

        public string QuelPermis()
        {
            return "Permis B";
        }
        #endregion

        #region méthodes

        #endregion
    }
}
