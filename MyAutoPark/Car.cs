using System;
using System.Collections.Generic;
using System.Text;

namespace MyAutoPark
{
    public class Car
    {
        public string Couleur;
        public string Marque;
        public string Modele;
        public int Puissance;
        public int TailleRoues;
        public int NbPortes;
        public string Carburant;
        public int Kilometrage;

        /// <summary>
        /// Ajoute le nombre de kilomètres mentionnés à la propriété Kilometrage
        /// </summary>
        /// <param name="nbKilometres">Nombre de kilomètres à ajouter</param>
        public void Rouler(int nbKilometres)
        {
            Kilometrage += nbKilometres;
        }
    }
}
