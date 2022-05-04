using System;
using System.Collections.Generic;
using System.Text;

namespace MyAutoPark
{
    //public
    //private
    //internal
    //protected -> on ne l'a pas expliqué
    public class Moto : Vehicule, IVehiculeAction
    {
        #region constructeur(s)
        public Moto(string couleur, string marque, string modele, int puissance) : base(couleur, marque, modele, puissance) 
        {
        }
        #endregion

        #region propriétés
        public bool CanHaveTopCase { get; set; }
        public bool FourcheInversee { get; set; }

        public void CommentTourner()
        {
            Console.WriteLine("Pencher et guidon");
        }

        public string QuelPermis()
        {
            return "permis moto";
        }

        #endregion

        #region méthodes

        #endregion
    }
}
