using System;
using System.Collections.Generic;
using System.Text;

namespace MyAutoPark
{
    public class Livre
    {
        public Livre(string titreCtor)
        {
            Titre = titreCtor;
        }
        //Pour déclarer une propriété en C#, on la déclare ainsi :

        //Accesseur type nom {get; set;}

        public string Titre { get; set; }
        public string Synopsis { get; set; }
        public string Auteur { get; set; }
        public DateTime DateSortie { get; set; }

    }
}
